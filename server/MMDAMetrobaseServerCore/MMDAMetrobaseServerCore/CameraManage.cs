using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Text.RegularExpressions;
namespace WindowsFormsApplication1
{
    public partial class CameraManage : Form
    {
        public CameraManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mmdametrobaseDataSet2.camera' table. You can move, or remove it, as needed.
            this.cameraTableAdapter1.Fill(this.mmdametrobaseDataSet2.camera);
            // TODO: This line of code loads data into the 'mmdametrobaseDataSet1.camera' table. You can move, or remove it, as needed.
            //this.cameraTableAdapter.Fill(this.mmdametrobaseDataSet1.camera);
            // TODO: This line of code loads data into the 'mmdametrobaseDataSet.roads' table. You can move, or remove it, as needed.
            //this.roadsTableAdapter.Fill(this.mmdametrobaseDataSet.roads);
            lockFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            editData();
            clearFields();

        }
        private void editData()
        {
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDel.Visible = false;
            btnTestCam.Visible = false;
            btnCancel.Visible = true;
            btnClear.Visible = true;
            btnSave.Visible = true;
            unlockFields();
        }
        private void viewData()
        {
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDel.Visible = true;
            btnTestCam.Visible = true;
            btnCancel.Visible = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            lockFields();
        }
        private void clearFields()
        {
            txtCamID.Text = "";
            txtCamIP.Text = "";
            txtCamType.Text = "";
            txtRoadID.Text = "";

        }
        private void unlockFields()
        {
            txtCamID.Enabled = true;
            txtCamIP.Enabled = true;
            txtCamType.Enabled = true;
            txtRoadID.Enabled = true;
        }
        private void lockFields()
        {
            txtCamID.Enabled = false;
            txtCamIP.Enabled = false;
            txtCamType.Enabled = false;
            txtRoadID.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editData();
            txtCamID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewData();
           
            CameraManage cam = new CameraManage();
            this.Dispose();
            cam.Show();
            viewData();
            
        }
        public bool IsValidIP(string addr)
        {
            
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.
([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            
            Regex check = new Regex(pattern);
            
            bool valid = false;
           
            if (addr == "")
            {
              
                valid = false;
            }
            else
            {
               
               
                valid = check.IsMatch(addr, 0);
            }
          
            return valid;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
    MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

    MySqlDataAdapter da = new MySqlDataAdapter();
    DataTable dt = new DataTable();
 
            if(txtCamID.Enabled==false){


                try
                {

                    cs.Open();

                    MySqlCommand UpdateCommand = new MySqlCommand("UPDATE camera SET camIP=@camIP, roadID=@roadID, camType=@camType WHERE cameraID=@camID;", cs); 
                    MySqlDataReader myreader;
                    UpdateCommand.Parameters.AddWithValue("@camID", this.txtCamID.Text);
                    UpdateCommand.Parameters.AddWithValue("@camIP", this.txtCamIP.Text);
                    UpdateCommand.Parameters.AddWithValue("@roadID", this.txtRoadID.Text);
                    UpdateCommand.Parameters.AddWithValue("@camType", this.txtCamType.Text);

                    //tsConStatus.Text = "Connected";
                    myreader = UpdateCommand.ExecuteReader();
                    MessageBox.Show("Row Updated");
                    goto Finish;

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                
            }
            else
            {
                try
                {

                    cs.Open();

                    MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO camera (cameraID, camIP, roadID, camType) VALUES (@camID, @camIP, @roadID, @camType);", cs); 
                    MySqlDataReader myreader;
                    InsertCommand.Parameters.AddWithValue("@camID", this.txtCamID.Text);
                    InsertCommand.Parameters.AddWithValue("@camIP", this.txtCamIP.Text);
                    InsertCommand.Parameters.AddWithValue("@roadID", this.txtRoadID.Text);
                    InsertCommand.Parameters.AddWithValue("@camType", this.txtCamType.Text);

                    //tsConStatus.Text = "Connected";
                    myreader = InsertCommand.ExecuteReader();
                    MessageBox.Show("Data added");
                    goto Finish;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
          Finish:
            CameraManage reload = new CameraManage();
            this.Close();
            reload.Show();
           
        }

        private void btnTestCam_Click(object sender, EventArgs e)
        {
            //TODO: Camera test funct by IP
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();


            try
            {

                cs.Open();
                MySqlCommand SelectCommand = new MySqlCommand("DELETE FROM camera WHERE cameraID=@roadID;", cs);
                MySqlDataReader myreader;
                SelectCommand.Parameters.AddWithValue("@roadID", this.txtCamID.Text);

                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {
                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Record Deleted!");
            CameraManage reload = new CameraManage();
            this.Close();
            reload.Show();
           
        }
        }
    
}
