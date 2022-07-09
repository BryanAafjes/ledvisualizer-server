using LedVisualizer_Server.Classes;

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

        private void startBroadcast_Click(object sender, EventArgs e)
        {
            audioCapture.startRecording();
            statusLabel.Text = "Recording....";
            startBroadcast.Enabled = false;
            stopBroadcasting.Enabled = true;
        }

        private void stopBroadcasting_Click(object sender, EventArgs e)
        {
            audioCapture.stopRecording();
            statusLabel.Text = "Recording stopped";
            startBroadcast.Enabled = true;
            stopBroadcasting.Enabled = false;
        }
    }
}