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
using System.Deployment.Application;
using System.Reflection;

namespace VinylBurnUI
{
    public enum Phase { Idle, SetDown, RunIn, PreProg, MusicTrack, TrackGap, RunOut, ForwardWind, BackWind, ZeroForward, ZeroBack, TestCut };
    public enum ArduinoCommand : int { Stop = 0, Forward, Back, ForwardWind, BackWind, GoHome, Zeroise };
    public enum ArduinoXmitType: int { Command = 0, LPcmData, TTData };
    public static class General
    {
         /// <summary>
        /// Retrieve current version of software
        /// </summary>
        /// <returns></returns>
        public static Version GetCurrentVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        /// <summary>
        /// Get version details of current build for display
        /// (Acknowledgement: John Leidegren (http://stackoverflow.com/questions/1600962/displaying-the-build-date))
        /// </summary>
        /// <returns></returns>
        public static DateTime GetBuildDateTime()
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            return new DateTime(2000, 1, 1).Add(new TimeSpan(
                TimeSpan.TicksPerDay * version.Build + // days since 1 January 2000
                TimeSpan.TicksPerSecond * 2 * version.Revision)); // seconds since midnight, (multiply by 2 to get original)
        }
    }
    public class Constants
    {
        public const string AppTitle = "Vinyl Burn";
    }



}
