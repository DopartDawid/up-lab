using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIA;

namespace Skaner
{
    public partial class Form1 : Form
    {
        DeviceManager dm = null;

        int contrastLevel = 0;
        int brightnessLevel = 0;

        public Form1()
        {
            InitializeComponent();
            dm = new DeviceManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int iii = 1; iii <= dm.DeviceInfos.Count; iii++)
            {
                if (dm.DeviceInfos[iii].Type != WiaDeviceType.ScannerDeviceType)
                    continue;

                scannerListBox.Items.Add(dm.DeviceInfos[iii].Properties["Name"].get_Value());
            }
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            ScrollBar bar = (ScrollBar)sender;
            contrastLevel = bar.Value;
        }

        private void brightnessBar_Scroll(object sender, EventArgs e)
        {
            ScrollBar bar = (ScrollBar)sender;
            brightnessLevel = bar.Value;
        }

        private void typeOfScan_Box(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void scanBox_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
