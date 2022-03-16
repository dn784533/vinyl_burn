// This file is part of Vinyl Burn.
//
// Vinyl Burn is free software: you can redistribute it and/or modify it under the
// terms of the GNU General Public License as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.
//
// Vinyl Burn is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with Vinyl Burn.
// If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
using SideDetails;
using DataObjects;

namespace VinylBurnUI
{

    public partial class MainForm : Form
    {
        SideDetailsControl mySide;
        private SplashForm splashForm;
        private bool autoDetectionComplete = false;
        private string arduinoDevice;
        private SerialHandler serialHandler;
        private ToolTip toolTip;
        private int CtrlEnables;
        private string SideFileName = "";


        private int RecdStepsTaken;
        private int EndSegmentAtStepsTaken;
        private int RecdLimitLo;
        private int RecdLimitHi;

        // Variables to keep track of things while cutting
        private int currTrackIndex;
        private Phase currPhase;
        private Phase CurrPhase
        {
            get { return currPhase; }
            set
            {
                currPhase = value;
                tslStatus.Text = value.ToString();
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Constructor for form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            UpdateTitle();
            saveAsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            CtrlEnables = 0;
            EnableFormControls();
            DeselectSpeeds();
            // Add event handler to Load event 
            this.Load += new EventHandler(HandleFormLoad);
            // Create new Splash form, but don't show it yet
            this.splashForm = new SplashForm();
            // Tooltips for control buttons
            toolTip = new ToolTip();
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(dbn08rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(dbn16rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(dbn22rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(dbn33rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(dbn45rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(dbn39rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmdCutRecord, "Start cutting record");
            toolTip.SetToolTip(cmdReturnLathe, "Wind lathe to zero point");
            toolTip.SetToolTip(cmdLatheBack, "Wind lathe back");
            toolTip.SetToolTip(cmdStop, "Stop winding lathe");
            toolTip.SetToolTip(cmdLatheForth, "Wind lathe forward");
            toolTip.SetToolTip(cmdZero, "Reset lathe step counter to zero");
            toolTip.SetToolTip(cmdTestCut, "Start test cut");
            toolTip.SetToolTip(cmdInsertTrack, "Insert a track before this one");
            toolTip.SetToolTip(cmdAppendTrack, "Add a track to end of list");
            toolTip.SetToolTip(cmdRemoveTrack, "Remove this track");
            toolTip.SetToolTip(cmdMoveUp, "Move track up one");
            toolTip.SetToolTip(cmdMoveDown, "Move track down one");
            toolTip.SetToolTip(cmdUseFile, "Select music file");
            BackColor = GenMethods.Constants.FormBackColour;
            ForeColor = GenMethods.Constants.FormForeColour;

            // Set colours of status strip items
            foreach (ToolStripStatusLabel ct in stripStatus.Items)
            {
                ct.BackColor = GenMethods.Constants.FormBackColour;
                ct.ForeColor = GenMethods.Constants.FormForeColour;
            }
            axWMP1.uiMode = "full";
            axWMP1.settings.volume = 100; // Full volume on start-up
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called once this form has loaded. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleFormLoad(object sender, EventArgs e)
        {
            // Hide Main form, as we don't want to see it yet
            this.Hide();

            // Start new thread to show the Splash form
            Thread th = new Thread(new ThreadStart(ShowSplashForm));
            th.Start();

            // Create new instance of SerialHandler
            serialHandler = new SerialHandler();

            // and set the actions for events raised from it
            serialHandler.ArduinoDataRecd += (o, ex) =>
            {
                UpdateStripStatus(
                    ex.RecdStepsTaken,
                    ex.RecdLimitLo, ex.RecdLimitHi);
            };

            // Create new instance of AutoDetect
            AutoDetect ad = new AutoDetect();

            // and set the actions for events raised from it
            ad.ProgressChanged += (o, ex) =>
            {
                splashForm.UpdateProgress(ex.Progress);
            };
            ad.DetectionComplete += (o, ex) =>
            {
                autoDetectionComplete = true;
                this.Show();
            };
            // Try to find an Arduino at one of the ports
            arduinoDevice = ad.AutodetectArduinoPort(serialHandler);
            if (arduinoDevice == null)
                // Oh dear. No Arduino
                MessageBox.Show("Could not detect Arduino on any serial ports.");
            else
            {   // Success! An Arduino is present
                try
                {
                    // Open communications
                    serialHandler.OpenSerial(serArduino);
                    // And show the type of Arduino found
                    tslPort.Text = serialHandler.Hardware;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Shows splash form (on separate thread), and waits until
        /// the background processing is complete
        /// </summary>
        private void ShowSplashForm()
        {
            splashForm.Show();
            while (!autoDetectionComplete)
            {
                Application.DoEvents();
            }
            splashForm.Close();
            splashForm.Dispose();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Enable or disable controls according to property.
        /// The buttons are enabled (or disabled) according to the bit-values in CtrlEnables:
        /// bit 0 (=1), cmdZero (zeroise Arduino step counter)
        /// bit 1 (=2), cmdLatheForth (wind cutterhead towards centre of record)
        /// bit 2 (=4), cmdStop (stop the lathe motor)
        /// bit 3 (=8), cmdLatheBack (wind cutterhead away from centre of record)
        /// bit 4 (=16), cmdReturnLathe (move cutterhead to its home position 
        ///     - i.e. back or forth until Arduino step counter is at zero 
        /// bit 5 (=32), cmdCutRecord (start motor for cutting and play music tracks appropriately)
        /// bit 6 (=64),  pnlSpeed and pnlTrackAdmin (all buttons for turntable speed and track list settings)
        /// Some also depend on the status of limit switches.
        /// </summary>
        public void EnableFormControls()
        {
            cmdZero.Enabled = ((CtrlEnables & 1) > 0);
            cmdLatheForth.Enabled = ((CtrlEnables & 2) > 0) & (RecdLimitHi == 0);
            cmdStop.Enabled = ((CtrlEnables & 4) > 0);
            cmdLatheBack.Enabled = ((CtrlEnables & 8) > 0) & (RecdLimitLo == 0);
            cmdReturnLathe.Enabled = ((CtrlEnables & 16) > 0);
            cmdCutRecord.Enabled = ((CtrlEnables & 32) > 0) & (RecdLimitHi == 0);
            cmdTestCut.Enabled = ((CtrlEnables & 64) > 0) & (RecdLimitHi == 0);
            pnlSpeed.Enabled = ((CtrlEnables & 128) > 0);
            pnlTrackAdmin.Enabled = ((CtrlEnables & 128) > 0);
            if (mySide != null) mySide.Enabled = ((CtrlEnables & 64) > 0);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Turn all speed buttons back to their 'off' appearance
        /// </summary>
        public void DeselectSpeeds()
        {
            // Use RM to access the string name of the image resources
            //ResourceManager rm = Properties.Resources.ResourceManager;
            foreach (DataButton dbt in pnlSpeed.Controls)
                dbt.Disable();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// All speed buttons call this method to assign the 'on' image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dbnSpeed_Click(object sender, EventArgs e)
        {
            if (mySide != null)
            {
                DeselectSpeeds();
                DataButton dbt = (DataButton)sender;
                dbt.Enable();

                mySide.SpeedRPM = dbt.Speedx1;
                mySide.Recalculate();

                // Speed to set turntable is sent in hundredths of RPM, eg 3333 for 33 1/3.
                serialHandler?.SendDataToArduino(ArduinoXmitType.TTData, dbt.Speedx100);
            }
        }

        /// ------------------------------------------------------------------------------------------------------------
        /// Called when reading file data for an existing SideDetailsControl.
        /// This ensures that the correct speed button is active when the data is presented to the user.
        private void SelectSpeed(decimal iSpeedx1)
        {
            DeselectSpeeds();
            foreach (DataButton dbt in pnlSpeed.Controls)
            {
                if (dbt.Speedx1 == iSpeedx1)
                {
                    dbt.Enable();
                    // Speed to set turntable is sent in hundredths of RPM, eg 3333 for 33 1/3.
                    serialHandler?.SendDataToArduino(ArduinoXmitType.TTData, dbt.Speedx100);
                    break;
                }
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Button click events for track control panel
        /// ------------------------------------------------------------------------------------------------------------
        /// Uses OpenFileDialog to select a WAV file. Catered for within the SideDetailsControl itself.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUseFile_Click(object sender, EventArgs e)
        {
            mySide.UseSoundFile();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Create new track at end of list       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAppendTrack_Click(object sender, EventArgs e)
        {
            mySide.AppendTrack();
        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Create new track at current position in list       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInsertTrack_Click(object sender, EventArgs e)
        {
            mySide.AddTrack();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Move selected track down one place in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            mySide.MoveTrack(1, ltTrackCountMinus1);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        ///  Move selected track up one place in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            mySide.MoveTrack(-1, gt0);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Remove the selected track from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRemoveTrack_Click(object sender, EventArgs e)
        {
            mySide.RemoveTrack();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Helper functions for parameterised condition in MoveTrack method
        /// </summary>
        /// <param name="iArg"></param>
        /// <returns></returns>
        bool gt0(int iArg) { return iArg > 0; }
        bool ltTrackCountMinus1(int iArg) { return iArg < mySide.Tracks.Count - 1; }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Status update event called when Arduino data is received at the serial port.
        /// </summary>
        /// <param name="iRecdStepsTaken"></param>
        private void UpdateStripStatus(int iRecdStepsTaken,
            int iRecdLimitLo, int iRecdLimitHi)
        {
            RecdStepsTaken = iRecdStepsTaken;
            RecdLimitLo = iRecdLimitLo;
            RecdLimitHi = iRecdLimitHi;

            // Declare a delegate to update this form's controls
            MethodInvoker inv = delegate
            {
                // If the stepper has moved the required number of steps for this phase,
                // change to the next phase. (This in only done for gaps, run-in, pre-programme and run-outs;
                // the Media Player handles the end of a music track.)
                if (RecdStepsTaken >= EndSegmentAtStepsTaken) ChangePhase();
                // NB the code to physically stop the motor is on the Arduino itself, but 
                // the UI must be kept up to date: this is done by the method StopLathe. 
                // If the motor has made the required number of steps, or the high
                // limit switch is triggered, stop!
                if (CurrPhase > Phase.Idle && CurrPhase <= Phase.RunOut)
                    if (RecdStepsTaken >= mySide.TotalStepsReqd || RecdLimitHi > 0) StopLathe();
                // If seeking zero position, and Arduino signals that it has been reached
                // or the appropriate limit switch is triggered, stop!
                if (CurrPhase == Phase.ZeroForward)
                    if (RecdStepsTaken >= 0 || RecdLimitHi > 0) StopLathe();
                if (CurrPhase == Phase.ZeroBack)
                    if (RecdStepsTaken <= 0 || RecdLimitLo > 0) StopLathe(); 
                // If winding, and the appropriate limit switch is triggered
                if ((CurrPhase == Phase.BackWind && RecdLimitLo > 0)
                    || (CurrPhase == Phase.ForwardWind && RecdLimitHi > 0)) StopLathe();

                // Update status display fields
                decimal cutterCm = 1.00M * RecdStepsTaken / GenMethods.Constants.StepsPerRev * GenMethods.Constants.CmPerRev;
                tslMotorSteps.Text = "Motor: " + RecdStepsTaken.ToString() + " steps; " + String.Format("{0:0.00}", cutterCm) + " cm";
                tslLimitHi.BackColor = (RecdLimitHi > 0) ? GenMethods.Constants.FormErrorColour : GenMethods.Constants.FormBackColour;
                tslLimitLo.BackColor = (RecdLimitLo > 0) ? GenMethods.Constants.FormErrorColour : GenMethods.Constants.FormBackColour;
                tslEndPhaseAtStep.Text = "End phase at step: " + EndSegmentAtStepsTaken.ToString();
                EnableFormControls();
            };
            // Use Begin Invoke to avoid Serial Port trouble when closing
            BeginInvoke(inv);
        }


        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called once form has loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set current phase to default value
            CurrPhase = Phase.Idle;
        }


        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Starts play of the current track.
        /// </summary>
        /// <returns>true if file starts to play, otherwise false.</returns>
        public bool StartPlayingCurrentTrack()
        {
            // If the player isn't playing, start it.
            if (axWMP1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Set file to play
                try
                {
                    axWMP1.Ctlcontrols.play();
                }
                catch (System.IO.IOException e)
                {
                    MessageBox.Show(e.Message + ". Could not open file " + mySide.Tracks[currTrackIndex].FileName, "File error");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Stops play of the current track.
        /// </summary>
        public void StopPlayingCurrentTrack()
        {
            // Stop file playing and reset controls.
            axWMP1.Ctlcontrols.stop();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called when the WMP "MediaEnded" event (int value 8) fires.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWMP1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 8) // "MediaEnded"
            {
                if (CurrPhase > Phase.Idle && CurrPhase < Phase.RunOut)
                {
                    // If the track just ended is not the final one, cut a track gap
                    if (currTrackIndex < mySide.Tracks.Count - 1)
                    {
                        CurrPhase = Phase.TrackGap;
                        //CutSegment((int)mySide.Tracks[currTrackIndex].GapLPcm, mySide.Tracks[currTrackIndex].GapDurationMillisecs);
                        EndSegmentAtStepsTaken = RecdStepsTaken + mySide.Tracks[currTrackIndex].GapStepsRequired;
                        serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, (int)mySide.Tracks[currTrackIndex].GapLPcm);
                    }
                    else // If the track just ended is the last, go straight to the runout.
                    {
                        CurrPhase = Phase.RunOut;
                        //CutSegment(RunOutTicksPerStep, RunOutDurationMillisecs);
                        EndSegmentAtStepsTaken = mySide.TotalStepsReqd;
                        //CutSegment(mySide.RunOutLPcm, mySide.RunOutDurationMillisecs);
                        serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, (int)mySide.RunOutLPcm);
                    }
                }
                else
                {
                    // Just playback, not cutting.

                    // (no action)
                }
            }
        }

        /// <summary>
        /// Cut a segment of the record.
        /// Send lines-per-cm data to Arduino, and set timer to specified interval.
        /// </summary>
        /// <param name="iLPcm"></param>
        /// <param name="iDurationMillisecs"></param>
        private void CutSegment(int iLPcm, decimal iDurationMillisecs)
        {
            // Stop timer
            tmrSegment.Enabled = false;
            // Prime timer to fire after duration
            tmrSegment.Interval = (int)(iDurationMillisecs);
            // Send ticks figure to Arduino
            serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, iLPcm);
            // Start timer
            tmrSegment.Enabled = true;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// If not already cutting a record, starts cutting process.
        /// If already cutting, stops cutting process.
        /// </summary>
        private void CutRecord()
        {
            if (CurrPhase == Phase.Idle)
            {
                if (mySide.AreAllTracksAssignedToValidFiles())
                {
                    // Must zeroise step counter before starting, or cutting may end prematurely!
                    serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Zeroise);
                    mySide.SelectTrack(0);
                    CurrPhase = Phase.SetDown;
                    serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Forward);
                    serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, mySide.SetDownLPcm);
                    cmdCutRecord.Image = Properties.Resources._24x24_stop_cut;
                    toolTip.SetToolTip(cmdCutRecord, "Stop cutting record");
                    CtrlEnables = 32;
                    EnableFormControls();
                    EndSegmentAtStepsTaken = mySide.SetDownStepsRequired;
                    //CutSegment(mySide.SetDownLPcm, mySide.SetDownDurationMillisecs);
                    //serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, (int)mySide.SetDownLPcm);
                }
            }
            else
            {   // Shut down cutting process gracefully.
                tmrSegment.Enabled = false;
                StopPlayingCurrentTrack();
                CurrPhase = Phase.Idle;
                serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Stop);
                cmdCutRecord.Image = Properties.Resources._24x24_start_cut;
                toolTip.SetToolTip(cmdCutRecord, "Start cutting record");
                CtrlEnables = 255;
                EnableFormControls();
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Stop the motor once the required number of motor steps has been made.
        /// </summary>
        //private void EndRecord()
        //{
        //    CurrPhase = Phase.Idle;
        //    serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Stop);
        //    cmdCutRecord.Image = Properties.Resources._24x24_start_cut;
        //    CtrlEnables = 127;
        //    EnableFormControls();
        //}


        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Button click events for lathe control panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCutRecord_Click(object sender, EventArgs e)
        {
            CutRecord();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Return the lathe to its home position (depending on the Arduino step counter)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReturnLathe_Click(object sender, EventArgs e)
        {
            // If the cutter is not at the disc start, warn the user!
            if (RecdStepsTaken != 0)
            {
                // Is the user sure?
                if (DialogResult.OK == MessageBox.Show("This will move the cutter across the disc. ENSURE THE HEAD IS RAISED!", "WARNING", MessageBoxButtons.OKCancel))
                {
                    // Move cutter to zero mark
                    WindLathe(true, false);
                }
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Zeroise Arduino step counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdZero_Click(object sender, EventArgs e)
        {
            serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Zeroise);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Move cutter away from centre of record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLatheBack_Click(object sender, EventArgs e)
        {
            // Is the user sure?
            if (DialogResult.OK == MessageBox.Show("This will move the cutter across the disc. ENSURE THE HEAD IS RAISED!", "WARNING", MessageBoxButtons.OKCancel))
            {
                // Move cutter back
                WindLathe(false, false);
            }

        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Move cutter towards centre of record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLatheForth_Click(object sender, EventArgs e)
        {
            // Is the user sure?
            if (DialogResult.OK == MessageBox.Show("This will move the cutter across the disc. ENSURE THE HEAD IS RAISED!", "WARNING", MessageBoxButtons.OKCancel))
            {
                // Move cutter forwards
                WindLathe(false, true);
            }

        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Stop the lathe motor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStop_Click(object sender, EventArgs e)
        {
            StopLathe();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Helper functions.
        /// 
        /// Stop the lathe motor (if required)
        /// </summary>
        private void StopLathe()
        {
            CurrPhase = Phase.Idle;
            CtrlEnables = 255;
            cmdCutRecord.Image = Properties.Resources._24x24_start_cut;
            EnableFormControls();
            // The following command may not be required by the Arduino (if, for example, a limit switch
            // has already triggered code on the Arduino to shut the motor off). Sending it in such cases will
            // have no effect and will do no harm.
            serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Stop);
            tslEndPhaseAtStep.Text = "End phase at step: 0";

        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Fast-wind the lathe forward or back. Stops when the counter hits zero
        /// </summary>
        /// <param name="iGotoZero">Actively return to zero, whether forwards or backwards.</param>
        /// <param name="iForward">If not actively seeking zero, go forwards or backwards.</param>
        private void WindLathe(bool iGotoZero, bool iForward)
        {
            CtrlEnables = 132; // Speed and Track panels and STOP button enabled
            EnableFormControls();
            int arduinoCommand;
            if (iGotoZero)
            {
                //CurrPhase = Phase.GoHome;
                //arduinoCommand = (int)ArduinoCommand.GoHome;

                if (RecdStepsTaken > 0)
                {
                    CurrPhase = Phase.ZeroBack;
                    arduinoCommand = (int)ArduinoCommand.GoHome;
                }
                else
                {
                    CurrPhase = Phase.ZeroForward;
                    arduinoCommand = (int)ArduinoCommand.GoHome;
                }
            }
            else
            {
                CurrPhase = (iForward) ? Phase.ForwardWind : Phase.BackWind;
                arduinoCommand = (iForward) ? (int)ArduinoCommand.ForwardWind : (int)ArduinoCommand.BackWind;
            }
            serialHandler.SendDataToArduino(ArduinoXmitType.Command, arduinoCommand);
            //serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, Constants.FastWindLPcm);
        }

        /// <summary>
        /// Begin cutting immediately at the TrackLPcm of the currently selected track. The cutter will continue
        /// at this speed until the STOP button is clicked or the upper limit switch is triggered by the cutter.
        /// </summary>
        private void cmdTestCut_Click(object sender, EventArgs e)
        {
            CtrlEnables = 4; // STOP button only
            EnableFormControls();
            CurrPhase = Phase.TestCut;
            EndSegmentAtStepsTaken = 99999; // to prevent cutting being halted!
            serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, mySide.Tracks[mySide.CurrTrackIndex].TrackLPcm);
            serialHandler.SendDataToArduino(ArduinoXmitType.Command, (int)ArduinoCommand.Forward);

        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called when the imterval timer elapses. What happens depends on the current phase
        /// of record-cutting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrSegment_Tick(object sender, EventArgs e)
        {
            //// A record-cutting phase has ended. Decide what to do next.
            //switch (CurrPhase)
            //{
            //    case Phase.SetDown: // Set-down phase over; cut run-in spiral.
            //        CurrPhase = Phase.RunIn;
            //        CutSegment(mySide.RunInLPcm, mySide.RunInDurationMillisecs);
            //        break;
            //    case Phase.RunIn: // Run-in phase over; cut first music track.
            //        CurrPhase = Phase.MusicTrack;
            //        currTrackIndex = 0;
            //        mySide.SelectTrack(currTrackIndex);
            //        CutSegment((int)mySide.Tracks[currTrackIndex].TrackLPcm, mySide.Tracks[currTrackIndex].TrackDurationMillisecs);
            //        StartPlayingCurrentTrack();
            //        break;
            //    case Phase.MusicTrack: // end of music track handled by WMP MediaEnded event.
            //        break;
            //    case Phase.TrackGap: // Track gap phase over; cut next music track.
            //        CurrPhase = Phase.MusicTrack;
            //        currTrackIndex++;
            //        mySide.SelectTrack(currTrackIndex);
            //        CutSegment((int)mySide.Tracks[currTrackIndex].TrackLPcm, mySide.Tracks[currTrackIndex].TrackDurationMillisecs);
            //        StartPlayingCurrentTrack();
            //        break;
            //    case Phase.RunOut: // Run-out spiral completed; stop motor.
            //        EndRecord();
            //        break;
            //}


        }
        private void ChangePhase()
        {
            // A record-cutting phase has ended. Decide what to do next.
            switch (CurrPhase)
            {
                case Phase.SetDown: // Set-down phase over; cut run-in spiral.
                    CurrPhase = Phase.RunIn;
                    EndSegmentAtStepsTaken = RecdStepsTaken + mySide.RunInStepsRequired;
                    //CutSegment(mySide.RunInLPcm, mySide.RunInDurationMillisecs);
                    serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, mySide.RunInLPcm);
                    break;
                case Phase.RunIn: // Run-in phase over; cut tight-pitch "pre-programme" spiral.
                    CurrPhase = Phase.PreProg;
                    EndSegmentAtStepsTaken = RecdStepsTaken + mySide.PreProgStepsRequired;
                    //CutSegment(mySide.RunInLPcm, mySide.RunInDurationMillisecs);
                    serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, mySide.PreProgLPcm);
                    break;
                case Phase.PreProg: // Run-in phase over; cut first music track.
                    CurrPhase = Phase.MusicTrack;
                    currTrackIndex = 0;
                    mySide.SelectTrack(currTrackIndex);
                    EndSegmentAtStepsTaken = RecdStepsTaken + mySide.Tracks[currTrackIndex].TrackStepsRequired;
                    //CutSegment((int)mySide.Tracks[currTrackIndex].TrackLPcm, mySide.Tracks[currTrackIndex].TrackDurationMillisecs);
                    serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, (int)mySide.Tracks[currTrackIndex].TrackLPcm);
                    StartPlayingCurrentTrack();
                    break;
                case Phase.MusicTrack: // end of music track handled by WMP MediaEnded event.
                    break;
                case Phase.TrackGap: // Track gap phase over; cut next music track.
                    CurrPhase = Phase.MusicTrack;
                    currTrackIndex++;
                    mySide.SelectTrack(currTrackIndex);
                    EndSegmentAtStepsTaken = RecdStepsTaken + mySide.Tracks[currTrackIndex].TrackStepsRequired;
                    //CutSegment((int)mySide.Tracks[currTrackIndex].TrackLPcm, mySide.Tracks[currTrackIndex].TrackDurationMillisecs);
                    serialHandler.SendDataToArduino(ArduinoXmitType.LPcmData, (int)mySide.Tracks[currTrackIndex].TrackLPcm);
                    StartPlayingCurrentTrack();
                    break;
                case Phase.RunOut: // Run-out spiral completed; stop motor.
                    StopLathe();
                    break;
            }
        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called when the form is being closed. Attempts to shut things down in 
        /// an orderly manner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If a SideDetailsControl already exists
            if (mySide != null)
            {
                // If there have been changes and we want to keep them, jump out
                if (mySide.Changed && !LoseChangesYN())
                {
                    // Cancel form closure
                    e.Cancel = true;
                    return;
                }
            }
            // ArduinoPort object may already have been disposed
            try
            {
                // Call Arduino to stop lathe to prevent disorderly shutdown
                StopLathe();
            }
            catch (Exception ex) { }
            // Close serial port
            serialHandler.CloseSerial();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Update the banner at the top of the screen
        /// </summary>
        private void UpdateTitle()
        {
            if (SideFileName == "") this.Text = Constants.AppTitle;
            else this.Text = String.Concat(Constants.AppTitle, " - ", SideFileName);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Menu methods
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Title = "Save Side details";
            sfd.CheckPathExists = true;
            sfd.DefaultExt = "side";
            sfd.Filter = "Side files (*.side)|*.side|All files (*.*)|*.*";
            sfd.FilterIndex = 0;
            sfd.RestoreDirectory = false;
            sfd.ShowDialog();
            if (sfd.FileName != "") 
            {
                Save(sfd.FileName);
            }
            SideFileName = sfd.FileName;
            UpdateTitle();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SideFileName == "")
            {
                SaveAs();
            }
            else
            {
                Save(SideFileName);
            }
        }
        private void Save(string iSideFileName)
        {
            var json = JsonConvert.SerializeObject(mySide.GetControlData());
            using (StreamWriter sw = new StreamWriter(iSideFileName))
            {
                sw.Write(json);
            }
            mySide.Changed = false;

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If a SideDetailsControl already exists
            if (mySide != null)
            {
                // If there have been changes and we want to keep them, jump out
                if (mySide.Changed && !LoseChangesYN())
                {
                    return;
                } 
                else
                {
                    // Destroy old UserControl
                    Controls.Remove(mySide);
                    mySide.Dispose();
                }
            }
            // Clear file name and banner
            SideFileName = "";
            UpdateTitle();
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            CtrlEnables = 255;
            EnableFormControls();
            // Create a new UserControl
            mySide = new SideDetailsControl(); // temp to get rest of code working ### TODO: remove!
            mySide.Location = new Point(10, 80);
            mySide.Size = new Size(this.Width - 40, this.Height - 80);
            mySide.UseDefaults();
            mySide.EnableRecalculation(true);
            SetUpSideDetailsEvents();
            Controls.Add(mySide);
            // Set default speed programatically
            dbnSpeed_Click(dbn45rpm, EventArgs.Empty);
            mySide.CurrTrackIndex = 0;
            // Populate track list with first track
            mySide.AddTrack();
            mySide.Changed = false;



        }
        private bool LoseChangesYN()
        {
            DialogResult dr = MessageBox.Show("Changes have been made since the current file was last saved. Do you wish to proceed and lose these changes?",
                "Unsaved changes will be lost", MessageBoxButtons.YesNo);
            return (dr == DialogResult.Yes) ? true : false;
        }

        private void SetUpSideDetailsEvents()
        {
            // Set up some Events that the UserControl will generate
            mySide.EvtAssignWMPFile += (iFileName) =>
            {
                if (System.IO.File.Exists(iFileName))
                {
                    axWMP1.URL = iFileName;
                    axWMP1.Ctlenabled = true;
                }
                else
                {
                    axWMP1.URL = "";
                    axWMP1.Ctlenabled = false;
                }
                axWMP1.Ctlcontrols.stop();
            };

            mySide.EvtUpdateUI_1 += (iStepsNeeded) =>
            {
                tslMotorStepsRequired.Text = String.Format("Steps required: {0}", iStepsNeeded);
            };
            mySide.EvtUpdateUI_2 += (iOK, iSelectedTrackIsNotFirstOne, iSelectedTrackIsNotLastOne) =>
            {
                cmdCutRecord.Enabled = iOK;
                cmdInsertTrack.Enabled = iOK;
                cmdAppendTrack.Enabled = iOK;
                cmdMoveDown.Enabled = iOK && iSelectedTrackIsNotLastOne;
                cmdMoveUp.Enabled = iOK && iSelectedTrackIsNotFirstOne;
                cmdRemoveTrack.Enabled = iSelectedTrackIsNotFirstOne || iSelectedTrackIsNotLastOne;
            };
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If a SideDetailsControl already exists
            if (mySide != null)
            {
                // If there have been changes and we want to keep them, jump out
                if (mySide.Changed && !LoseChangesYN())
                {
                    return;
                }
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Title = "Save Side details";
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "side";
            ofd.Filter = "Side files (*.side)|*.side|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = false;
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                if (mySide != null)
                {
                    // Destroy old UserControl
                    Controls.Remove(mySide);
                    mySide.Dispose();
                }
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    string json = sr.ReadToEnd();
                    SideDO mySideDO = JsonConvert.DeserializeObject<SideDO>(json);
                    CtrlEnables = 255;
                    EnableFormControls();
                    // Create a new UserControl
                    mySide = new SideDetailsControl(); // temp to get rest of code working ### TODO: remove!
                    mySide.Location = new Point(10, 80);
                    mySide.Size = new Size(this.Width - 40, this.Height - 80);
                    mySide.EnableRecalculation(false);
                    mySide.SetControlData(mySideDO);
                    mySide.EnableRecalculation(true);
                    SetUpSideDetailsEvents();
                    Controls.Add(mySide);
                    SelectSpeed(mySide.SpeedRPM);
                    mySide.SelectTrack(0);
                    mySide.Recalculate();
                    mySide.Changed = false;
                    mySide.DrawTracks();

                }
                SideFileName = ofd.FileName;
                UpdateTitle();
                saveAsToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flung together by David Nelson © 2021", "Vinyl Burn");
        }


    }
}
