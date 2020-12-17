using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        BTHelper helper;
        public Form1()
        {
            InitializeComponent();
            helper = new BTHelper();
        }

        private void searchAdapterButton_Click(object sender, EventArgs e)
        {
            helper.refreshAdapters();
            adaptersListBox.Items.Clear();
            if (helper.btAdapters.Length != 0)
            {
                foreach (var device in helper.btAdapters)
                    adaptersListBox.Items.Add(device.Name);
            }
            
        }

        private void adaptersInfoButton_Click(object sender, EventArgs e)
        {
            if (helper.chosenRadio != null)
                helper.displayAdapterInfo();
                
        }

        private void adaptersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            helper.chosenRadio = helper.btAdapters[adaptersListBox.SelectedIndex];
        }

        private void searchDevicesButton_Click(object sender, EventArgs e)
        {
            devicesListBox.Items.Clear();
            if(helper.chosenRadio != null)
            {
                helper.refreshDevices();
                foreach(var device in helper.btDevices)
                {
                    devicesListBox.Items.Add(device.DeviceName.ToString());
                }
            }
        }

        private void devicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            helper.chosenDevice = helper.btDevices[devicesListBox.SelectedIndex];
        }

        private void deviceInfoButton_Click(object sender, EventArgs e)
        {
            if (helper.chosenRadio != null)
               if(helper.chosenDevice != null)
                    helper.displayDeviceInfo();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(helper.chosenDevice != null)
                helper.connectDevice();
        }

        private void sendFileButton_Click(object sender, EventArgs e)
        {
            helper.sendFile();
        }
    }
}
