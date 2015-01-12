namespace WindowsFormsApplication1
{
    partial class SensorManage
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
            this.cameraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet2 = new WindowsFormsApplication1.mmdametrobaseDataSet2();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet1 = new WindowsFormsApplication1.mmdametrobaseDataSet1();
            this.mmdametrobaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraTableAdapter = new WindowsFormsApplication1.mmdametrobaseDataSet1TableAdapters.cameraTableAdapter();
            this.grpAddEditDel = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTestCam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoadID = new System.Windows.Forms.TextBox();
            this.sensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet = new WindowsFormsApplication1.mmdametrobaseDataSet();
            this.txtGsmNum = new System.Windows.Forms.TextBox();
            this.txtSenID = new System.Windows.Forms.TextBox();
            this.cameraTableAdapter1 = new WindowsFormsApplication1.mmdametrobaseDataSet2TableAdapters.cameraTableAdapter();
            this.sensorTableAdapter = new WindowsFormsApplication1.mmdametrobaseDataSetTableAdapters.sensorTableAdapter();
            this.mmdametrobaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roadsTableAdapter = new WindowsFormsApplication1.mmdametrobaseDataSet1TableAdapters.roadsTableAdapter();
            this.sensorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sensorTableAdapter1 = new WindowsFormsApplication1.mmdametrobaseDataSet1TableAdapters.sensorTableAdapter();
            this.sensorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsmNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).BeginInit();
            this.grpAddEditDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBindingSource1
            // 
            this.cameraBindingSource1.DataMember = "camera";
            this.cameraBindingSource1.DataSource = this.mmdametrobaseDataSet2;
            // 
            // mmdametrobaseDataSet2
            // 
            this.mmdametrobaseDataSet2.DataSetName = "mmdametrobaseDataSet2";
            this.mmdametrobaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "camera";
            this.cameraBindingSource.DataSource = this.mmdametrobaseDataSet1;
            // 
            // mmdametrobaseDataSet1
            // 
            this.mmdametrobaseDataSet1.DataSetName = "mmdametrobaseDataSet1";
            this.mmdametrobaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roadsBindingSource
            // 
            this.roadsBindingSource.DataMember = "roads";
            this.roadsBindingSource.DataSource = this.mmdametrobaseDataSetBindingSource;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // grpAddEditDel
            // 
            this.grpAddEditDel.Controls.Add(this.btnAdd);
            this.grpAddEditDel.Controls.Add(this.btnEdit);
            this.grpAddEditDel.Controls.Add(this.btnDel);
            this.grpAddEditDel.Controls.Add(this.btnClear);
            this.grpAddEditDel.Controls.Add(this.btnTestCam);
            this.grpAddEditDel.Controls.Add(this.btnCancel);
            this.grpAddEditDel.Controls.Add(this.btnSave);
            this.grpAddEditDel.Controls.Add(this.label3);
            this.grpAddEditDel.Controls.Add(this.label2);
            this.grpAddEditDel.Controls.Add(this.label1);
            this.grpAddEditDel.Controls.Add(this.txtRoadID);
            this.grpAddEditDel.Controls.Add(this.txtGsmNum);
            this.grpAddEditDel.Controls.Add(this.txtSenID);
            this.grpAddEditDel.Location = new System.Drawing.Point(13, 13);
            this.grpAddEditDel.Name = "grpAddEditDel";
            this.grpAddEditDel.Size = new System.Drawing.Size(347, 303);
            this.grpAddEditDel.TabIndex = 1;
            this.grpAddEditDel.TabStop = false;
            this.grpAddEditDel.Enter += new System.EventHandler(this.grpAddEditDel_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(146, 192);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(49, 35);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(201, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            // 
            // btnTestCam
            // 
            this.btnTestCam.Location = new System.Drawing.Point(10, 233);
            this.btnTestCam.Name = "btnTestCam";
            this.btnTestCam.Size = new System.Drawing.Size(75, 34);
            this.btnTestCam.TabIndex = 2;
            this.btnTestCam.Text = "Test Sensor";
            this.btnTestCam.UseVisualStyleBackColor = true;
            this.btnTestCam.Click += new System.EventHandler(this.btnTestCam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Road ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GSM Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sensor ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRoadID
            // 
            this.txtRoadID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sensorBindingSource, "roadID", true));
            this.txtRoadID.Location = new System.Drawing.Point(146, 115);
            this.txtRoadID.Name = "txtRoadID";
            this.txtRoadID.Size = new System.Drawing.Size(195, 20);
            this.txtRoadID.TabIndex = 2;
            // 
            // sensorBindingSource
            // 
            this.sensorBindingSource.DataMember = "sensor";
            this.sensorBindingSource.DataSource = this.mmdametrobaseDataSet;
            // 
            // mmdametrobaseDataSet
            // 
            this.mmdametrobaseDataSet.DataSetName = "mmdametrobaseDataSet";
            this.mmdametrobaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGsmNum
            // 
            this.txtGsmNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sensorBindingSource, "gsmNum", true));
            this.txtGsmNum.Location = new System.Drawing.Point(146, 78);
            this.txtGsmNum.Name = "txtGsmNum";
            this.txtGsmNum.Size = new System.Drawing.Size(195, 20);
            this.txtGsmNum.TabIndex = 1;
            // 
            // txtSenID
            // 
            this.txtSenID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sensorBindingSource, "sensorID", true));
            this.txtSenID.Location = new System.Drawing.Point(146, 42);
            this.txtSenID.Name = "txtSenID";
            this.txtSenID.Size = new System.Drawing.Size(195, 20);
            this.txtSenID.TabIndex = 0;
            // 
            // cameraTableAdapter1
            // 
            this.cameraTableAdapter1.ClearBeforeFill = true;
            // 
            // sensorTableAdapter
            // 
            this.sensorTableAdapter.ClearBeforeFill = true;
            // 
            // mmdametrobaseDataSet1BindingSource
            // 
            this.mmdametrobaseDataSet1BindingSource.DataSource = this.mmdametrobaseDataSet1;
            this.mmdametrobaseDataSet1BindingSource.Position = 0;
            // 
            // roadsBindingSource1
            // 
            this.roadsBindingSource1.DataMember = "roads";
            this.roadsBindingSource1.DataSource = this.mmdametrobaseDataSet1BindingSource;
            // 
            // roadsTableAdapter
            // 
            this.roadsTableAdapter.ClearBeforeFill = true;
            // 
            // sensorBindingSource1
            // 
            this.sensorBindingSource1.DataMember = "sensor";
            this.sensorBindingSource1.DataSource = this.mmdametrobaseDataSet1BindingSource;
            // 
            // sensorTableAdapter1
            // 
            this.sensorTableAdapter1.ClearBeforeFill = true;
            // 
            // sensorBindingSource2
            // 
            this.sensorBindingSource2.DataMember = "sensor";
            this.sensorBindingSource2.DataSource = this.mmdametrobaseDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorIDDataGridViewTextBoxColumn,
            this.gsmNumDataGridViewTextBoxColumn,
            this.roadIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(487, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 437);
            this.dataGridView1.TabIndex = 2;
            // 
            // sensorIDDataGridViewTextBoxColumn
            // 
            this.sensorIDDataGridViewTextBoxColumn.DataPropertyName = "sensorID";
            this.sensorIDDataGridViewTextBoxColumn.HeaderText = "sensorID";
            this.sensorIDDataGridViewTextBoxColumn.Name = "sensorIDDataGridViewTextBoxColumn";
            // 
            // gsmNumDataGridViewTextBoxColumn
            // 
            this.gsmNumDataGridViewTextBoxColumn.DataPropertyName = "gsmNum";
            this.gsmNumDataGridViewTextBoxColumn.HeaderText = "gsmNum";
            this.gsmNumDataGridViewTextBoxColumn.Name = "gsmNumDataGridViewTextBoxColumn";
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "roadID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "roadID";
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            // 
            // sensorBindingSource3
            // 
            this.sensorBindingSource3.DataMember = "sensor";
            this.sensorBindingSource3.DataSource = this.mmdametrobaseDataSet1BindingSource;
            // 
            // SensorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAddEditDel);
            this.Name = "SensorManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Camera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).EndInit();
            this.grpAddEditDel.ResumeLayout(false);
            this.grpAddEditDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mmdametrobaseDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource roadsBindingSource;
       
        private mmdametrobaseDataSet1 mmdametrobaseDataSet1;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private mmdametrobaseDataSet1TableAdapters.cameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.GroupBox grpAddEditDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoadID;
        private System.Windows.Forms.TextBox txtGsmNum;
        private System.Windows.Forms.TextBox txtSenID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTestCam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private mmdametrobaseDataSet2 mmdametrobaseDataSet2;
        private System.Windows.Forms.BindingSource cameraBindingSource1;
        private mmdametrobaseDataSet2TableAdapters.cameraTableAdapter cameraTableAdapter1;
        private mmdametrobaseDataSet mmdametrobaseDataSet;
        private System.Windows.Forms.BindingSource sensorBindingSource;
        private mmdametrobaseDataSetTableAdapters.sensorTableAdapter sensorTableAdapter;
        private System.Windows.Forms.BindingSource mmdametrobaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource roadsBindingSource1;
        private mmdametrobaseDataSet1TableAdapters.roadsTableAdapter roadsTableAdapter;
        private System.Windows.Forms.BindingSource sensorBindingSource1;
        private mmdametrobaseDataSet1TableAdapters.sensorTableAdapter sensorTableAdapter1;
        private System.Windows.Forms.BindingSource sensorBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsmNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sensorBindingSource3;
    }
}