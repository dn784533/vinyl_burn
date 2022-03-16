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
using System.Windows.Forms;
using TrackListItem;
using DataObjects;

namespace SideDetails
{
    public partial class SideDetailsControl: UserControl
    {
        public List<TrackControl> Tracks = new List<TrackControl>();
        // Data set by user via controls.
        public decimal SpeedRPM { get; set; }
        public decimal StartRadius { get; set; }
        public decimal LockRadius { get; set; }
        public int SetDownLPcm { get; set; }
        public decimal SetDownWidth { get; set; }
        public int RunInLPcm { get; set; }
        public decimal RunInWidth { get; set; }
        public int PreProgLPcm { get; set; }
        public decimal PreProgWidth { get; set; }
        public int RunOutLPcm { get; set; }
        // Data calculated from the above and displayed.
        public decimal RunOutWidth { get; set; }
        public int TotalDurationMillisecs { get; set; }
        public decimal TotalWidth { get; set; }
        public decimal LastTrackGroove { get; set; }
        public decimal SpaceRemaining { get; set; }
        public int TotalStepsReqd { get; set; }
        public int SetDownDurationMillisecs { get; set; }
        public int SetDownStepsRequired { get; set; }
        public int RunInDurationMillisecs { get; set; }
        public int RunInStepsRequired { get; set; }
        public int PreProgDurationMillisecs { get; set; }
        public int PreProgStepsRequired { get; set; }
        public int RunOutDurationMillisecs { get; set; }
        public int RunOutStepsRequired { get; set; }
        public int CurrTrackIndex { get; set; }
        public bool Changed { get; set; }

        public delegate void AssignWMPFile(string eFileName);
        public event AssignWMPFile EvtAssignWMPFile;
        public delegate void UpdateUI_1(long eTotalStepsReqd);
        public event UpdateUI_1 EvtUpdateUI_1;
        public delegate void UpdateUI_2(bool eOK, bool eSelectedTrackIsNotFirstOne, bool eSelectedTrackIsNotLastOne);
        public event UpdateUI_2 EvtUpdateUI_2;

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
        /// User control constructor
        /// </summary>
        public SideDetailsControl()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackColor = GenMethods.Constants.FormBackColour;
            pnlSideSettings.BackColor = BackColor;
            pnlSideSettings.Anchor = Anchor;
            pnlSideSizes.BackColor = BackColor;
            pnlSideSizes.Anchor = Anchor;
            pnlTracks.BackColor = BackColor;
            Anchor = Anchor | AnchorStyles.Bottom;
            pnlTracks.Anchor = Anchor;
            // As NUDs can't be transparent, alter the colour to match
            foreach (Control ct in pnlSideSizes.Controls)
                if (ct is NumericUpDown) ct.BackColor = BackColor;
            foreach (Control ct in pnlSideSettings.Controls)
                if (ct is NumericUpDown) ct.BackColor = BackColor;
            // Need to set AutoScroll false temporarily
            pnlTracks.AutoScroll = false;
            pnlTracks.HorizontalScroll.Enabled = false;
            pnlTracks.HorizontalScroll.Visible = false;
            pnlTracks.HorizontalScroll.Maximum = 0;
            pnlTracks.AutoScroll = true;
            SpeedRPM = Constants.DfltSpeedRPM;

        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called whenever a NUD control is altered by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recalculate_ValueChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Update calculated fields on the SideDetailsControl using data
        /// from the NUD controls.nudRunInLPcm
        /// </summary>
        public void UpdateLabelFields()
        {
            StartRadius = nudStartRadius.Value;
            LockRadius = nudLockRadius.Value;
            SetDownLPcm = (int)nudSetDownLPcm.Value;
            SetDownWidth = nudSetDownWidth.Value;
            SetDownDurationMillisecs = (int)(1000 * SetDownWidth * SetDownLPcm * 60 / SpeedRPM);
            SetDownStepsRequired = (int)Math.Ceiling(SetDownWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblSetDownSteps.Text = SetDownStepsRequired.ToString();
            RunInLPcm = (int)nudRunInLPcm.Value;
            RunInWidth = nudRunInWidth.Value;
            RunInDurationMillisecs = (int)(1000 * RunInWidth * RunInLPcm * 60 / SpeedRPM);
            RunInStepsRequired = (int)Math.Ceiling(RunInWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblRunInSteps.Text = RunInStepsRequired.ToString();
            PreProgLPcm = (int)nudPreProgLPcm.Value;
            PreProgWidth = nudPreProgWidth.Value;
            PreProgDurationMillisecs = (int)(1000 * PreProgWidth * PreProgLPcm * 60 / SpeedRPM);
            PreProgStepsRequired = (int)Math.Ceiling(PreProgWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblPreProgSteps.Text = PreProgStepsRequired.ToString(); 
            RunOutLPcm = (int)nudRunOutLPcm.Value;
            LastTrackGroove = LockRadius + GenMethods.Constants.MinRunOut;
            TotalDurationMillisecs += SetDownDurationMillisecs + RunInDurationMillisecs + PreProgDurationMillisecs; // Add on to totals for all tracks
            TotalWidth += SetDownWidth + RunInWidth + PreProgWidth;                                     //

            SpaceRemaining = StartRadius - LastTrackGroove - TotalWidth;
            RunOutWidth = Math.Max(0, StartRadius - LockRadius - TotalWidth);
            RunOutDurationMillisecs = (int)(1000 * RunOutWidth * RunOutLPcm * 60 / SpeedRPM);
            RunOutStepsRequired = (int)Math.Ceiling(RunOutWidth * GenMethods.Constants.StepsPerRev / GenMethods.Constants.CmPerRev);
            lblRunOutSteps.Text = RunOutStepsRequired.ToString();

            lblLastTrackRadius.Text = "Last track groove (cm):  " + LastTrackGroove.ToString();
            lblSetDownDuration.Text = GenMethods.General.FormatMMSS(SetDownDurationMillisecs);
            lblRunInDuration.Text = GenMethods.General.FormatMMSS(RunInDurationMillisecs);
            lblPreProgDuration.Text = GenMethods.General.FormatMMSS(PreProgDurationMillisecs);
            lblTotalDuration.Text = GenMethods.General.FormatMMSS(TotalDurationMillisecs);
            lblRunOutDuration.Text = GenMethods.General.FormatMMSS(RunOutDurationMillisecs);
            lblRunOutWidth.Text = String.Format("{0:0.00}", RunOutWidth);
            lblSpaceRemaining.Text = String.Format("{0:0.00}", SpaceRemaining);
            lblSpaceRemaining.ForeColor = (SpaceRemaining >= 0) ? GenMethods.Constants.FormForeColour : GenMethods.Constants.FormErrorColour;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Called if a new SideDetailsControl is being created from scratch
        /// (i.e. not being loaded from file)
        /// </summary>
        public void UseDefaults()
        {
            nudStartRadius.Value = Constants.DfltStartRadius;
            nudLockRadius.Value = Constants.DfltLockRadius;
            nudSetDownLPcm.Value = Constants.DfltSetDownLPcm;
            nudSetDownWidth.Value = Constants.DfltSetDownWidth;
            nudRunInLPcm.Value = Constants.DfltRunInLPcm;
            nudRunInWidth.Value = Constants.DfltRunInWidth;
            nudPreProgLPcm.Value = Constants.DfltPreProgLPcm;
            nudPreProgWidth.Value = Constants.DfltPreProgWidth;
            nudRunOutLPcm.Value = Constants.DfltRunOutLPcm;
        }


        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Add new TrackControl to list, at the currently set index point (CurrTrackIndex)
        /// </summary>
        /// <param name="iIndex">Point in list at which to add</param>
        public void AddTrack()
        {
            // Can't add a track if there is something wrong with an existing one
            // (Add button will be disabled if this is the case, but checking logic
            // included here nevertheless)
            if (AreAllTracksAssignedToValidFiles())
            {
                // Make new track, redraw list and select the new one.
                TrackControl tc = new TrackControl(BackColor);
                tc.UseDefaults();
                tc.EnableRecalculation(true);
                tc.EvtSelectTrack += SelectTrack;
                tc.EvtRecalculate += Recalculate;
                Tracks.Insert(CurrTrackIndex, tc);
                Recalculate();
                DrawTracks();
                SelectTrack(CurrTrackIndex);
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Add a new TrackControl to the end of the existing list of TrackControls.
        /// </summary>
        public void AppendTrack()
        {
            if (AreAllTracksAssignedToValidFiles())
            {
                // Update index to be one more than the current highest entry in the list
                // (e.g. 5 existing tracks will be indexed 0-4, new track (the sixth) will
                // have index 5, that is, Tracks.Count before the new track is added).
                CurrTrackIndex = Tracks.Count;
                AddTrack();
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Remove the TrackControl at the current index point from the list of TrackControls.
        /// </summary>
        public void RemoveTrack()
        {
            // Only allow deletion if there is more than one track.
            // (Remove button will be disabled if this is not the case, but checking logic
            // included here nevertheless)
            if (Tracks.Count > 1)
            {
                // Is the user sure?
                if (DialogResult.OK == MessageBox.Show(String.Concat("Delete track ", CurrTrackIndex + 1, "?"), "WARNING", MessageBoxButtons.OKCancel))
                {
                    Tracks.Remove(Tracks[CurrTrackIndex]);
                    Recalculate();
                    DrawTracks();
                    // If we've removed the last item, reduce the index by 1
                    if (CurrTrackIndex == Tracks.Count) CurrTrackIndex--;
                    SelectTrack(CurrTrackIndex);
                }
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Present the track listing in graphical form on pnlTracks. References to
        /// all the TrackControls in the list are added to pnlTracks, with some extra
        /// information added for positioning and size
        /// </summary>
        public void DrawTracks()
        {
            // Start with a clean slate
            pnlTracks.Controls.Clear();
            for (int i = 0; i < Tracks.Count; i++)
            {
                int posY = i * (GenMethods.Constants.TrackGraphicHeight + GenMethods.Constants.TrackGraphicGap);
                Tracks[i].TrackNumber = i;
                // Make the screen display of TrackControls 1-based for user-friendliness, rather than 0-based as in list
                Tracks[i].Controls["lblTrackNumber"].Text = String.Format("{0:0}", i + 1);
                Tracks[i].Location = new System.Drawing.Point(0, posY);
                Tracks[i].Width = pnlTracks.Width;
                Tracks[i].EnableTrackGapControls((i == Tracks.Count - 1) ? false : true);

                // On the panel, add a reference to each TrackControl in the List<> within this SideDetailsControl.
                pnlTracks.Controls.Add(Tracks[i]);
            }

        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Move a track up or down depending on the condition
        /// </summary>
        /// <param name="iDirection"></param>
        /// <param name="iCond"></param>
        public void MoveTrack(int iDirection, Predicate<int> iCond)
        {
            if (iCond(CurrTrackIndex))
            {
                TrackControl tc = Tracks[CurrTrackIndex];
                Tracks.RemoveAt(CurrTrackIndex);
                CurrTrackIndex += iDirection;
                Tracks.Insert(CurrTrackIndex, tc);
                // No need to Recalculate as we're not changing any settings
                DrawTracks();
                SelectTrack(CurrTrackIndex);
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Show dialogue to get the sound file to be used for a TrackControl
        /// </summary>
        public void UseSoundFile()
        {
            OpenFileDialog useFileDialog = new OpenFileDialog();
            useFileDialog.Filter = "WAV files|*.wav";
            useFileDialog.Title = "Use a sound file";
            useFileDialog.FileName = Tracks[CurrTrackIndex].Controls["lblFileName"].Text;
            if (useFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Verify that file supplied is valid (duration is greater than 0).
                if (Tracks[CurrTrackIndex].SetSoundFile(useFileDialog.FileName))
                {
                    SelectTrack(CurrTrackIndex);
                    Recalculate();
                }
            }
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Select a given track, altering colours appropriately.
        /// </summary>
        /// <param name="iTrackNumber">Integer index of selected track.</param>
        public void SelectTrack(int iTrackNumber)
        {
            if (Tracks[iTrackNumber].Selected)
            {
                // Even if the track is already selected, call this method
                // to refresh display colours (in case an error has occurred or been
                // corrected)
                Tracks[iTrackNumber].ShowAsSelected(true);
            }
            else
            {
                // Deselecting all tracks will, naturally, deselect any pre-selected one!           
                DeselectTracks();
                CurrTrackIndex = iTrackNumber;
                Tracks[iTrackNumber].ShowAsSelected(true);
            }
            // We might want to play a track once it's been selected.
            // Try to prepare the WMP with the current file, if one has been selected
            try
            {
                EvtAssignWMPFile(Tracks[iTrackNumber].FileName);
            }
            catch (Exception ex)
            {
                // TODO: fill this bit out
                throw;
            }
            EvtUpdateUI_2(AreAllTracksAssignedToValidFiles(), iTrackNumber > 0, iTrackNumber < Tracks.Count - 1);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Make all TrackControls un-selected, altering colours appropriately.
        /// </summary>
        public void DeselectTracks()
        {
            foreach (TrackControl tc in Tracks)
            {
                tc.ShowAsSelected(false);
            }
        }


        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Determine whether all Tracks have a valid file assigned.
        /// Just returns true or false, no other side-effects
        /// </summary>
        /// <returns></returns>
        public bool AreAllTracksAssignedToValidFiles()
        {
            foreach (TrackControl tc in Tracks)
                if (!tc.VerifySoundFile()) return false;
            return true;
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Main method for updating all the calculated screen fields from
        /// those input or adjusted by the user.
        /// </summary>
        public void Recalculate()
        {
            // Initialise totals in SideDetails control
            TotalDurationMillisecs = 0;
            TotalWidth = 0;

            // Calculate entries for each track
            for (int i = 0; i < Tracks.Count; i++)
            {
                // The SpeedRPM is held only at SideDetails level, so to establish the
                // measurements for each track, we have to pass the speed as a parameter
                Tracks[i].UpdateLabelFields(SpeedRPM);

                // Only include track gap if not at last track
                if (i == Tracks.Count - 1)
                {
                    TotalDurationMillisecs += Tracks[i].TrackDurationMillisecs;
                    TotalWidth += (Tracks[i].TrackWidth);
                }
                else
                {
                    TotalDurationMillisecs += (Tracks[i].TrackDurationMillisecs + Tracks[i].GapDurationMillisecs);
                    TotalWidth += (Tracks[i].TrackWidth + Tracks[i].GapWidth);
                }

            }
            // Now update the fields at this level (i.e. for SideDetails)
            UpdateLabelFields();

            // Do some calculations for the UI on the top-level form
            TotalStepsReqd = (int)(GenMethods.Constants.StepsPerRev * (StartRadius - LockRadius) / GenMethods.Constants.CmPerRev);
            // Set a flag to show that something has been changed. This is used to generate a MessageBox if an attempt is
            // made to load a new file or create a new SideDetailsControl without saving the current one.
            Changed = true;
            // Call event to update top-level form
            EvtUpdateUI_1(TotalStepsReqd);
        }

        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Put together an object comprising only the data from the SideDetailsControl and its nested TrackControls
        /// that can be entered by the user (i.e. no calculated fields as these will be recalculated when the
        /// object is reloaded from storage). This object can then be serialised for writing to file.
        /// </summary>
        /// <returns></returns>
        public SideDO GetControlData()
        {
            SideDO mySideDO = new SideDO();
            mySideDO.StartRadius = nudStartRadius.Value;
            mySideDO.LockRadius = nudLockRadius.Value;
            mySideDO.SetDownLPcm = (int)nudSetDownLPcm.Value;
            mySideDO.SetDownWidth = nudSetDownWidth.Value;
            mySideDO.RunInLPcm = (int)nudRunInLPcm.Value;
            mySideDO.RunInWidth = nudRunInWidth.Value;
            mySideDO.PreProgLPcm = (int)nudPreProgLPcm.Value;
            mySideDO.PreProgWidth = nudPreProgWidth.Value;
            mySideDO.RunOutLPcm = (int)nudRunOutLPcm.Value;
            mySideDO.SpeedRPM = SpeedRPM;
            for (int i = 0; i < Tracks.Count; i++)
            {
                mySideDO.Tracks.Add(Tracks[i].GetControlData());
            }
            return mySideDO;
        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Copy values from data object to controls on the SideDetailsControl and its nested TrackControl user controls.
        /// The data object is created by deserialising input from a stored file.
        /// </summary>
        /// <param name="iSideDO"></param>
        public void SetControlData(SideDO iSideDO)
        {
            nudStartRadius.Value = iSideDO.StartRadius;
            nudLockRadius.Value = iSideDO.LockRadius;
            nudSetDownLPcm.Value = (decimal)iSideDO.SetDownLPcm;
            nudSetDownWidth.Value = iSideDO.SetDownWidth;
            nudRunInLPcm.Value = (decimal)iSideDO.RunInLPcm;
            nudRunInWidth.Value = iSideDO.RunInWidth;
            nudPreProgLPcm.Value = (decimal)iSideDO.PreProgLPcm;
            nudPreProgWidth.Value = iSideDO.PreProgWidth;
            nudRunOutLPcm.Value = (decimal)iSideDO.RunOutLPcm;
            SpeedRPM = iSideDO.SpeedRPM;
            for (int i=0; i < iSideDO.Tracks.Count; i++)
            {
                TrackControl myTrack = new TrackControl();
                myTrack.SetControlData(iSideDO.Tracks[i]);
                myTrack.EnableRecalculation(true);
                myTrack.EvtSelectTrack += SelectTrack;
                myTrack.EvtRecalculate += Recalculate;
                Tracks.Add(myTrack);
            }

        }
        /// <summary>
        /// ------------------------------------------------------------------------------------------------------------
        /// Toggle attachment of events to controls. If we are loading 
        /// a SideDetailsControl from a file, we don't want to recalculate after
        /// the assignment of a value to each single control, so the
        /// events would be temporarily detached using this method.
        /// </summary>
        /// <param name="iEnable"></param>
        public void EnableRecalculation(bool iEnable)
        {
            if (iEnable)
            {
                nudStartRadius.ValueChanged += Recalculate_ValueChanged;
                nudLockRadius.ValueChanged += Recalculate_ValueChanged;
                nudSetDownLPcm.ValueChanged += Recalculate_ValueChanged;
                nudSetDownWidth.ValueChanged += Recalculate_ValueChanged;
                nudRunInLPcm.ValueChanged += Recalculate_ValueChanged;
                nudRunInWidth.ValueChanged += Recalculate_ValueChanged;
                nudPreProgLPcm.ValueChanged += Recalculate_ValueChanged;
                nudPreProgWidth.ValueChanged += Recalculate_ValueChanged;
                nudRunOutLPcm.ValueChanged += Recalculate_ValueChanged;
            }
            else
            {
                nudStartRadius.ValueChanged -= Recalculate_ValueChanged;
                nudLockRadius.ValueChanged -= Recalculate_ValueChanged;
                nudSetDownLPcm.ValueChanged -= Recalculate_ValueChanged;
                nudSetDownWidth.ValueChanged -= Recalculate_ValueChanged;
                nudRunInLPcm.ValueChanged -= Recalculate_ValueChanged;
                nudRunInWidth.ValueChanged -= Recalculate_ValueChanged;
                nudPreProgLPcm.ValueChanged -= Recalculate_ValueChanged;
                nudPreProgWidth.ValueChanged -= Recalculate_ValueChanged; 
                nudRunOutLPcm.ValueChanged -= Recalculate_ValueChanged;
            }
            // Propagate the toggle setting to the list of TrackControls.
            for (int i = 0; i < Tracks.Count; i++)
            {
                Tracks[i].EnableRecalculation(iEnable);
            }
        }

        private void SideDetailsControl_Resize(object sender, EventArgs e)
        {

            // Resize the track controls (accessed through the Tracks heap object).
            for (int i = 0; i < Tracks.Count; i++)
            {
                Tracks[i].Width = pnlTracks.Width;
            }
        }

 
    }
}
