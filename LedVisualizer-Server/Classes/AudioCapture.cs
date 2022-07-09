using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedVisualizer_Server.Classes
{
    internal class AudioCapture
    {
        private string? outputFolder;
        private string? outputFilePath;
        private WasapiLoopbackCapture? capture = null;
        private WaveFileWriter? writer = null;

        public void startRecording()
        {
            outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NAudio");
            Directory.CreateDirectory(outputFolder);
            outputFilePath = Path.Combine(outputFolder, "recorded.wav");
            capture = new WasapiLoopbackCapture();
            // optionally we can set the capture waveformat here: e.g. capture.WaveFormat = new WaveFormat(44100, 16,2);
            writer = new WaveFileWriter(outputFilePath, capture.WaveFormat);

            capture.DataAvailable += new EventHandler<WaveInEventArgs>(capture_DataAvailable);
            capture.RecordingStopped += new EventHandler<StoppedEventArgs>(capture_RecordingStopped);

            capture.StartRecording();
        }

        public void stopRecording()
        {
            if (capture != null)
            {
                capture.StopRecording();
            }
        }

        void capture_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            }
        }

        void capture_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (capture != null)
            {
                capture.Dispose();
                capture = null;
            }

            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }
        }
    }
}
