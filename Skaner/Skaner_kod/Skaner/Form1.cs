using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using WIA;
using System.Drawing.Imaging;

namespace Skaner
{
    public partial class Form1 : Form
    {
        DeviceManager dm = null;
        List<DeviceInfo> scannerDevices = new List<DeviceInfo> { };
        ImageFile scannedFile = null;

        int contrastLevel = 0;
        int brightnessLevel = 0;

        public Form1()
        {
            InitializeComponent();
            dm = new DeviceManager();

            typeOfScanCombo.Items.Add("Monochromatyczne");
            typeOfScanCombo.Items.Add("Czarno-białe");
            typeOfScanCombo.Items.Add("Kolorowe");
            typeOfScanCombo.SelectedIndex = 0;
            scanImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int iii = 1; iii <= dm.DeviceInfos.Count; iii++)
            {
                if (dm.DeviceInfos[iii].Type != WiaDeviceType.ScannerDeviceType)
                    continue;

                scannerListBox.Items.Add(dm.DeviceInfos[iii].Properties["Name"].get_Value());
                scannerDevices.Add(dm.DeviceInfos[iii]);
                scannerListBox.SelectedIndex = iii-1;
            }
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            contrastLevel = contrastBar.Value;
        }

        private void brightnessBar_Scroll(object sender, EventArgs e)
        {
            brightnessLevel = brightnessBar.Value;
        }

        private void typeOfScan_Box(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scanBox_Click(object sender, EventArgs e)
        {
            var selectedDevice = scannerDevices.ElementAt(scannerListBox.SelectedIndex).Connect();
            var scanner = selectedDevice.Items[1];

            scannedFile = (ImageFile)scanner.Transfer(WIA.FormatID.wiaFormatJPEG);
            var imageBytes = (byte[])scannedFile.FileData.get_BinaryData();
            var ms = new MemoryStream(imageBytes);
            scanImage.Image = Image.FromStream(ms);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "image files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "scan.jpeg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                    File.Delete(saveFileDialog.FileName);
                scannedFile.SaveFile(saveFileDialog.FileName);
            }
        }

    }
}
