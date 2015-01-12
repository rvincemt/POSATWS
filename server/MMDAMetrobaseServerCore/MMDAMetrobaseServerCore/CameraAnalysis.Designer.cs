namespace WindowsFormsApplication1
{
    partial class CameraAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.picFloodStat = new System.Windows.Forms.PictureBox();
            this.picAveSpeed = new System.Windows.Forms.PictureBox();
            this.picDensityStat = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgboxProcessed = new Emgu.CV.UI.ImageBox();
            this.btnConnIP = new System.Windows.Forms.Button();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.btnOpenVid = new System.Windows.Forms.Button();
            this.btnTestCam = new System.Windows.Forms.Button();
            this.ofdVideo = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFloodStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAveSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDensityStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.picFloodStat);
            this.grpSettings.Controls.Add(this.picAveSpeed);
            this.grpSettings.Controls.Add(this.picDensityStat);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpSettings.Location = new System.Drawing.Point(626, 0);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(158, 578);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Status";
            // 
            // picFloodStat
            // 
            this.picFloodStat.Location = new System.Drawing.Point(12, 304);
            this.picFloodStat.Name = "picFloodStat";
            this.picFloodStat.Size = new System.Drawing.Size(140, 84);
            this.picFloodStat.TabIndex = 5;
            this.picFloodStat.TabStop = false;
            // 
            // picAveSpeed
            // 
            this.picAveSpeed.Location = new System.Drawing.Point(12, 173);
            this.picAveSpeed.Name = "picAveSpeed";
            this.picAveSpeed.Size = new System.Drawing.Size(140, 84);
            this.picAveSpeed.TabIndex = 4;
            this.picAveSpeed.TabStop = false;
            // 
            // picDensityStat
            // 
            this.picDensityStat.Location = new System.Drawing.Point(12, 49);
            this.picDensityStat.Name = "picDensityStat";
            this.picDensityStat.Size = new System.Drawing.Size(140, 84);
            this.picDensityStat.TabIndex = 3;
            this.picDensityStat.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flood:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ave. Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Density:";
            // 
            // imgboxProcessed
            // 
            this.imgboxProcessed.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgboxProcessed.Location = new System.Drawing.Point(0, 0);
            this.imgboxProcessed.Name = "imgboxProcessed";
            this.imgboxProcessed.Size = new System.Drawing.Size(626, 495);
            this.imgboxProcessed.TabIndex = 6;
            this.imgboxProcessed.TabStop = false;
            // 
            // btnConnIP
            // 
            this.btnConnIP.Location = new System.Drawing.Point(197, 544);
            this.btnConnIP.Name = "btnConnIP";
            this.btnConnIP.Size = new System.Drawing.Size(91, 23);
            this.btnConnIP.TabIndex = 9;
            this.btnConnIP.Text = "Connect to IP";
            this.btnConnIP.UseVisualStyleBackColor = true;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Location = new System.Drawing.Point(12, 546);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(179, 20);
            this.txtIPAddr.TabIndex = 8;
            // 
            // btnOpenVid
            // 
            this.btnOpenVid.Location = new System.Drawing.Point(12, 504);
            this.btnOpenVid.Name = "btnOpenVid";
            this.btnOpenVid.Size = new System.Drawing.Size(179, 36);
            this.btnOpenVid.TabIndex = 7;
            this.btnOpenVid.Text = "Open File";
            this.btnOpenVid.UseVisualStyleBackColor = true;
            this.btnOpenVid.Click += new System.EventHandler(this.btnOpenVid_Click);
            // 
            // btnTestCam
            // 
            this.btnTestCam.Location = new System.Drawing.Point(197, 502);
            this.btnTestCam.Name = "btnTestCam";
            this.btnTestCam.Size = new System.Drawing.Size(91, 36);
            this.btnTestCam.TabIndex = 10;
            this.btnTestCam.Text = "Test Cam";
            this.btnTestCam.UseVisualStyleBackColor = true;
            this.btnTestCam.Click += new System.EventHandler(this.btnTestCam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // CameraAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTestCam);
            this.Controls.Add(this.btnConnIP);
            this.Controls.Add(this.txtIPAddr);
            this.Controls.Add(this.btnOpenVid);
            this.Controls.Add(this.imgboxProcessed);
            this.Controls.Add(this.grpSettings);
            this.Name = "CameraAnalysis";
            this.Text = "Camera Analysis Module";
            this.Load += new System.EventHandler(this.CameraAnalysis_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFloodStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAveSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDensityStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxProcessed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.PictureBox picFloodStat;
        private System.Windows.Forms.PictureBox picAveSpeed;
        private System.Windows.Forms.PictureBox picDensityStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imgboxProcessed;
        private System.Windows.Forms.Button btnConnIP;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.Button btnOpenVid;
        private System.Windows.Forms.Button btnTestCam;
        private System.Windows.Forms.OpenFileDialog ofdVideo;
        private System.Windows.Forms.Label label4;
    }
}