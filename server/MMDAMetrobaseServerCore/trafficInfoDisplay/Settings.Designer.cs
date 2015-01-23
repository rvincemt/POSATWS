namespace trafficInfoDisplay
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.txtDBUID = new System.Windows.Forms.TextBox();
            this.txtDBPWD = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDevSave = new System.Windows.Forms.Button();
            this.txtDevTSAPI = new System.Windows.Forms.TextBox();
            this.txtDEVRID = new System.Windows.Forms.TextBox();
            this.txtDevID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDevAdvInt = new System.Windows.Forms.TextBox();
            this.txtDevNotInt = new System.Windows.Forms.TextBox();
            this.txtDevAdInt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 287);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtDBName);
            this.tabPage1.Controls.Add(this.txtDBPWD);
            this.tabPage1.Controls.Add(this.txtDBUID);
            this.tabPage1.Controls.Add(this.txtDBServer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDevAdvInt);
            this.tabPage2.Controls.Add(this.txtDevNotInt);
            this.tabPage2.Controls.Add(this.txtDevAdInt);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtDevSave);
            this.tabPage2.Controls.Add(this.txtDevTSAPI);
            this.tabPage2.Controls.Add(this.txtDEVRID);
            this.tabPage2.Controls.Add(this.txtDevID);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database Name:";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(154, 40);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(282, 20);
            this.txtDBServer.TabIndex = 5;
            // 
            // txtDBUID
            // 
            this.txtDBUID.Location = new System.Drawing.Point(154, 73);
            this.txtDBUID.Name = "txtDBUID";
            this.txtDBUID.Size = new System.Drawing.Size(282, 20);
            this.txtDBUID.TabIndex = 6;
            // 
            // txtDBPWD
            // 
            this.txtDBPWD.Location = new System.Drawing.Point(154, 105);
            this.txtDBPWD.Name = "txtDBPWD";
            this.txtDBPWD.Size = new System.Drawing.Size(282, 20);
            this.txtDBPWD.TabIndex = 7;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(154, 136);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(282, 20);
            this.txtDBName.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDevSave
            // 
            this.txtDevSave.Location = new System.Drawing.Point(349, 233);
            this.txtDevSave.Name = "txtDevSave";
            this.txtDevSave.Size = new System.Drawing.Size(102, 28);
            this.txtDevSave.TabIndex = 19;
            this.txtDevSave.Text = "Save";
            this.txtDevSave.UseVisualStyleBackColor = true;
            this.txtDevSave.Click += new System.EventHandler(this.txtDevSave_Click);
            // 
            // txtDevTSAPI
            // 
            this.txtDevTSAPI.Location = new System.Drawing.Point(169, 113);
            this.txtDevTSAPI.Name = "txtDevTSAPI";
            this.txtDevTSAPI.Size = new System.Drawing.Size(282, 20);
            this.txtDevTSAPI.TabIndex = 17;
            // 
            // txtDEVRID
            // 
            this.txtDEVRID.Location = new System.Drawing.Point(169, 81);
            this.txtDEVRID.Name = "txtDEVRID";
            this.txtDEVRID.Size = new System.Drawing.Size(282, 20);
            this.txtDEVRID.TabIndex = 16;
            // 
            // txtDevID
            // 
            this.txtDevID.Location = new System.Drawing.Point(169, 48);
            this.txtDevID.Name = "txtDevID";
            this.txtDevID.Size = new System.Drawing.Size(282, 20);
            this.txtDevID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thingspeak ReadAPI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Road ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Device ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Device Settings";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(472, 261);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "PH Road Information Display v 0.9.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(363, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Application developed by: Rod Vincent Maitim. Licensed through an LGPL. ";
            // 
            // txtDevAdvInt
            // 
            this.txtDevAdvInt.Location = new System.Drawing.Point(169, 207);
            this.txtDevAdvInt.Name = "txtDevAdvInt";
            this.txtDevAdvInt.Size = new System.Drawing.Size(282, 20);
            this.txtDevAdvInt.TabIndex = 25;
            // 
            // txtDevNotInt
            // 
            this.txtDevNotInt.Location = new System.Drawing.Point(169, 175);
            this.txtDevNotInt.Name = "txtDevNotInt";
            this.txtDevNotInt.Size = new System.Drawing.Size(282, 20);
            this.txtDevNotInt.TabIndex = 24;
            // 
            // txtDevAdInt
            // 
            this.txtDevAdInt.Location = new System.Drawing.Point(169, 142);
            this.txtDevAdInt.Name = "txtDevAdInt";
            this.txtDevAdInt.Size = new System.Drawing.Size(282, 20);
            this.txtDevAdInt.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Advisory Interval:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Notification Interval:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ad Interval:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtDBPWD;
        private System.Windows.Forms.TextBox txtDBUID;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button txtDevSave;
        private System.Windows.Forms.TextBox txtDevTSAPI;
        private System.Windows.Forms.TextBox txtDEVRID;
        private System.Windows.Forms.TextBox txtDevID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDevAdvInt;
        private System.Windows.Forms.TextBox txtDevNotInt;
        private System.Windows.Forms.TextBox txtDevAdInt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}