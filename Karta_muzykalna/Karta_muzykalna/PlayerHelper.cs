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
            buffDesc.ControlEffects = false;
            sound = null;
            
        }

        public void changePlayer(PlayerType type)
        {
            playerType = type;
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
            switch(playerType)
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

        public void stopWav()
        {
            wavPlayer.Stop();
            if(sound != null)
            {
                sound.Stop();
                sound = null;
            }
        }
    }
}
