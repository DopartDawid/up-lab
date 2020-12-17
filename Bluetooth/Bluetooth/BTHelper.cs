using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace Bluetooth
{
    class BTHelper
    {
        public BluetoothRadio[] btAdapters;
        public BluetoothClient client;
        public BluetoothRadio chosenRadio;
        public BluetoothDeviceInfo[] btDevices;
        public BluetoothDeviceInfo chosenDevice;
        private BluetoothEndPoint localEnd;

        public BTHelper()
        {
            chosenRadio = null;
        }
           
        public void refreshAdapters()
        {
            btAdapters = BluetoothRadio.AllRadios;
        }

        public void displayAdapterInfo()
        {
            System.Windows.Forms.MessageBox.Show("Name: " + chosenRadio.Name + "\n" +
                                                 "Address: " + chosenRadio.LocalAddress);
        }

        public void refreshDevices()
        {
            localEnd = new BluetoothEndPoint(chosenRadio.LocalAddress, BluetoothService.SerialPort);
            client = new BluetoothClient(localEnd);
            btDevices = client.DiscoverDevices();
        }

        public void displayDeviceInfo()
        {
            System.Windows.Forms.MessageBox.Show("Name: " + chosenDevice.DeviceName + "\n" +
                                                 "Address: " + chosenDevice.DeviceAddress.ToString());
        }

        public void connectDevice()
        {
            try
            {
                BluetoothSecurity.PairRequest(chosenDevice.DeviceAddress, "171220");
            }
            catch
            {
                MessageBox.Show("Pairing failed" + chosenDevice.DeviceName.ToString());
            }
        }
        
        public void sendFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(chosenDevice != null && chosenRadio != null)
                {
                    var uri = new Uri("obex://" + chosenDevice.DeviceAddress + "/" + dialog.FileName);
                    ObexWebRequest request = new ObexWebRequest(uri);
                    request.ReadFile(dialog.FileName);
                    ObexWebResponse response = (ObexWebResponse)request.GetResponse();
                    response.Close();
                }

            }         
        }
    }
}
