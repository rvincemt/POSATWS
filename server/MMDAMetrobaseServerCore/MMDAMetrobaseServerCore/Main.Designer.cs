namespace WindowsFormsApplication1
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSensorServer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnTrafficMap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Cam_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roadDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningNotifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_manage_road = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCredentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCamCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSensorCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusRoadDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTableView);
            this.groupBox1.Controls.Add(this.btnTrafficMap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Views";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSensorServer);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(7, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 371);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initialize Components";
            // 
            // btnSensorServer
            // 
            this.btnSensorServer.Location = new System.Drawing.Point(7, 29);
            this.btnSensorServer.Name = "btnSensorServer";
            this.btnSensorServer.Size = new System.Drawing.Size(163, 46);
            this.btnSensorServer.TabIndex = 3;
            this.btnSensorServer.Text = "Sensor Server";
            this.btnSensorServer.UseVisualStyleBackColor = true;
            this.btnSensorServer.Click += new System.EventHandler(this.btnSensorServer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 55);
            this.button4.TabIndex = 2;
            this.button4.Text = "Road Display Messenger";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 55);
            this.button3.TabIndex = 1;
            this.button3.Text = "Camera Analyzer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(7, 95);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(187, 46);
            this.btnTableView.TabIndex = 2;
            this.btnTableView.Text = "Traffic Table";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnTrafficMap
            // 
            this.btnTrafficMap.Location = new System.Drawing.Point(7, 43);
            this.btnTrafficMap.Name = "btnTrafficMap";
            this.btnTrafficMap.Size = new System.Drawing.Size(187, 46);
            this.btnTrafficMap.TabIndex = 0;
            this.btnTrafficMap.Text = "Traffic Map ";
            this.btnTrafficMap.UseVisualStyleBackColor = true;
            this.btnTrafficMap.Click += new System.EventHandler(this.btnTrafficMap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.sensorToolStripMenuItem,
            this.roadDisplaysToolStripMenuItem,
            this.roadsToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cam_Manage,
            this.analyzerToolStripMenuItem,
            this.connectionsToolStripMenuItem2,
            this.xToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // Menu_Cam_Manage
            // 
            this.Menu_Cam_Manage.Name = "Menu_Cam_Manage";
            this.Menu_Cam_Manage.Size = new System.Drawing.Size(187, 22);
            this.Menu_Cam_Manage.Text = "Manage Connections";
            this.Menu_Cam_Manage.Click += new System.EventHandler(this.Menu_Cam_Manage_Click);
            // 
            // analyzerToolStripMenuItem
            // 
            this.analyzerToolStripMenuItem.Name = "analyzerToolStripMenuItem";
            this.analyzerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.analyzerToolStripMenuItem.Text = "Analyzer";
            // 
            // connectionsToolStripMenuItem2
            // 
            this.connectionsToolStripMenuItem2.Name = "connectionsToolStripMenuItem2";
            this.connectionsToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.connectionsToolStripMenuItem2.Text = "Connections";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.xToolStripMenuItem.Text = "x`";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageSensorsToolStripMenuItem,
            this.analyzerToolStripMenuItem1,
            this.connectionsToolStripMenuItem1});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // manageSensorsToolStripMenuItem
            // 
            this.manageSensorsToolStripMenuItem.Name = "manageSensorsToolStripMenuItem";
            this.manageSensorsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.manageSensorsToolStripMenuItem.Text = "Manage Sensors";
            this.manageSensorsToolStripMenuItem.Click += new System.EventHandler(this.manageSensorsToolStripMenuItem_Click);
            // 
            // analyzerToolStripMenuItem1
            // 
            this.analyzerToolStripMenuItem1.Name = "analyzerToolStripMenuItem1";
            this.analyzerToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.analyzerToolStripMenuItem1.Text = "Analyzer";
            // 
            // connectionsToolStripMenuItem1
            // 
            this.connectionsToolStripMenuItem1.Name = "connectionsToolStripMenuItem1";
            this.connectionsToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.connectionsToolStripMenuItem1.Text = "Connections";
            // 
            // roadDisplaysToolStripMenuItem
            // 
            this.roadDisplaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageConnectionsToolStripMenuItem,
            this.warningNotifierToolStripMenuItem});
            this.roadDisplaysToolStripMenuItem.Name = "roadDisplaysToolStripMenuItem";
            this.roadDisplaysToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.roadDisplaysToolStripMenuItem.Text = "Road Displays";
            // 
            // manageConnectionsToolStripMenuItem
            // 
            this.manageConnectionsToolStripMenuItem.Name = "manageConnectionsToolStripMenuItem";
            this.manageConnectionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.manageConnectionsToolStripMenuItem.Text = "Manage Connections";
            this.manageConnectionsToolStripMenuItem.Click += new System.EventHandler(this.manageConnectionsToolStripMenuItem_Click);
            // 
            // warningNotifierToolStripMenuItem
            // 
            this.warningNotifierToolStripMenuItem.Name = "warningNotifierToolStripMenuItem";
            this.warningNotifierToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.warningNotifierToolStripMenuItem.Text = "Warning/Notifier";
            // 
            // roadsToolStripMenuItem
            // 
            this.roadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_manage_road});
            this.roadsToolStripMenuItem.Name = "roadsToolStripMenuItem";
            this.roadsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.roadsToolStripMenuItem.Text = "Roads";
            // 
            // menu_manage_road
            // 
            this.menu_manage_road.Name = "menu_manage_road";
            this.menu_manage_road.Size = new System.Drawing.Size(117, 22);
            this.menu_manage_road.Text = "Manage";
            this.menu_manage_road.Click += new System.EventHandler(this.menu_manage_road_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripMenuItem,
            this.userCredentialToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // databaseConnectionToolStripMenuItem
            // 
            this.databaseConnectionToolStripMenuItem.Name = "databaseConnectionToolStripMenuItem";
            this.databaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.databaseConnectionToolStripMenuItem.Text = "Database Connection";
            // 
            // userCredentialToolStripMenuItem
            // 
            this.userCredentialToolStripMenuItem.Name = "userCredentialToolStripMenuItem";
            this.userCredentialToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.userCredentialToolStripMenuItem.Text = "User Credential";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.supportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(199, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(879, 600);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://thingsofthe.net", System.UriKind.Absolute);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.statusCamCount,
            this.toolStripStatusLabel3,
            this.statusSensorCount,
            this.toolStripStatusLabel4,
            this.statusRoadDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(199, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Connections:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel2.Text = "Cameras:";
            // 
            // statusCamCount
            // 
            this.statusCamCount.Name = "statusCamCount";
            this.statusCamCount.Size = new System.Drawing.Size(13, 17);
            this.statusCamCount.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel3.Text = "Sensors:";
            // 
            // statusSensorCount
            // 
            this.statusSensorCount.Name = "statusSensorCount";
            this.statusSensorCount.Size = new System.Drawing.Size(13, 17);
            this.statusSensorCount.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel4.Text = "Road Displays:";
            // 
            // statusRoadDisplay
            // 
            this.statusRoadDisplay.Name = "statusRoadDisplay";
            this.statusRoadDisplay.Size = new System.Drawing.Size(13, 17);
            this.statusRoadDisplay.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 624);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MMDA Metrobase";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cam_Manage;
        private System.Windows.Forms.ToolStripMenuItem analyzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSensorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roadDisplaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warningNotifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCredentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnTableView;
        private System.Windows.Forms.Button btnTrafficMap;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusCamCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusSensorCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel statusRoadDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSensorServer;
        private System.Windows.Forms.ToolStripMenuItem roadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_manage_road;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}