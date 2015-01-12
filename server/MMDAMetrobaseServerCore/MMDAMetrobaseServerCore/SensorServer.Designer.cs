namespace WindowsFormApplication1
{
    partial class SensorServer
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
            this.btnRead = new System.Windows.Forms.Button();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lvwMessages = new System.Windows.Forms.ListView();
            this.colSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReceivingMode = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParse = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorUpdate_data = new WindowsFormsApplication1.sensorUpdate_data();
            this.sensorupdatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorupdatesTableAdapter = new WindowsFormsApplication1.sensorUpdate_dataTableAdapters.sensorupdatesTableAdapter();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorUpdate_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorupdatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(189, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(95, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Test";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Items.AddRange(new object[] {
            "COM12"});
            this.cboPort.Location = new System.Drawing.Point(393, 14);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 2;
            this.cboPort.Text = "COM12";
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // lvwMessages
            // 
            this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSender,
            this.colMessage});
            this.lvwMessages.Location = new System.Drawing.Point(393, 129);
            this.lvwMessages.Name = "lvwMessages";
            this.lvwMessages.Size = new System.Drawing.Size(411, 248);
            this.lvwMessages.TabIndex = 3;
            this.lvwMessages.UseCompatibleStateImageBehavior = false;
            this.lvwMessages.View = System.Windows.Forms.View.Details;
            // 
            // colSender
            // 
            this.colSender.Text = "Sender";
            this.colSender.Width = 150;
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 500;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReceivingMode
            // 
            this.btnReceivingMode.Location = new System.Drawing.Point(189, 29);
            this.btnReceivingMode.Name = "btnReceivingMode";
            this.btnReceivingMode.Size = new System.Drawing.Size(95, 23);
            this.btnReceivingMode.TabIndex = 4;
            this.btnReceivingMode.Text = "Automatic Mode";
            this.btnReceivingMode.UseVisualStyleBackColor = true;
            this.btnReceivingMode.Visible = false;
            this.btnReceivingMode.Click += new System.EventHandler(this.btnReceivingMode_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(62, 16);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(0, 13);
            this.lblStat.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(110, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Manual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(110, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Auto";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mode:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblParse);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btnReceivingMode);
            this.groupBox1.Controls.Add(this.lblReady);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.lblStat);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(520, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(189, 58);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(95, 23);
            this.btnParse.TabIndex = 13;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parsing:";
            // 
            // lblParse
            // 
            this.lblParse.AutoSize = true;
            this.lblParse.Location = new System.Drawing.Point(163, 16);
            this.lblParse.Name = "lblParse";
            this.lblParse.Size = new System.Drawing.Size(0, 13);
            this.lblParse.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Ready:";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(62, 29);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(0, 13);
            this.lblReady.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roadIDDataGridViewTextBoxColumn,
            this.sensorStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensorupdatesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(349, 365);
            this.dataGridView1.TabIndex = 10;
            // 
            // sensorUpdate_data
            // 
            this.sensorUpdate_data.DataSetName = "sensorUpdate_data";
            this.sensorUpdate_data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorupdatesBindingSource
            // 
            this.sensorupdatesBindingSource.DataMember = "sensorupdates";
            this.sensorupdatesBindingSource.DataSource = this.sensorUpdate_data;
            // 
            // sensorupdatesTableAdapter
            // 
            this.sensorupdatesTableAdapter.ClearBeforeFill = true;
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "roadID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "Road ID";
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            this.roadIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorStatusDataGridViewTextBoxColumn
            // 
            this.sensorStatusDataGridViewTextBoxColumn.DataPropertyName = "sensorStatus";
            this.sensorStatusDataGridViewTextBoxColumn.HeaderText = "Water Level";
            this.sensorStatusDataGridViewTextBoxColumn.Name = "sensorStatusDataGridViewTextBoxColumn";
            this.sensorStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SensorServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwMessages);
            this.Controls.Add(this.cboPort);
            this.Name = "SensorServer";
            this.Text = "SensorServer";
            this.Load += new System.EventHandler(this.SensorServer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorUpdate_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorupdatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.ListView lvwMessages;
        private System.Windows.Forms.ColumnHeader colSender;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReceivingMode;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnParse;
        private WindowsFormsApplication1.sensorUpdate_data sensorUpdate_data;
        private System.Windows.Forms.BindingSource sensorupdatesBindingSource;
        private WindowsFormsApplication1.sensorUpdate_dataTableAdapters.sensorupdatesTableAdapter sensorupdatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorStatusDataGridViewTextBoxColumn;
    }
}