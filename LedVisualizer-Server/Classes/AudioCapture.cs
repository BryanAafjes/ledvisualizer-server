using NAudio.CoreAudioApi;
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
        IWaveIn? Wave;

        public AudioCapture()
        {
            AudioValues = new double[SampleRate * BufferMilliseconds / 1000];
        }

        readonly double[] AudioValues;

        readonly int SampleRate = 44100;
        readonly int BitDepth = 16;
        readonly int ChannelCount = 1;
        readonly int BufferMilliseconds = 20;

        public List<WaveInCapabilities> initAudioDevices()
        {
            List<WaveInCapabilities> audioDeviceList = new List<WaveInCapabilities>();

            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                var caps = WaveIn.GetCapabilities(i);
                audioDeviceList.Add(caps);
            }

            return audioDeviceList;
        }

        public void changeDevice(int selectedIndex)
        {
            if (Wave is not null)
            {
                Wave.StopRecording();
                Wave.Dispose();
            }

            if (selectedIndex == 0)
            {
                Wave = new WasapiCapture();
                return;
            }

            if (selectedIndex == -1)
            {
                return;
            }

            Wave = new WaveInEvent()
            {
                DeviceNumber = selectedIndex,
                WaveFormat = new WaveFormat(SampleRate, BitDepth, ChannelCount),
                BufferMilliseconds = BufferMilliseconds
            };
        }

        void WaveIn_DataAvailable(object? sender, WaveInEventArgs e)
        {
            for (int i = 0; i < e.Buffer.Length / 2; i++)
                AudioValues[i] = BitConverter.ToInt16(e.Buffer, i * 2);
        }

        public void startCapture()
        {
            if (Wave != null)
            {
                Wave.DataAvailable += WaveIn_DataAvailable;
                Wave.StartRecording();
            }
        }

        public void stopCapture()
        {
            if (Wave != null)
            {
                Wave.StopRecording();
                Wave.Dispose();

                Wave = null;
            }
        }
    }
}
