using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karta_muzykalna
{
    public partial class Form1 : Form
    {
        PlayerHelper player;
        public Form1()
        {
            InitializeComponent();
            player = new PlayerHelper();
        }

        private void recStopButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
   
            dialog.CheckFileExists = true;
            dialog.Filter = "WAV files (*.wav)|*.wav";
            dialog.DefaultExt = ".wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                player.setNewFile(dialog.FileName);

                var infoMap = player.readLoadedWAVHeaderInfo();
                
                foreach(var item in infoMap)
                {
                    listBox1.Items.Add(item.Key + ": " + item.Value);
                }
            }

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            player.playWav();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.stopWav();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
