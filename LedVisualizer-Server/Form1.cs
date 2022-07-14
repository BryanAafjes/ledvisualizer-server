using LedVisualizer_Server.Classes;
using NAudio.Wave;
using System.Diagnostics;

namespace LedVisualizer_Server
{
    public partial class Form1 : Form
    {
        private AudioCapture audioCapture;

        public Form1()
        {
            InitializeComponent();
            audioCapture = new AudioCapture();
            startBroadcast.Enabled = true;
            stopBroadcasting.Enabled = false;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxAudioDevices.Items.Add("Default Audio Loopback");

            List<WaveInCapabilities> audioDevices = audioCapture.initAudioDevices();
            foreach (WaveInCapabilities audioDevice in audioDevices)
            {
                comboBoxAudioDevices.Items.Add(audioDevice.ProductName);
            }

            comboBoxAudioDevices.SelectedIndex = 0;
        }

        private void startBroadcast_Click(object sender, EventArgs e)
        {
            audioCapture.startCapture();
            statusLabel.Text = "Audio capture started";
            startBroadcast.Enabled = false;
            stopBroadcasting.Enabled = true;
        }

        private void stopBroadcasting_Click(object sender, EventArgs e)
        {
            audioCapture.stopCapture();
            statusLabel.Text = "Audio capture stopped";
            startBroadcast.Enabled = true;
            stopBroadcasting.Enabled = false;
        }

        private void comboBoxAudioDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            audioCapture.changeDevice(comboBoxAudioDevices.SelectedIndex);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}