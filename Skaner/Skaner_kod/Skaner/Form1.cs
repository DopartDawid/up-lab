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
        int dpi = 100;
        int colorSettting = 1;

        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        public Form1()
        {
            InitializeComponent();
            dm = new DeviceManager();

            typeOfScanCombo.Items.Add("Monochromatyczne");
            typeOfScanCombo.Items.Add("Czarno-białe");
            typeOfScanCombo.Items.Add("Kolorowe");
            typeOfScanCombo.SelectedIndex = 2;
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
            switch(typeOfScanCombo.SelectedIndex)
            {
                case 0:
                    colorSettting = 4;
                    break;
                case 1:
                    colorSettting = 2;
                    break;
                case 2:
                    colorSettting = 1;
                    break;
                default:
                    colorSettting = 1;
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scanBox_Click(object sender, EventArgs e)
        {
            var selectedDevice = scannerDevices.ElementAt(scannerListBox.SelectedIndex).Connect();
            var scanner = selectedDevice.Items[1];
            AdjustScannerSettings(scanner, dpi, 0, 0, brightnessLevel, contrastLevel, colorSettting);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resolutionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resolutionCombo.SelectedIndex == 0) dpi = 100;
            if (resolutionCombo.SelectedIndex == 1) dpi = 200;
            if (resolutionCombo.SelectedIndex == 2) dpi = 300;
            if (resolutionCombo.SelectedIndex == 3) dpi = 400;
            if (resolutionCombo.SelectedIndex == 4) dpi = 500;
            if (resolutionCombo.SelectedIndex == 5) dpi = 600;

        }
    }
}
