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

namespace Joystick
{
    public partial class Form1 : Form
    {
        DirectInputHelper helper;
        int progressBarMaxSize = 250;
        int maxPadValue = 66000;

        public Form1()
        {
            InitializeComponent();
            helper = new DirectInputHelper();
            label4.Size = new Size(label4.Size.Width, 0);
            label5.Size = new Size(0, label5.Size.Height);
            label7.Size = new Size(0, label5.Size.Height);
        }

        private void updateProgress()
        {
            while(true)
            {

                label4.Invoke((MethodInvoker)delegate
                {
                    label4.Size = new Size(label4.Size.Width, Convert.ToInt32(progressBarMaxSize * (Convert.ToDouble(helper.valueY) / maxPadValue)));
                });

                label5.Invoke((MethodInvoker)delegate
                {
                    label5.Size = new Size(Convert.ToInt32(progressBarMaxSize * (Convert.ToDouble(helper.valueX) / maxPadValue)), label5.Size.Height);
                });

                checkBox1.Invoke((MethodInvoker)delegate
                {
                    checkBox1.Checked = helper.isButtonClicked;
                });

                label7.Invoke((MethodInvoker)delegate
                {
                    label7.Size = new Size(Convert.ToInt32(progressBarMaxSize * (Convert.ToDouble(helper.valueTriggers) / maxPadValue)), label7.Size.Height);
                });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            helper.connectGamepad();
            textBox1.Text = helper.getGamepadName();
            Thread thread = new Thread(updateProgress);
            thread.Start();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
