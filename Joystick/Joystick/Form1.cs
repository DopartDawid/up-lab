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
        int maxPadValue = 65535;
        Graphics g;
        private const int MOUSEEVENT_LEFTDOWN = 0x02;
        private const int MOUSEEVENT_LEFTUP = 0x04;
        int? prevX = null;
        int? prevY = null;

        public Form1()
        {
            InitializeComponent();
            helper = new DirectInputHelper();
            label4.Size = new Size(label4.Size.Width, 0);
            label5.Size = new Size(0, label5.Size.Height);
            label7.Size = new Size(0, label5.Size.Height);

            pictureBox1.BackColor = Color.White;
            g = pictureBox1.CreateGraphics();
            this.Controls.Add(pictureBox1);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private void moveCursor()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X + (int)(4 * ((float)(2 * helper.valueX - maxPadValue) / maxPadValue)), Cursor.Position.Y + (int)(4 * ((float)(2 * helper.valueY - maxPadValue) / maxPadValue)));
                Console.WriteLine((float)(2*helper.valueX - maxPadValue)/maxPadValue);
                Cursor.Clip = new Rectangle(this.Location, this.Size);
            });
        }

        private void updateProgress()
        {
            while(true)
            {
                moveCursor();
                if (helper.isButtonClicked)
                    mouse_event(MOUSEEVENT_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                else
                    mouse_event(MOUSEEVENT_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(Color.Black, float.Parse("4"));
            g.DrawLine(p, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
            prevX = e.X;
            prevY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            prevX = null;
            prevY = null;
        }
    }
}
