namespace LedVisualizer_Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startBroadcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopBroadcasting = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.labelDeviceSelector = new System.Windows.Forms.Label();
            this.comboBoxAudioDevices = new System.Windows.Forms.ComboBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.vuMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBroadcast
            // 
            this.startBroadcast.Location = new System.Drawing.Point(124, 45);
            this.startBroadcast.Name = "startBroadcast";
            this.startBroadcast.Size = new System.Drawing.Size(75, 23);
            this.startBroadcast.TabIndex = 0;
            this.startBroadcast.Text = "Start";
            this.startBroadcast.UseVisualStyleBackColor = true;
            this.startBroadcast.Click += new System.EventHandler(this.startBroadcast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Broadcasting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop Broadcasting:";
            // 
            // stopBroadcasting
            // 
            this.stopBroadcasting.Location = new System.Drawing.Point(124, 77);
            this.stopBroadcasting.Name = "stopBroadcasting";
            this.stopBroadcasting.Size = new System.Drawing.Size(75, 23);
            this.stopBroadcasting.TabIndex = 2;
            this.stopBroadcasting.Text = "Stop";
            this.stopBroadcasting.UseVisualStyleBackColor = true;
            this.stopBroadcasting.Click += new System.EventHandler(this.stopBroadcasting_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(233, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 4;
            // 
            // labelDeviceSelector
            // 
            this.labelDeviceSelector.AutoSize = true;
            this.labelDeviceSelector.Location = new System.Drawing.Point(12, 9);
            this.labelDeviceSelector.Name = "labelDeviceSelector";
            this.labelDeviceSelector.Size = new System.Drawing.Size(114, 15);
            this.labelDeviceSelector.TabIndex = 5;
            this.labelDeviceSelector.Text = "Select Audio Device:";
            // 
            // comboBoxAudioDevices
            // 
            this.comboBoxAudioDevices.FormattingEnabled = true;
            this.comboBoxAudioDevices.Location = new System.Drawing.Point(132, 9);
            this.comboBoxAudioDevices.Name = "comboBoxAudioDevices";
            this.comboBoxAudioDevices.Size = new System.Drawing.Size(227, 23);
            this.comboBoxAudioDevices.TabIndex = 6;
            this.comboBoxAudioDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioDevices_SelectedIndexChanged);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 10;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // vuMeter
            // 
            this.vuMeter.Location = new System.Drawing.Point(90, 120);
            this.vuMeter.Name = "vuMeter";
            this.vuMeter.Size = new System.Drawing.Size(260, 23);
            this.vuMeter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Audio Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vuMeter);
            this.Controls.Add(this.comboBoxAudioDevices);
            this.Controls.Add(this.labelDeviceSelector);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopBroadcasting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBroadcast);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED Audio Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBroadcast;
        private Label label1;
        private Label label2;
        private Button stopBroadcasting;
        private Label statusLabel;
        private Label labelDeviceSelector;
        private ComboBox comboBoxAudioDevices;
        private System.Windows.Forms.Timer refreshTimer;
        private ProgressBar vuMeter;
        private Label label3;
    }
}