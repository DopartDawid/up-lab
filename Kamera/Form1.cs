using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kamera
{
    public partial class Form1 : Form
    {
        CameraHelper helper;

        public Form1()
        {
            InitializeComponent();
            helper = new CameraHelper();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> names = helper.getVideoDevicesNames();
            listBox1.Items.AddRange(names.ToArray());
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            helper.setCurrentDevice(listBox1.SelectedItem.ToString());

            Thread thread = new Thread(updatePictureBox);
            thread.Start();
        }

        private void updatePictureBox()
        {
            helper.startCamera();

            while(helper.isRecording)
            {
                pictureBox1.Invoke((MethodInvoker)delegate
                {
                    if(helper.currentFrame != null)
                        pictureBox1.Image = helper.currentFrame;
                });
            }

            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helper.stopCamera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helper.recordVideo();
        }

        private void contrastBar_ValueChanged(object sender, EventArgs e)
        {
            helper.contrastVal = (int)contrastBar.Value;
        }

        private void brightnessBar_ValueChanged(object sender, EventArgs e)
        {
            helper.brightnessVal = (int)brightnessBar.Value;
        }

        private void saturationBar_ValueChanged(object sender, EventArgs e)
        {
            helper.saturationVal = (float)saturationBar.Value / 100;
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(normalRadioButton.Checked == true)
            {
                helper.isGray = false;
                helper.isBW = false;
            }
        }

        private void grayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (grayRadioButton.Checked == true)
            {
                helper.isGray = true;
                helper.isBW = false;
            }
        }

        private void BWradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (BWradioButton1.Checked == true)
            {
                helper.isGray = false;
                helper.isBW = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            normalRadioButton.Checked = true;
            contrastBar.Value = 50;
            brightnessBar.Value = 0;
            saturationBar.Value = 0;
        }

        private void screenButton_Click(object sender, EventArgs e)
        {
            helper.saveSnapshot();
        }
    }
}
