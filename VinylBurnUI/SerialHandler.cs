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
using System.IO.Ports;

namespace VinylBurnUI
{
    public class SerialHandler
    {

        public string PortName { get; set; }
        public SerialPort ArduinoPort { get; set; }
        public string Hardware { get; set; }
        // Properties for acknowledged data from Arduino.
        public int RecdStepsTaken { get; set; }

        public event EventHandler<DataRecdEventArgs> ArduinoDataRecd;

        /// <summary>
        /// Opens a specified port (the one auto-detected earlier).
        /// </summary>
        /// <param name="vSerialPort"></param>
        public void OpenSerial(SerialPort iSerialPort)
        {
            // Close previously open port, if applicable.
            if (ArduinoPort != null)
                CloseSerial();
            ArduinoPort = iSerialPort;
            try
            {
                ArduinoPort.DataReceived += ArduinoPort_DataReceived;
                ArduinoPort.PortName = PortName;
                ArduinoPort.DataBits = 8;
                ArduinoPort.Parity = Parity.None;
                ArduinoPort.BaudRate = GenMethods.Constants.BaudRate;
                ArduinoPort.Open();
                //ArduinoPort.DiscardInBuffer();
            }
            catch (Exception e)
            {
                throw new Exception("Could not open the Arduino on port " + PortName + ". " + e.Message);
            }
        }

        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int recdStepsTaken;
            int recdLimitLo;
            int recdLimitHi;
            try
            {
                // Read serial data to end-of-transmission marker '>'.
                string dataRecd = ArduinoPort.ReadTo(">");
                // Split string data based on start-of-transmission '<' and data field delimiters.
                string[] dataRecdArray = dataRecd.Split(new char[] { '<', 'L', 'H' },
                    StringSplitOptions.RemoveEmptyEntries);
                // Try to parse the incoming text data as integers
                int.TryParse(dataRecdArray[0], out recdStepsTaken);
                int.TryParse(dataRecdArray[1], out recdLimitLo);
                int.TryParse(dataRecdArray[2], out recdLimitHi);

                ArduinoDataRecd?.Invoke(this, new DataRecdEventArgs( 
                    recdStepsTaken,
                    recdLimitLo, recdLimitHi));
            }
            catch(Exception ex)
            {

            }
        }

        /// <summary>
        /// Inherits from EventArgs. Allows custom data (progress percentage)
        /// to be passed from the ProgressChanged event.
        /// </summary>
        public class DataRecdEventArgs : EventArgs
        {
            public int RecdStepsTaken { get; private set; }
            public int RecdLimitLo { get; set; }
            public int RecdLimitHi { get; set; }

            public DataRecdEventArgs(int iRecdStepsTaken, int iRecdLimitLo, int iRecdLimitHi)
            {
                RecdStepsTaken = iRecdStepsTaken;
                RecdLimitLo = iRecdLimitLo;
                RecdLimitHi = iRecdLimitHi;
            }

        }
        /// <summary>
        /// Closes the Arduino port.
        /// If it was never opened (if, say, there is no Arduino connected),
        /// then do a 'silent catch' and ignore the exception.
        /// </summary>
        /// <returns></returns>
        public void CloseSerial()
        {
            try
            {
                if (ArduinoPort != null && !ArduinoPort.IsOpen) ArduinoPort.Close();
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// Send either a command or ticks-per-step data to Arduino. The command is suffixed with a 
        /// non-numeric character (">") to delimit the numeric data.
        /// </summary>
        /// <param name="iXtype"></param>
        /// <param name="iData"></param>
        public void SendDataToArduino(ArduinoXmitType iXtype, int iData)
        {
            try
            {
                if (ArduinoPort == null || !ArduinoPort.IsOpen) return; // check port is open
                switch (iXtype)
                {
                    case ArduinoXmitType.Command:
                        ArduinoPort.Write(String.Concat("C", iData.ToString(), ">"));
                        break;
                    case ArduinoXmitType.TTData:
                        ArduinoPort.Write(String.Concat("R", iData.ToString(), ">"));
                        break;
                    case ArduinoXmitType.LPcmData:
                        ArduinoPort.Write(String.Concat("T", iData.ToString(), ">"));
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not submit command to Arduino. " + ex.Message);
            }
        }
    }
}



