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

namespace DataObjects
{
    public class TrackDO
    {
        // Data set by user via controls.
        public int TrackNumber { get; set; }
        public int TrackLPcm { get; set; }
        public int GapLPcm { get; set; }
        public decimal GapWidth { get; set; }
        public string FileName { get; set; }
    }
}
