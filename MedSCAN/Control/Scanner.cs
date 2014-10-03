using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace MedSCAN.Control
{
    /*----------------------------------------------------------------------------
   * Author: J. Nobles
   * Date: 4/21/2014
   * Scanner control class
   *///---------------------------------------------------------------------------
    // This class is used to check if a specific scanner is connected or not. 
    // 1. The scanner info sent to this class
    // 2. The class preforms a query on object connected to this computer (in this case
    //    Win32_keyboard objects.
    // 3. If the scanner info sent to the class is found it returns true, else it returns false.
    public class Scanner
    {
        public static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_Keyboard"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                    (string)device.GetPropertyValue("DeviceID"),
                    (string)device.GetPropertyValue("PNPDeviceID"),
                    (string)device.GetPropertyValue("Description")));
            }

            collection.Dispose();
            return devices;
        }

        public bool GetScannerConnectionStatus(string deviceID, string pnpDeviceID, string description)
        {
            bool connected = false;
            var usbDevices = GetUSBDevices();
            foreach (var usbDevice in usbDevices)
            {
                if (usbDevice.DeviceID.Equals(deviceID) && usbDevice.PnpDeviceID.Equals(pnpDeviceID) && usbDevice.Description.Equals(description))
                    return true;
            }

            return connected; 

        /*------For debugging----------------------------------------------------------------------------------
            var usbDevices = GetUSBDevices();
            foreach (var usbDevice in usbDevices)
            {
                System.Diagnostics.Debug.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description);
            }
          *///-------------------------------------------------------------------------------------------------
        }
    }

    public class USBDeviceInfo{

        public string DeviceID { get; set; }
        public string PnpDeviceID { get; set; }
        public string Description { get; set; } 

        //Constructor
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            if(deviceID != null)
                this.DeviceID = deviceID.Remove(deviceID.Length - 15);
            if(PnpDeviceID != null)
                this.PnpDeviceID = pnpDeviceID.Remove(PnpDeviceID.Length - 15);
            this.Description = description;
        }
    }
}
