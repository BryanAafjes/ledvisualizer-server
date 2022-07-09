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
            this.startBroadcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopBroadcasting = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBroadcast
            // 
            this.startBroadcast.Location = new System.Drawing.Point(129, 10);
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
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Broadcasting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop Broadcasting:";
            // 
            // stopBroadcasting
            // 
            this.stopBroadcasting.Location = new System.Drawing.Point(129, 42);
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
            this.statusLabel.Location = new System.Drawing.Point(238, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            this.statusLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBroadcast;
        private Label label1;
        private Label label2;
        private Button stopBroadcasting;
        private Label statusLabel;
    }
}