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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DataObjects;


namespace TrackListItem
{
    public partial class TrackControl : UserControl
    {
        // Data set by user via controls.
        public int TrackNumber { get; set; }
        public int TrackLPcm { get; set; }
        public int GapLPcm { get; set; }
        public decimal GapWidth { get; set; }
        public string FileName { get; set; }
        // Data calculated from the above and displayed.
        public int TrackDurationMillisecs { get; set; }
        public int TrackStepsRequired { get; set; }
        public int GapDurationMillisecs { get; set; }
        public int GapStepsRequired { get; set; }
        public decimal TrackWidth { get; set; }
        public bool Selected { get; set; }
        public bool FileVerified { get; set; }
 
        public delegate void SelectTrack(int iTrackNumber);
        public delegate void Recalculate();
        public event SelectTrack EvtSelectTrack;
        public event Recalculate EvtRecalculate;

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Implement the GetEnumerator method for this User Control class.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Control> GetEnumerator()
        {
            foreach (Control ct in Controls)
                yield return ct;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// User control constructors
        /// </summary>
        /// <param name="iBackgroundColour">For colouring NUDs</param>
        public TrackControl() : this(GenMethods.Constants.FormBackColour)
        {
            
        }
        public TrackControl(Color iBackgroundColour)
        {
            InitializeComponent();
            BackColor = iBackgroundColour;

            foreach (Control ct in Controls)
                if (ct is NumericUpDown)
                {
                    // Set background colour of NUDs - can't be transparent
                    ct.BackColor = BackColor;
                    // Force selection of track if NUD gains focus
                    //ct.GotFocus += new EventHandler(SelectTrack_Click); // removed becauses it causes endless trouble
                    ct.Click += new EventHandler(SelectTrack_Click);
                }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// If a TrackControl is clicked, this fires an event to
        /// alert the form in which this User Control has been placed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTrack_Click(object sender, EventArgs e)
        {
            EvtSelectTrack(TrackNumber);
        }

        private void Recalculate_ValueChanged(object sender, EventArgs e)
        {
            EvtRecalculate();
        }

        /// ------------------------------------------------------------------------------------------------------------
        /// Determine whether the Track has a valid music file assigned to it
        /// </summary>
        /// <param name="iTrackIndex"></param>
        /// <returns></returns>
        public bool VerifySoundFile()
        {
            return (WAVLength.GetSoundLength(FileName) > 0);
        }

        /// ------------------------------------------------------------------------------------------------------------
        /// Assigns a file to the Track, and sets a flag to show whether the file is a valid one or not.
        /// </summary>
        /// <param name="iTrackIndex"></param>
        /// <returns></returns>
        public bool SetSoundFile(string iFileName)
        {
            Controls["lblFileName"].Text = iFileName;
            FileName = iFileName; 
            int lenMs = WAVLength.GetSoundLength(iFileName);
            if (lenMs == 0) // Oh dear.
            {
                TrackDurationMillisecs = 0;
                FileVerified = false;
            }
            else
            {
                // All well.
                TrackDurationMillisecs = lenMs;
                FileVerified = true;
            }
            Controls["lblTrackDuration"].Text = GenMethods.General.FormatMMSS(TrackDurationMillisecs); // format for display
            return FileVerified;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Update calculated fields on the TrackControl using data
        /// from the NUD controls. The SpeedRPM is not held at Track level and must
        /// be submitted as a parameter.
        /// </summary>
        public void UpdateLabelFields(decimal iSpeedRPM)
        {
            TrackLPcm = (int)nudTrackLPcm.Value;
            GapLPcm = (int)nudGapLPcm.Value;
            GapWidth = nudGapWidth.Value;
            GapStepsRequired = (int)Math.Ceiling(GapWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblGapSteps.Text = GapStepsRequired.ToString();
            lblTrackDuration.Text = GenMethods.General.FormatMMSS(TrackDurationMillisecs);
            TrackWidth = TrackDurationMillisecs * iSpeedRPM / (1000 * 60 * TrackLPcm);
            TrackStepsRequired = (int)Math.Ceiling(TrackWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblTrackSteps.Text = TrackStepsRequired.ToString();
            lblTrackWidth.Text = String.Format("{0:0.00}", TrackWidth);
            decimal lTrackGapDur = 1000 * GapWidth * GapLPcm * 60 / iSpeedRPM;
            lblGapDuration.Text = GenMethods.General.FormatMMSS(lTrackGapDur);
            GapDurationMillisecs = (int)lTrackGapDur;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called if a new TrackControl is being created from scratch
        /// (i.e. not being loaded from file)
        /// </summary>
        public void UseDefaults()
        {

            nudGapLPcm.Value = Constants.DfltGapLPcm;
            nudGapWidth.Value = Constants.DfltGapWidth;
            nudTrackLPcm.Value = Constants.DfltTrackLPcm;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// The last track is not followed by a track gap. This procedure enables the
        /// controls for the last track gap to be made invisible.
        /// </summary>
        /// <param name="vVisible"></param>
        public void EnableTrackGapControls(bool iVisible)
        {
            nudGapWidth.Visible = iVisible;
            nudGapLPcm.Visible = iVisible;
            lblGapDuration.Visible = iVisible;
            lblGap.Visible = iVisible;
            lblGapSteps.Visible = iVisible;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Set flag to show this Track has been selected
        /// and prepare font colours accordingly.
        /// </summary>
        /// <param name="iSelected"></param>
        public void ShowAsSelected(bool iSelected)
        {
            Color foreColour;
            if (iSelected)
            {
                Selected = true;
                foreColour = GenMethods.Constants.CurrTrackForeColour;
            } else
            {
                Selected = false;
                foreColour = GenMethods.Constants.TrackForeColour;
            }
            ColourControls(foreColour);

        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Set colours depending on selection status. If a sound file has an error, its filename will
        /// be displayed in the form error colour.
        /// </summary>
        /// <param name="iColour"></param>
        public void ColourControls(Color iColour)
        {
            if (FileVerified)
            {
                lblFileName.ForeColor = iColour;
            }
            else
            {
                lblFileName.ForeColor = GenMethods.Constants.FormErrorColour;
            }
            lblGap.ForeColor = iColour;
            lblTrack.ForeColor = iColour;
            lblTrackNumber.ForeColor = iColour;
            lblTrackNumber.BackColor = GenMethods.Constants.TrackNumberBackColour;
            lblTrackWidth.ForeColor = iColour;
            lblTrackDuration.ForeColor = iColour;
            lblTrackSteps.ForeColor = iColour;
            lblGapDuration.ForeColor = iColour;
            lblGapSteps.ForeColor = iColour;
            nudTrackLPcm.ForeColor = iColour;
            nudGapWidth.ForeColor = iColour;
            nudGapLPcm.ForeColor = iColour;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Put together an object comprising only the data from the TrackControl
        /// that can be entered by the user (i.e. no calculated fields as these will be recalculated when the
        /// object is reloaded from storage). This object can then be serialised for writing to file.
        /// </summary>
        /// <returns></returns>
        public TrackDO GetControlData()
        {
            TrackDO myTrackDO = new TrackDO();
            myTrackDO.TrackNumber = TrackNumber;
            myTrackDO.TrackLPcm = TrackLPcm;
            myTrackDO.GapLPcm = GapLPcm;
            myTrackDO.GapWidth = GapWidth;
            myTrackDO.FileName = FileName;           
            return myTrackDO;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Copy values from data object to controls on the TrackControl user control.
        /// The data object is created by deserialising input from a stored file.
        /// </summary>
        /// <param name="iTrackDO"></param>
        public void SetControlData(TrackDO iTrackDO)
        {
            TrackNumber = iTrackDO.TrackNumber;
            nudTrackLPcm.Value = (decimal)iTrackDO.TrackLPcm;
            nudGapLPcm.Value = (decimal)iTrackDO.GapLPcm;
            nudGapWidth.Value = iTrackDO.GapWidth;
            SetSoundFile(iTrackDO.FileName);
            //FileName = iTrackDO.FileName;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Toggle attachment of events to controls. If we are loading 
        /// TrackControls from a file, we don't want to recalculate after
        /// the assignment of a value to each single control, so the
        /// events would be temporarily detached using this method.
        /// </summary>
        /// <param name="iEnable"></param>
        public void EnableRecalculation(bool iEnable)
        {
            if (iEnable)
            {
                nudTrackLPcm.ValueChanged += Recalculate_ValueChanged;
                nudGapLPcm.ValueChanged += Recalculate_ValueChanged;
                nudGapWidth.ValueChanged += Recalculate_ValueChanged;
            }
            else
            {
                nudTrackLPcm.ValueChanged -= Recalculate_ValueChanged;
                nudGapLPcm.ValueChanged -= Recalculate_ValueChanged;
                nudGapWidth.ValueChanged -= Recalculate_ValueChanged;
            }
        }
    }
}

