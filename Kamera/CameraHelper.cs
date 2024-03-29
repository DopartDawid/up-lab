﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using AForge.Imaging.Filters;
using Accord.Video.FFMPEG;
namespace Kamera
{
    class CameraHelper
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        FilterInfo choosenDevice;
        VideoFileWriter fileWriter;
        public Bitmap currentFrame;
        public Bitmap currentFrameRecord;
        public bool isRecording = false;

        public int contrastVal;
        public int brightnessVal;
        public float saturationVal;

        public bool isGray = false;
        public bool isBW = false;
 
        public CameraHelper()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = null;
            choosenDevice = null;
            currentFrame = null;
            fileWriter = null;
        }

        public List<String> getVideoDevicesNames()
        {
            List<String> deviceNames = new List<String>();

            foreach(FilterInfo device in videoDevices)
            {
                deviceNames.Add(device.Name);
            }

            return deviceNames;
        }

        public void setCurrentDevice(string deviceName)
        {
            foreach(FilterInfo device in videoDevices)
            {
                if(device.Name.Equals(deviceName))
                {
                    choosenDevice = device;
                    return;
                }
            }
        }

        public void startCamera()
        {
            videoSource = new VideoCaptureDevice(choosenDevice.MonikerString);
            videoSource.NewFrame += videoNewFrame;
            videoSource.Start();
            isRecording = true;
        }

        public void stopCamera()
        {
            if (videoSource != null)
                videoSource.SignalToStop();
            isRecording = false;
            fileWriter.Close();
            fileWriter.Dispose();
            fileWriter = null;
        }

        private void videoNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Threshold thresholdFilter = new Threshold(120);
            Grayscale grayscaleFilter = new Grayscale(0.2, 0.7, 0.07);
            BrightnessCorrection brightnessFilter = new BrightnessCorrection(brightnessVal);
            ContrastCorrection contrastFilter = new ContrastCorrection(contrastVal);
            SaturationCorrection saturationFilter = new SaturationCorrection(saturationVal);
            bitmap = brightnessFilter.Apply((Bitmap)bitmap.Clone());
            bitmap = contrastFilter.Apply((Bitmap)bitmap.Clone());
            bitmap = saturationFilter.Apply((Bitmap)bitmap.Clone());

            if (isGray)
            {
                bitmap = grayscaleFilter.Apply((Bitmap)bitmap.Clone());
            }
            if (isBW)
            {
                bitmap = grayscaleFilter.Apply((Bitmap)bitmap.Clone());
                bitmap = thresholdFilter.Apply(bitmap);
            }

            currentFrame = (Bitmap)bitmap.Clone();
            if(fileWriter != null)
            {
                fileWriter.WriteVideoFrame((Bitmap)bitmap.Clone());
            }
        }

        public void recordVideo()
        {
            fileWriter = new VideoFileWriter();
            fileWriter.Open("test.avi", currentFrame.Width, currentFrame.Height, 10, VideoCodec.MPEG4, 2500000);
        }

        public void saveSnapshot()
        {
            if (currentFrame != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = "test_snap";
                dialog.DefaultExt = ".jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.FileName))
                        File.Delete(dialog.FileName);
                    currentFrame.Save(dialog.FileName);

                }

            }
        }

    }



}
