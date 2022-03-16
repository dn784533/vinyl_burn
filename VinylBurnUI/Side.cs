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

using System.Collections.Generic;
using System.Drawing;

using TrackListItem;
using SideDetails;

namespace VinylBurnUI
{
    /// <summary>
    /// Holds all details about one side of a record.
    /// </summary>
    public class Side
    {
        public List<TrackControl> Tracks = new List<TrackControl>();
        public SideDetailsControl Details = new SideDetailsControl();
        public int CurrTrackIndex;
        public Side(Color iBackgroundColour)
        {
            // Colour of calling form. Needed to propagate to TrackControl and SideDetailsControl.
            BackgroundColour = iBackgroundColour;
        }
        public decimal SpeedRPM { get; set; }
        public Color BackgroundColour;
       
    }


}
