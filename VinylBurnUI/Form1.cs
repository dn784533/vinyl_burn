using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackListItem;

namespace TrackHarness
{

    public partial class Form1 : Form
    {


        // Create a list for the tracks to be used.
        private List<TrackControl> tracks = new List<TrackControl>();
        private int currTrackIndex;
        public Form1()
        {
            InitializeComponent();
            BackColor = Constants.FormBackColour;
            // As NUDs can't be transparent, alter the colour to match
            foreach (Control ct in pnlRecordSettings.Controls)
                if (ct is NumericUpDown) ct.BackColor = Constants.FormBackColour;
            foreach (Control ct in pnlRecordSizes.Controls)
                if (ct is NumericUpDown) ct.BackColor = Constants.FormBackColour;            // Ensure that the track list panel can only scroll vertically

            // Tooltips for control buttons
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(cmd16rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmd22rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmd33rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmd45rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmd39rpm, "Turntable speed on which to base calculations");
            toolTip.SetToolTip(cmdCutRecord, "Start cutting record");
            toolTip.SetToolTip(cmdReturnLathe, "Wind lathe to zero point");
            toolTip.SetToolTip(cmdLatheBack, "Wind lathe back");
            toolTip.SetToolTip(cmdStop, "Stop winding lathe");
            toolTip.SetToolTip(cmdLatheForth, "Wind lathe forward");
            toolTip.SetToolTip(cmdZero, "Reset lathe step counter to zero");
            toolTip.SetToolTip(cmdInsertTrack, "Insert a track before this one");
            toolTip.SetToolTip(cmdAppendTrack, "Add a track to end of list");
            toolTip.SetToolTip(cmdRemoveTrack, "Remove this track");
            toolTip.SetToolTip(cmdMoveUp, "Move track up one");
            toolTip.SetToolTip(cmdMoveDown, "Move track down one");
            toolTip.SetToolTip(cmdUseFile, "Select music file");

            // Need to set AutoScroll false temporarily
            pnlTracks.AutoScroll = false;
            pnlTracks.HorizontalScroll.Enabled = false;
            pnlTracks.HorizontalScroll.Visible = false;
            pnlTracks.HorizontalScroll.Maximum = 0;
            pnlTracks.AutoScroll = true;

            // Assign images to speed buttons programatically
            DeselectSpeeds();

            // Populate track list with first track
            AddTrack(0);

        }


        /// <summary>
        /// Add new track to list
        /// </summary>
        /// <param name="iIndex">Point in list at which to add</param>
        public void AddTrack(int iIndex)
        {
            // Make sure all existing tracks have a valid file assigned
            bool allAssigned = true;
            foreach (TrackControl tc in tracks)
                if (!tc.AssignedToValidFile) allAssigned = false;
            if (allAssigned)
            {
                // Make new track, redraw list and select the new one.
                TrackControl tc = new TrackControl(BackColor);
                tc.EvtSelectTrack += SelectTrack;
                tc.EvtRecalculate += Recalculate;
                tracks.Insert(iIndex, tc);
                currTrackIndex = iIndex;
                DrawTracks();
                SelectTrack(currTrackIndex);
            }
        }

        /// <summary>
        /// Present the track listing in graphical form on the tracks panel
        /// </summary>
        public void DrawTracks()
        {
            pnlTracks.Controls.Clear();
            for (int i = 0; i < tracks.Count; i++)
            {
                int posY = i * (Constants.TrackGraphicHeight + Constants.TrackGraphicGap);
                tracks[i].TrackNumber = i;
                // Make tracks on screen 1-based, rather than 0-based as in list
                tracks[i].Controls["lblTrackNumber"].Text = String.Format("{0:0}", i + 1);
                tracks[i].Location = new System.Drawing.Point(0, posY);
                pnlTracks.Controls.Add(tracks[i]);
            }

        }

        /// <summary>
        /// Selects a given track, altering colours appropriately.
        /// </summary>
        /// <param name="iTrackNumber">Integer index of selected track.</param>
        public void SelectTrack(int iTrackNumber)
        {
            // Deselecting all tracks will, naturally, deselect any pre-selected one!           
            DeselectTracks();
            currTrackIndex = iTrackNumber;
            tracks[iTrackNumber].BackColor = Constants.CurrTrackBackColour;
            tracks[iTrackNumber].ForeColor = Constants.CurrTrackForeColour;
            // Update colours in label controls within track
            foreach (Control ct in tracks[iTrackNumber].Controls)
            {
                if (ct is Label) ct.ForeColor = Constants.CurrTrackForeColour;
                else if (ct is NumericUpDown)
                {
                    // NUDs can't have a transparent colour: so the
                    // background colour of the parent control must be used.
                    ct.ForeColor = Constants.CurrTrackForeColour;
                    ct.BackColor = Constants.CurrTrackBackColour;
                }
            }

            // Try to prepare the WMP with the current file, if one has been selected
            try
            {
                if (System.IO.File.Exists(tracks[iTrackNumber].Controls["lblFileName"].Text))
                {
                    axWMP1.URL = tracks[iTrackNumber].Controls["lblFileName"].Text;
                    axWMP1.Ctlcontrols.stop();
                }
            }
            catch (Exception ex)
            {
                // TODO: fill this bit out
                throw;
            }
        }

        /// <summary>
        /// Makes all tracks in list un-selected, altering colours appropriately.
        /// </summary>
        public void DeselectTracks()
        {
            foreach (TrackControl tc in tracks)
            {
                tc.BackColor = Constants.TrackBackColour;
                tc.ForeColor = Constants.TrackForeColour;
                // Update colours in label controls within track
                foreach (Control ct in tc.Controls)
                {
                    if (ct is Label) ct.ForeColor = Constants.TrackForeColour;
                    else if (ct is NumericUpDown)
                    {
                        // NUDs can't have a transparent colour: so the
                        // background colour of the form must be used.
                        ct.ForeColor = Constants.TrackForeColour;
                        ct.BackColor = Constants.FormBackColour;
                    }
                }
            }
        }

        /// <summary>
        /// Turn all speed buttons back to their 'off' appearance
        /// </summary>
        public void DeselectSpeeds()
        {
            // Use RM to access the string name of the image resources
            ResourceManager rm = Properties.Resources.ResourceManager;
            foreach (Button bt in pnlSpeed.Controls)
                bt.Image = (Bitmap)rm.GetObject(string.Concat(bt.Name, "_off"));
        }

        /// <summary>
        /// All speed buttons call this method to assign the 'on' image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSpeed_Click(object sender, EventArgs e)
        {
            DeselectSpeeds();
            // Use RM to access the string name of the image resources
            ResourceManager rm = Properties.Resources.ResourceManager;
            Button bt = (Button)sender;
            bt.Image = (Bitmap)rm.GetObject(string.Concat(bt.Name, "_on"));
        }

        /// <summary>
        /// Uses OpenFileDialog to select a WAV file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog useFileDialog = new OpenFileDialog();
            useFileDialog.Filter = "WAV files|*.wav";
            useFileDialog.Title = "Use a sound file";
            useFileDialog.FileName = tracks[currTrackIndex].Controls["lblFileName"].Text;
            if (useFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Verify that file supplied is valid (duration is greater than 0).
                int lenMs = WAVLength.GetSoundLength(useFileDialog.FileName);
                if (lenMs == 0) // Oh dear.
                {
                    tracks[currTrackIndex].Controls["lblFileName"].Text = "-";
                    tracks[currTrackIndex].TrackDurationMillisecs = 0;
                    tracks[currTrackIndex].Controls["lblTrackDuration"].Text = General.FormatMMSS(0); // format for display
                    tracks[currTrackIndex].AssignedToValidFile = false;
                    // updateStatusBar("tslMessage", "One or more music files could not be opened", Color.Red);
                }
                else
                {
                    tracks[currTrackIndex].Controls["lblFileName"].Text = useFileDialog.FileName;
                    tracks[currTrackIndex].TrackDurationMillisecs = lenMs;
                    tracks[currTrackIndex].Controls["lblTrackDuration"].Text = General.FormatMMSS(tracks[currTrackIndex].TrackDurationMillisecs / 1000); // format for display
                    tracks[currTrackIndex].AssignedToValidFile = true;
                   SelectTrack(currTrackIndex);
                }
            }

        }

        /// <summary>
        /// Create new track at end of list       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAppendTrack_Click(object sender, EventArgs e)
        {
            AddTrack(tracks.Count);
        }
        /// <summary>
        /// Create new track at current position in list       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInsertTrack_Click(object sender, EventArgs e)
        {
            AddTrack(currTrackIndex);
        }

        /// <summary>
        /// Move selected track down one place in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            MoveTrack(1, ltTrackCountMinus1);
        }

        /// <summary>
        ///  Move selected track up one place in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            MoveTrack(-1, gt0);
        }

        /// <summary>
        /// Helper functions for parameterised condition in MoveTrack method
        /// </summary>
        /// <param name="iArg"></param>
        /// <returns></returns>
        bool gt0(int iArg) { return iArg > 0; }
        bool ltTrackCountMinus1(int iArg) { return iArg < tracks.Count - 1; }

        /// <summary>
        /// Move a track up or down depending on the condition
        /// </summary>
        /// <param name="iDirection"></param>
        /// <param name="iCond"></param>
        private void MoveTrack(int iDirection, Predicate<int> iCond)
        {
            if (iCond(currTrackIndex))
            {
                TrackControl tc = tracks[currTrackIndex];
                tracks.RemoveAt(currTrackIndex);
                currTrackIndex += iDirection;
                tracks.Insert(currTrackIndex, tc);
                DrawTracks();
                //recalculate();
                SelectTrack(currTrackIndex);

            }
        }

        private void Recalculate()
        {
            MessageBox.Show("Recalculating");
        }

    }
}
