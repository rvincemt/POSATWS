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
namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
              DataSet ds = new DataSet();
    MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

    MySqlDataAdapter da = new MySqlDataAdapter();
    DataTable dt = new DataTable();
 

            int count = 0;
            try
            {
                
                cs.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from user where user=@username and password=@password;", cs);
                MySqlDataReader myreader;
                SelectCommand.Parameters.AddWithValue("@username", this.txtUser.Text);
                SelectCommand.Parameters.AddWithValue("@password", this.txtCode.Text);
               

                tsConStatus.Text = "Connected";
                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {
                    count = count + 1;
                   
                }

                if (count == 1)
                {
                    tsConStatus.Text = "Logged in";
                    MessageBox.Show("Welcome");
                    Form main = new Main();
                    main.Show();
                    this.Hide();

                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
