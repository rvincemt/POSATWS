using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
            public Main()
        {
       
            InitializeComponent();
        }

        private void manageConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Do code
        }

        private void Menu_Cam_Manage_Click(object sender, EventArgs e)
        {
            Form camMan = new CameraManage();
            camMan.Show();
        }

        private void manageSensorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SensorManage = new SensorManage();
            SensorManage.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                  break;
            }
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("Exiting the program");
                Login.ActiveForm.Close();
                this.Close();
            }


            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                // Autosave and clear up ressources
                MessageBox.Show("Exiting the program");
                Login.ActiveForm.Close();
                this.Close();
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void btnTrafficMap_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("http://127.0.0.1/mmdametrobase/");
            webBrowser1.Url = url;
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("http://mmdatraffic.interaksyon.com/line-view-edsa.php");
            webBrowser1.Url = url;
                    }

        private void btnSensorServer_Click(object sender, EventArgs e)
        {
            Form sense = new WindowsFormApplication1.SensorServer();
            Form sense2 = new WindowsFormApplication1.SensorServer();
            sense.Show();
            sense2.Show();
        }

        private void menu_manage_road_Click(object sender, EventArgs e)
        {
            Form roadman = new RoadManage();
            roadman.Show();
        }
        private void exit()
        {
            this.Close();
            Login.ActiveForm.Close();
        }

        private void btnFloodMap_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("http://127.0.0.1/mmdametrobase/");
            webBrowser1.Url = url;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form CAM = new CameraAnalysisModule();
            CAM.Show();
            
        }
             
        
    }
}