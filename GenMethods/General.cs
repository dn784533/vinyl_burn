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

namespace GenMethods
{
    public static class General
    {
        /// <summary>
        /// Format timings from milliseconds to minutes and seconds
        /// </summary>
        /// <param name="iMillisecs"></param>
        /// <returns></returns>
        public static string FormatMMSS(decimal iMillisecs)
        {
            // Custom format for timings, e.g. 130.5 seconds will show as 2'10".
            return String.Format("{0:0}'{1:00}\"", Math.Floor(iMillisecs / 60000), Math.Floor((iMillisecs / 1000) % 60));
        }
    }
    /// <summary>
    /// Constants 
    /// (May be better stored as resources (XML)?)
    /// </summary>
    public static class Constants
    {
        public const int TrackGraphicGap = 8;     // on-screen vertical space between sets of track details
        public const int TrackGraphicWidth = 600; // on-screen width of a set of track details
        public const int TrackGraphicHeight = 50; // on-screen height of a set of track details
        public const decimal MinTotalWidth = 2.0M;// for calculating allowable lock-groove limits
        public const decimal MinRunOut = 0.5M;    // for calculating allowable lock-groove limits
        public const int StepsPerRev = 200;       // stepper motor FULL steps / rev
        public const decimal CmPerRev = 0.1M;      // leadscrew pitch in centimetres
        public const int FastWindLPcm = 10; // ticks per step for fast wind lathe
        public const string ArduinoDevice = "Arduino"; // for device search in autodetect
        //public const int ArduinoTicksPerSecond = 8000; // 125 us 
        public const int BaudRate = 115200;        // for serial communication
        public static Color FormBackColour = Color.SlateGray;
        public static Color FormForeColour = Color.White;
        public static Color FormErrorColour = Color.Red;
        public static Color CurrTrackForeColour = Color.Gold;
        //public static Color CurrTrackBackColour = Color.Silver;
        public static Color TrackForeColour = Color.White;
        public static Color TrackNumberBackColour = Color.DarkSlateGray;
        //public static Color TrackBackColour = Color.Transparent;


    }
}
