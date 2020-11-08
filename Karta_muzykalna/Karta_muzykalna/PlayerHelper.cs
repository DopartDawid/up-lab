using Microsoft.DirectX.DirectSound;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Karta_muzykalna
{
    class PlayerHelper
    {
        //ActiveX
        SoundPlayer wavPlayer;
        String wavFile;
  
        //DirectSound
        Microsoft.DirectX.DirectSound.Device soundDevice;
        BufferDescription buffDesc;
        SecondaryBuffer sound;

        //MP3
        WMPLib.WindowsMediaPlayer wplayer;

        //NAudio Record
        String recordFile = @"E:\Studia\Zajecia\V Semestr\UP\Laby\up-lab\audio.wav";
        private WaveIn recordInstance = null;
        private WaveFileWriter recordWriter = null;

        public enum PlayerType
        {
            ACTIVEX,
            DIRECTSOUND,
        }

        PlayerType playerType = PlayerType.ACTIVEX;

        public PlayerHelper(Form parent)
        {
            wavPlayer = new SoundPlayer();
            wavFile = null;


            soundDevice = new Microsoft.DirectX.DirectSound.Device(DSoundHelper.DefaultPlaybackDevice);
            soundDevice.SetCooperativeLevel(parent,CooperativeLevel.Normal);
            buffDesc = new BufferDescription();
            buffDesc.ControlEffects = true;
            buffDesc.ControlPan = true;
            sound = null;

            wplayer = new WMPLib.WindowsMediaPlayer();
        }

        public void changePlayer(PlayerType type)
        {
            playerType = type;
        }

        public void changePanning(int value)
        {
            sound.Pan = value;
        }

        public Dictionary<String, String> readLoadedWAVHeaderInfo()
        {
            var returnMap = new Dictionary<String, String>();

            FileStream fs = new FileStream(wavFile, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            fs.Position = 8;
            returnMap.Add("format", new String(br.ReadChars(4)));

            fs.Position = 22;
            returnMap.Add("channels", br.ReadInt16().ToString());

            fs.Position = 24;
            returnMap.Add("sample rate", br.ReadInt32().ToString());

            fs.Position = 34;
            returnMap.Add("bits per sample", br.ReadInt16().ToString());

            return returnMap;
        }

        public void setNewFile(String filePath)
        {
            wavFile = filePath;
        }

        public void playWav()
        {
            if(wavFile.Contains(".mp3"))
            {
                wplayer.URL = wavFile;
                wplayer.controls.play();
            }
            else
            {
                switch (playerType)
                {
                    case PlayerType.ACTIVEX:
                        {
                            wavPlayer.SoundLocation = wavFile;
                            wavPlayer.Play();
                            break;
                        }

                    case PlayerType.DIRECTSOUND:
                        {
                            sound = new SecondaryBuffer(wavFile, buffDesc, soundDevice);
                            sound.Play(0, BufferPlayFlags.Default);
                            break;
                        }
                }
            }

        }

        public void stopWav()
        {
            wavPlayer.Stop();
            if(sound != null)
            {
                sound.Stop();
                sound = null;
            }
            wplayer.controls.stop();
        }

        private void recordInstance_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (recordWriter == null) return;
            recordWriter.Write(e.Buffer, 0, e.BytesRecorded);
            recordWriter.Flush();
        }

        private void recordInstance_RecordingStopped(object sender, NAudio.Wave.StoppedEventArgs e)
        {
            this.recordWriter.Dispose();
            this.recordWriter = null;
            recordInstance.Dispose();
        }

        public void startRecord()
        {
            recordInstance = new WaveIn();
            recordInstance.WaveFormat = new NAudio.Wave.WaveFormat(48000, 1);
           
            recordInstance.DataAvailable += new EventHandler<WaveInEventArgs>(recordInstance_DataAvailable);
            recordInstance.RecordingStopped += new EventHandler<StoppedEventArgs>(recordInstance_RecordingStopped);

            recordWriter = new WaveFileWriter(recordFile, recordInstance.WaveFormat);
            recordInstance.StartRecording();
        }

        public void stopRecord()
        {
            recordInstance.StopRecording();
        }
    }
}
