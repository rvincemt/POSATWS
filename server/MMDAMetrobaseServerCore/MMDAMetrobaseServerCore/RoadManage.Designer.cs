namespace WindowsFormsApplication1
{
    partial class RoadManage
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
            this.roadsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet4 = new WindowsFormsApplication1.mmdametrobaseDataSet4();
            this.roadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cameraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet2 = new WindowsFormsApplication1.mmdametrobaseDataSet2();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mmdametrobaseDataSet1 = new WindowsFormsApplication1.mmdametrobaseDataSet1();
            this.mmdametrobaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraTableAdapter = new WindowsFormsApplication1.mmdametrobaseDataSet1TableAdapters.cameraTableAdapter();
            this.grpAddEditDel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoadGroup = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTestCam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoadName = new System.Windows.Forms.TextBox();
            this.txtGPSLong = new System.Windows.Forms.TextBox();
            this.txtGPSLat = new System.Windows.Forms.TextBox();
            this.txtRoadID = new System.Windows.Forms.TextBox();
            this.cameraTableAdapter1 = new WindowsFormsApplication1.mmdametrobaseDataSet2TableAdapters.cameraTableAdapter();
            this.roadsTableAdapter = new WindowsFormsApplication1.mmdametrobaseDataSet4TableAdapters.roadsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsLatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsLongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).BeginInit();
            this.grpAddEditDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roadsBindingSource2
            // 
            this.roadsBindingSource2.DataMember = "roads";
            this.roadsBindingSource2.DataSource = this.mmdametrobaseDataSet4;
            // 
            // mmdametrobaseDataSet4
            // 
            this.mmdametrobaseDataSet4.DataSetName = "mmdametrobaseDataSet4";
            this.mmdametrobaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roadsBindingSource1
            // 
            this.roadsBindingSource1.DataMember = "roads";
            this.roadsBindingSource1.DataSource = this.mmdametrobaseDataSet4;
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
            this.grpAddEditDel.Controls.Add(this.label5);
            this.grpAddEditDel.Controls.Add(this.txtRoadGroup);
            this.grpAddEditDel.Controls.Add(this.btnAdd);
            this.grpAddEditDel.Controls.Add(this.btnEdit);
            this.grpAddEditDel.Controls.Add(this.btnDel);
            this.grpAddEditDel.Controls.Add(this.btnClear);
            this.grpAddEditDel.Controls.Add(this.btnTestCam);
            this.grpAddEditDel.Controls.Add(this.btnCancel);
            this.grpAddEditDel.Controls.Add(this.btnSave);
            this.grpAddEditDel.Controls.Add(this.label4);
            this.grpAddEditDel.Controls.Add(this.label3);
            this.grpAddEditDel.Controls.Add(this.label2);
            this.grpAddEditDel.Controls.Add(this.label1);
            this.grpAddEditDel.Controls.Add(this.txtRoadName);
            this.grpAddEditDel.Controls.Add(this.txtGPSLong);
            this.grpAddEditDel.Controls.Add(this.txtGPSLat);
            this.grpAddEditDel.Controls.Add(this.txtRoadID);
            this.grpAddEditDel.Location = new System.Drawing.Point(13, 13);
            this.grpAddEditDel.Name = "grpAddEditDel";
            this.grpAddEditDel.Size = new System.Drawing.Size(347, 321);
            this.grpAddEditDel.TabIndex = 1;
            this.grpAddEditDel.TabStop = false;
            this.grpAddEditDel.Enter += new System.EventHandler(this.grpAddEditDel_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Road Group";
            // 
            // txtRoadGroup
            // 
            this.txtRoadGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roadsBindingSource2, "road", true));
            this.txtRoadGroup.Location = new System.Drawing.Point(146, 75);
            this.txtRoadGroup.Name = "txtRoadGroup";
            this.txtRoadGroup.Size = new System.Drawing.Size(195, 20);
            this.txtRoadGroup.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(146, 229);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(49, 35);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(201, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            // 
            // btnTestCam
            // 
            this.btnTestCam.Location = new System.Drawing.Point(10, 270);
            this.btnTestCam.Name = "btnTestCam";
            this.btnTestCam.Size = new System.Drawing.Size(75, 34);
            this.btnTestCam.TabIndex = 2;
            this.btnTestCam.Text = "Test Camera";
            this.btnTestCam.UseVisualStyleBackColor = true;
            this.btnTestCam.Click += new System.EventHandler(this.btnTestCam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 270);
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
            this.btnSave.Location = new System.Drawing.Point(252, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Road Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "GPS Long";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GPS Lat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Road ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRoadName
            // 
            this.txtRoadName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roadsBindingSource2, "roadName", true));
            this.txtRoadName.Location = new System.Drawing.Point(146, 109);
            this.txtRoadName.Name = "txtRoadName";
            this.txtRoadName.Size = new System.Drawing.Size(195, 20);
            this.txtRoadName.TabIndex = 3;
            // 
            // txtGPSLong
            // 
            this.txtGPSLong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roadsBindingSource2, "gpsLong", true));
            this.txtGPSLong.Location = new System.Drawing.Point(146, 182);
            this.txtGPSLong.Name = "txtGPSLong";
            this.txtGPSLong.Size = new System.Drawing.Size(195, 20);
            this.txtGPSLong.TabIndex = 2;
            // 
            // txtGPSLat
            // 
            this.txtGPSLat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roadsBindingSource2, "gpsLat", true));
            this.txtGPSLat.Location = new System.Drawing.Point(146, 145);
            this.txtGPSLat.Name = "txtGPSLat";
            this.txtGPSLat.Size = new System.Drawing.Size(195, 20);
            this.txtGPSLat.TabIndex = 1;
            this.txtGPSLat.TextChanged += new System.EventHandler(this.txtCamIP_TextChanged);
            // 
            // txtRoadID
            // 
            this.txtRoadID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roadsBindingSource2, "roadID", true));
            this.txtRoadID.Location = new System.Drawing.Point(146, 42);
            this.txtRoadID.Name = "txtRoadID";
            this.txtRoadID.Size = new System.Drawing.Size(195, 20);
            this.txtRoadID.TabIndex = 0;
            // 
            // cameraTableAdapter1
            // 
            this.cameraTableAdapter1.ClearBeforeFill = true;
            // 
            // roadsTableAdapter
            // 
            this.roadsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roadIDDataGridViewTextBoxColumn,
            this.roadDataGridViewTextBoxColumn,
            this.roadNameDataGridViewTextBoxColumn,
            this.gpsLatDataGridViewTextBoxColumn,
            this.gpsLongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roadsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(425, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "roadID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "Road ID";
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            // 
            // roadDataGridViewTextBoxColumn
            // 
            this.roadDataGridViewTextBoxColumn.DataPropertyName = "road";
            this.roadDataGridViewTextBoxColumn.HeaderText = "Road Group";
            this.roadDataGridViewTextBoxColumn.Name = "roadDataGridViewTextBoxColumn";
            // 
            // roadNameDataGridViewTextBoxColumn
            // 
            this.roadNameDataGridViewTextBoxColumn.DataPropertyName = "roadName";
            this.roadNameDataGridViewTextBoxColumn.HeaderText = "Road Name";
            this.roadNameDataGridViewTextBoxColumn.Name = "roadNameDataGridViewTextBoxColumn";
            // 
            // gpsLatDataGridViewTextBoxColumn
            // 
            this.gpsLatDataGridViewTextBoxColumn.DataPropertyName = "gpsLat";
            this.gpsLatDataGridViewTextBoxColumn.HeaderText = "GPS Lat";
            this.gpsLatDataGridViewTextBoxColumn.Name = "gpsLatDataGridViewTextBoxColumn";
            // 
            // gpsLongDataGridViewTextBoxColumn
            // 
            this.gpsLongDataGridViewTextBoxColumn.DataPropertyName = "gpsLong";
            this.gpsLongDataGridViewTextBoxColumn.HeaderText = "GPS Long";
            this.gpsLongDataGridViewTextBoxColumn.Name = "gpsLongDataGridViewTextBoxColumn";
            // 
            // RoadManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpAddEditDel);
            this.Name = "RoadManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Roads";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).EndInit();
  //        ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).EndInit();
            this.grpAddEditDel.ResumeLayout(false);
            this.grpAddEditDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mmdametrobaseDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource roadsBindingSource;
       
        private mmdametrobaseDataSet1 mmdametrobaseDataSet1;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private mmdametrobaseDataSet1TableAdapters.cameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.GroupBox grpAddEditDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoadName;
        private System.Windows.Forms.TextBox txtGPSLong;
        private System.Windows.Forms.TextBox txtGPSLat;
        private System.Windows.Forms.TextBox txtRoadID;
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
        private mmdametrobaseDataSet4 mmdametrobaseDataSet4;
        private System.Windows.Forms.BindingSource roadsBindingSource1;
        private mmdametrobaseDataSet4TableAdapters.roadsTableAdapter roadsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoadGroup;
        private System.Windows.Forms.BindingSource roadsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsLatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsLongDataGridViewTextBoxColumn;
    }
}