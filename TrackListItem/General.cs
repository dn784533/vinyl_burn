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
using System.Runtime.InteropServices; // DllImport()
using System.Text;

namespace TrackListItem
{
    class General
    {
    }
    public static class Constants
    {
        public const int DfltTrackLPcm = 85;      // default lines per cm for track
        public const int DfltGapLPcm = 20;        // default lines per cm for inter-track gap
        public const decimal DfltGapWidth = 0.1M;      // default gap width in cm
    }

    public static class WAVLength
    {
        // Retrieves the duration, in milliseconds, of a WAV file.
        // Doff of the titfer: Jan Zich
        // http://stackoverflow.com/questions/82319/how-can-i-determine-the-length-of-a-wav-file-in-c
        //
        [DllImport("winmm.dll")]
        private static extern uint mciSendString(
            string command,
            StringBuilder returnValue,
            int returnLength,
            IntPtr winHandle);

        public static int GetSoundLength(string fileName)
        {
            StringBuilder lengthBuf = new StringBuilder(32);

            mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
            mciSendString("status wave length", lengthBuf, lengthBuf.Capacity, IntPtr.Zero);
            mciSendString("close wave", null, 0, IntPtr.Zero);

            int length = 0;
            int.TryParse(lengthBuf.ToString(), out length);

            return length;
        }
    }

}
