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

namespace DataObjects
{
    public class SideDO
    {
        public List<TrackDO> Tracks = new List<TrackDO>();
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
  
        
    }
}
