using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Karta_muzykalna
{
    class PlayerHelper
    {
        SoundPlayer wavPlayer;
        String wavFile;
        
        public PlayerHelper()
        {
            wavPlayer = new SoundPlayer();
            wavFile = null;
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
            wavPlayer.SoundLocation = wavFile;
            wavPlayer.Play();
        }

        public void stopWav()
        {
            wavPlayer.Stop();
        }
    }
}
