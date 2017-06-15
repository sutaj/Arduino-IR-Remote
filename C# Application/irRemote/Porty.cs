/***
 *     ▄▄▄       ██ ▄█▀ ██▓ ██▓    
 *    ▒████▄     ██▄█▒ ▓██▒▓██▒    
 *    ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░    
 *    ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░    
 *     ▓█   ▓██▒▒██▒ █▄░██░░██████▒
 *     ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
 *      ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
 *      ░   ▒   ░ ░░ ░  ▒ ░  ░ ░   
 *          ░  ░░  ░    ░      ░  ░
 *                                 
 */

using System.Management;

namespace irRemote
{
    class PORTS
    {

        /// <summary>
        /// Sprawdź numer portu / check port number
        /// </summary>
        /// <param name="usbDeviceName">nazwa / device name</param>
        /// <returns>zwraca numer portu / port number</returns>
        internal string getPorts(string usbDeviceName)
        {
            var searcher = new ManagementObjectSearcher("root\\CIMV2", @"SELECT * FROM Win32_SerialPort");
            string prt = null;
            ManagementObjectCollection collection = searcher.Get();
            foreach (var device in collection)
            {
                string deviceId = device["Description"].ToString();
                string port = device["DeviceID"].ToString();
                if (deviceId == usbDeviceName)
                {
                    prt = port;
                }
            }
            return prt;
        }
    }
}
