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

using System.Windows.Forms;

namespace VinylBurnUI
{
    public partial class SplashForm : Form
    {
        public string Author { get; set; }

        // Delegate for updates to progress bar
        private delegate void ProgressDelegate(int iPercent);
        private ProgressDelegate DlgtUpdateProgress;

        public SplashForm()
        {
            InitializeComponent();
            lblAuthor.Text = Properties.Settings.Default.Author;
            DlgtUpdateProgress = this.UpdateProgressInternal;
        }

        private void UpdateProgressInternal(int iPercent)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.prgInit.Value = iPercent;
        }
        public void UpdateProgress(int iPercent)
        {
            this.Invoke(DlgtUpdateProgress, iPercent);
        }



    }
}
