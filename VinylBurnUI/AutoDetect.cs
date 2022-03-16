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
using System.Management;

namespace VinylBurnUI
{
    public class AutoDetect
    {
        public event EventHandler<DetectionEventArgs> ProgressChanged;
        public event EventHandler DetectionComplete;

        /// <summary>
        /// Loop through all serial ports to find one with an Arduino connected.
        /// Thanks to 'Brandon': http://stackoverflow.com/questions/3293889/how-to-auto-detect-arduino-com-port
        /// </summary>
        /// <returns></returns>
        public string AutodetectArduinoPort(SerialHandler iSerialHandler)
        {
            ManagementScope connectionScope = new ManagementScope(@"\\" + Environment.MachineName + @"\root\CIMV2");
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_PnPEntity");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);
            try
            {
                ManagementObjectCollection moColl = searcher.Get();
                int moCount = 100 / moColl.Count; // for splash screen progress bar
                int moProg = 0;
                foreach (ManagementObject item in moColl)
                {
                    string desc = item["Caption"]?.ToString();
                    string deviceId = item["DeviceID"]?.ToString();
                    // Check each desc for null and then its contents
                    if (desc != null && desc.Contains(GenMethods.Constants.ArduinoDevice) && desc.Contains("(COM"))
                    {
                        // Found Arduino!
                        iSerialHandler.Hardware = desc;
                        int indexOfCom = desc.IndexOf("(COM");
                        iSerialHandler.PortName = desc.Substring(indexOfCom+1, desc.Length - indexOfCom - 2);
                        FireEventDetectionComplete();
                        return deviceId;
                    }
                    // Update progress bar
                    moProg += moCount;
                    FireEventProgressChanged(moProg);
                }
                FireEventDetectionComplete();
            }
            catch (ManagementException ex)
            {
                /* Do Nothing */
            }

            return null;
        }

        /// <summary>
        /// Fires the ProgressChanged event, taking as parameter
        /// a DetectionEventArgs object with the progress data
        /// </summary>
        /// <param name="iPercent"></param>
        private void FireEventProgressChanged(int iPercent)
        {
            ProgressChanged?.Invoke(this, new DetectionEventArgs(iPercent));
        }

        /// <summary>
        /// Fires the DetectionComplete event. No data needs to be passed
        /// so the empty EventArgs object is the parameter
        /// </summary>
        private void FireEventDetectionComplete()
        {
            DetectionComplete?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Inherits from EventArgs. Allows custom data (progress percentage)
    /// to be passed from the ProgressChanged event.
    /// </summary>
    public class DetectionEventArgs : EventArgs
    {
        public int Progress { get; private set; }
        
        public DetectionEventArgs(int progress)
        {
            Progress = progress;
        }

    }

}

