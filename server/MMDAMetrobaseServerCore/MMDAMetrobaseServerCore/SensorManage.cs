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
    public partial class SensorManage : Form
    {
        public SensorManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'mmdametrobaseDataSet1.sensor' table. You can move, or remove it, as needed.
//this.sensorTableAdapter1.Fill(this.mmdametrobaseDataSet1.sensor);
// TODO: This line of code loads data into the 'mmdametrobaseDataSet1.roads' table. You can move, or remove it, as needed.
this.roadsTableAdapter.Fill(this.mmdametrobaseDataSet1.roads);
// TODO: This line of code loads data into the 'mmdametrobaseDataSet.sensor' table. You can move, or remove it, as needed.
this.sensorTableAdapter.Fill(this.mmdametrobaseDataSet.sensor);
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
            txtSenID.Text = "";
            txtGsmNum.Text = "";
           
            txtRoadID.Text = "";

        }
        private void unlockFields()
        {
            txtSenID.Enabled = true;
            txtGsmNum.Enabled = true;
           
            txtRoadID.Enabled = true;
        }
        private void lockFields()
        {
            txtSenID.Enabled = false;
            txtGsmNum.Enabled = false;
            
            txtRoadID.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editData();
            txtSenID.Enabled = false;
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
 
            if(txtSenID.Enabled==false){


                try
                {

                    cs.Open();

                    MySqlCommand UpdateCommand = new MySqlCommand("UPDATE sensor SET sensorID=@sensorID, gsmNum= @gsmNum, roadID=@roadID WHERE sensorID=@sensorID;", cs); 
                    MySqlDataReader myreader;
                    UpdateCommand.Parameters.AddWithValue("@sensorID", this.txtSenID.Text);
                    UpdateCommand.Parameters.AddWithValue("@gsmNum", this.txtGsmNum.Text);
                    UpdateCommand.Parameters.AddWithValue("@roadID", this.txtRoadID.Text);
                   

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

                    MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO sensor (sensorID, gsmNum, roadID) VALUES (@senID, @gsmNum, @roadID);", cs); 
                    MySqlDataReader myreader;
                    InsertCommand.Parameters.AddWithValue("@senID", this.txtSenID.Text);
                    InsertCommand.Parameters.AddWithValue("@gsmNum", this.txtGsmNum.Text);
                    InsertCommand.Parameters.AddWithValue("@roadID", this.txtRoadID.Text);
                    

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
            SensorManage reload = new SensorManage();
            this.Close();
            reload.Show();
           
        }

        private void btnTestCam_Click(object sender, EventArgs e)
        {
            //TODO: Camera test funct by IP
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void grpAddEditDel_Enter(object sender, EventArgs e)
        {

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
                MySqlCommand SelectCommand = new MySqlCommand("DELETE FROM sensor WHERE sensorID=@roadID;", cs);
                MySqlDataReader myreader;
                SelectCommand.Parameters.AddWithValue("@roadID", this.txtSenID.Text);

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
            SensorManage reload = new SensorManage();
            this.Close();
            reload.Show();
           
        }
        }
    
}
