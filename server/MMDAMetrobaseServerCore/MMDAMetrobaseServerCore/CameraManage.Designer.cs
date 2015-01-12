namespace WindowsFormsApplication1
{
    partial class CameraManage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cameraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCamType = new System.Windows.Forms.TextBox();
            this.txtRoadID = new System.Windows.Forms.TextBox();
            this.txtCamIP = new System.Windows.Forms.TextBox();
            this.txtCamID = new System.Windows.Forms.TextBox();
            this.cameraTableAdapter1 = new WindowsFormsApplication1.mmdametrobaseDataSet2TableAdapters.cameraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).BeginInit();
            this.grpAddEditDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cameraIDDataGridViewTextBoxColumn,
            this.camIPDataGridViewTextBoxColumn,
            this.roadIDDataGridViewTextBoxColumn,
            this.camTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cameraBindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(396, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // cameraIDDataGridViewTextBoxColumn
            // 
            this.cameraIDDataGridViewTextBoxColumn.DataPropertyName = "cameraID";
            this.cameraIDDataGridViewTextBoxColumn.HeaderText = "cameraID";
            this.cameraIDDataGridViewTextBoxColumn.Name = "cameraIDDataGridViewTextBoxColumn";
            this.cameraIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camIPDataGridViewTextBoxColumn
            // 
            this.camIPDataGridViewTextBoxColumn.DataPropertyName = "camIP";
            this.camIPDataGridViewTextBoxColumn.HeaderText = "camIP";
            this.camIPDataGridViewTextBoxColumn.Name = "camIPDataGridViewTextBoxColumn";
            this.camIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "roadID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "roadID";
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            this.roadIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camTypeDataGridViewTextBoxColumn
            // 
            this.camTypeDataGridViewTextBoxColumn.DataPropertyName = "camType";
            this.camTypeDataGridViewTextBoxColumn.HeaderText = "camType";
            this.camTypeDataGridViewTextBoxColumn.Name = "camTypeDataGridViewTextBoxColumn";
            this.camTypeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.grpAddEditDel.Controls.Add(this.label4);
            this.grpAddEditDel.Controls.Add(this.label3);
            this.grpAddEditDel.Controls.Add(this.label2);
            this.grpAddEditDel.Controls.Add(this.label1);
            this.grpAddEditDel.Controls.Add(this.txtCamType);
            this.grpAddEditDel.Controls.Add(this.txtRoadID);
            this.grpAddEditDel.Controls.Add(this.txtCamIP);
            this.grpAddEditDel.Controls.Add(this.txtCamID);
            this.grpAddEditDel.Location = new System.Drawing.Point(13, 13);
            this.grpAddEditDel.Name = "grpAddEditDel";
            this.grpAddEditDel.Size = new System.Drawing.Size(347, 303);
            this.grpAddEditDel.TabIndex = 1;
            this.grpAddEditDel.TabStop = false;
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
            this.btnTestCam.Text = "Test Camera";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Camera Type";
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
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCamType
            // 
            this.txtCamType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cameraBindingSource1, "camType", true));
            this.txtCamType.Location = new System.Drawing.Point(146, 151);
            this.txtCamType.Name = "txtCamType";
            this.txtCamType.Size = new System.Drawing.Size(195, 20);
            this.txtCamType.TabIndex = 3;
            // 
            // txtRoadID
            // 
            this.txtRoadID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cameraBindingSource1, "roadID", true));
            this.txtRoadID.Location = new System.Drawing.Point(146, 115);
            this.txtRoadID.Name = "txtRoadID";
            this.txtRoadID.Size = new System.Drawing.Size(195, 20);
            this.txtRoadID.TabIndex = 2;
            // 
            // txtCamIP
            // 
            this.txtCamIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cameraBindingSource1, "camIP", true));
            this.txtCamIP.Location = new System.Drawing.Point(146, 78);
            this.txtCamIP.Name = "txtCamIP";
            this.txtCamIP.Size = new System.Drawing.Size(195, 20);
            this.txtCamIP.TabIndex = 1;
            // 
            // txtCamID
            // 
            this.txtCamID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cameraBindingSource1, "cameraID", true));
            this.txtCamID.Location = new System.Drawing.Point(146, 42);
            this.txtCamID.Name = "txtCamID";
            this.txtCamID.Size = new System.Drawing.Size(195, 20);
            this.txtCamID.TabIndex = 0;
            // 
            // cameraTableAdapter1
            // 
            this.cameraTableAdapter1.ClearBeforeFill = true;
            // 
            // CameraManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.grpAddEditDel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CameraManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Camera";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmdametrobaseDataSetBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.roadsBindingSource)).EndInit();
            this.grpAddEditDel.ResumeLayout(false);
            this.grpAddEditDel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mmdametrobaseDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource roadsBindingSource;
       
        private mmdametrobaseDataSet1 mmdametrobaseDataSet1;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private mmdametrobaseDataSet1TableAdapters.cameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpAddEditDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCamType;
        private System.Windows.Forms.TextBox txtRoadID;
        private System.Windows.Forms.TextBox txtCamIP;
        private System.Windows.Forms.TextBox txtCamID;
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
    }
}