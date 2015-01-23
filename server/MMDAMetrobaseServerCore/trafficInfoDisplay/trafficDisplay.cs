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
using System.Diagnostics;
namespace trafficInfoDisplay
{
    public partial class trafficDisplay : Form
    {
        public trafficDisplay()
        {
            InitializeComponent();
        }
        public string[] roadstat1 = new string[5];
        public string[] roadstat2 = new string[5];
        public string[] roadstat3 = new string[5];
        public string proadID1 = "";
        public string proadID2 = "";
        public string proadID3 = "";
        private void trafficInfoDisplay_Load(object sender, EventArgs e)
        {
            timeTraffic.Start();

        }

        public void changeLocationName(String roadName)
        {

            
        }

        public void timeTraffic_Tick(object sender, EventArgs e)
        {
           
            getroadID();
            getSpecificTraffic();
            

            lblVal1.Text = Properties.Settings.Default.trafficStat1;
            lblVal2.Text = Properties.Settings.Default.trafficStat2;
            lblVal3.Text = Properties.Settings.Default.trafficStat3;

        }
      

        private void getroadID()
        {
            string roadID = Properties.Settings.Default.RoadID;
            string roadID1 = "";
            string roadID2 = "";
            string roadID3 = "";
            string adID = "";
            string serverIP = Properties.Settings.Default.DBServerIP;
            string serverUID = Properties.Settings.Default.DBServerUID;
            string serverPWD = Properties.Settings.Default.DBServerPWD;
            string serverNAME = Properties.Settings.Default.DBServerName;

            MySqlConnection cs = new MySqlConnection(@"SERVER=" + serverIP + ";username=" + serverUID + ";password=" + serverPWD + ";Allow Zero Datetime=true; Initial Catalog =" + serverNAME + "");

            try
            {

               
                
                
                MySqlCommand selectCMD = new MySqlCommand("SELECT roadID1, roadID2, roadID3, adID FROM rdsetup  WHERE roadID = @roadID;", cs);
                selectCMD.Parameters.AddWithValue("@roadID", roadID);
                
                selectCMD.Connection = cs;

                MySqlDataReader myreader;
                cs.Open();
                myreader = selectCMD.ExecuteReader();
                while (myreader.Read())
                {
                    roadID1 = myreader[0].ToString();
                    roadID2 = myreader[1].ToString();
                    roadID3 = myreader[2].ToString();
                    adID = myreader[3].ToString();
                    proadID1 = myreader[0].ToString();
                    proadID2 = myreader[1].ToString();
                    proadID3 = myreader[2].ToString();
                    myreader.Close();

                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            Properties.Settings.Default.roadID1 = roadID1;
            Properties.Settings.Default.roadID2 = roadID2;
            Properties.Settings.Default.roadID3 = roadID3;
            cs.Close();
        }
       
        public void getSpecificTraffic()
        {
            //retrieveWeatherUpdates()
            //if(dbConnect=fail) {allValues = "e")

            string roadID1 = Properties.Settings.Default.roadID1;
            string roadID2 = Properties.Settings.Default.roadID2;
            string roadID3 = Properties.Settings.Default.roadID3;
            //List<string> roadstat1 = new List<string>
            string serverIP = Properties.Settings.Default.DBServerIP;
            string serverUID = Properties.Settings.Default.DBServerUID;
            string serverPWD = Properties.Settings.Default.DBServerPWD;
            string serverNAME = Properties.Settings.Default.DBServerName;

            MySqlConnection cs1 = new MySqlConnection(@"SERVER="+serverIP+";username="+serverUID+";password="+serverPWD+";Allow Zero Datetime=true; Initial Catalog ="+serverNAME+"");

            //roadID1
            try
            {

                cs1.Open();

                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel FROM roadlive WHERE roadID = @roadID;", cs1);
                selectCMD.Parameters.AddWithValue("@roadID", roadID1);
                MySqlDataReader rdrRoadID1;

                rdrRoadID1 = selectCMD.ExecuteReader();
                while (rdrRoadID1.Read())
                {
                    roadstat1[0] = rdrRoadID1[0].ToString();
                    roadstat1[1] = rdrRoadID1[1].ToString();
                    roadstat1[2] = rdrRoadID1[2].ToString();
                    
                    Properties.Settings.Default.trafficStat1 = roadstat1[0];
                    Properties.Settings.Default.weatherStat1 = roadstat1[1];
                    rdrRoadID1.Close();



                }
                

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            cs1.Close();
            //roadID2
            try
            {


                cs1.Open();
                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel FROM roadlive WHERE roadID = @roadID;", cs1);
                selectCMD.Parameters.AddWithValue("@roadID", roadID2); MySqlDataReader rdrRoadID2;

                rdrRoadID2 = selectCMD.ExecuteReader();
                while (rdrRoadID2.Read())
                {
                     roadstat2[0] = rdrRoadID2[0].ToString();
                    roadstat2[1] = rdrRoadID2[1].ToString();
                    roadstat2[2] = rdrRoadID2[2].ToString();
                    

                    Properties.Settings.Default.trafficStat2 = roadstat2[0];
                    Properties.Settings.Default.weatherStat2 = roadstat2[1];
                    rdrRoadID2.Close();



                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            cs1.Close();

            //roadID3
            try
            {


                cs1.Open();
                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel FROM roadlive WHERE roadID =@roadID;", cs1);
                selectCMD.Parameters.AddWithValue("@roadID", roadID3); MySqlDataReader rdrRoadID3;

                rdrRoadID3 = selectCMD.ExecuteReader();
                while (rdrRoadID3.Read())
                {
                     roadstat3[0] = rdrRoadID3[0].ToString();
                    roadstat3[1] = rdrRoadID3[1].ToString();
                    roadstat3[2] = rdrRoadID3[2].ToString();
                    
                    Properties.Settings.Default.trafficStat3 = roadstat3[0];
                    Properties.Settings.Default.weatherStat3 = roadstat3[1];
                    rdrRoadID3.Close();
                    

                }
               

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            cs1.Close();

        }

       // public string setTrafficStats(string type, string source)
        //{
            //TODO: ALGO
            /*
            if (type == "traffic")
            {
                if (source == "road1")
                {
                    
                    return roadstat1[0].ToString();
                }
                if (source == "road2")
                {
                    getroadID();
                    getSpecificTraffic();
                    return roadstat2[0].ToString();
                }
                if (source == "road3")
                {
                    getroadID();
                    getSpecificTraffic();
                    return roadstat3[0].ToString();
                }
                else
                {
                    return "e";
                }
            }
            if (type == "weather")
            {
                if (source == "road1")
                {
                    getroadID();
                    getSpecificTraffic();
                    return roadstat1[1].ToString();
                }
                if (source == "road2")
                {
                    getroadID();
                    getSpecificTraffic();
                    return roadstat2[1].ToString();
                }
                if (source == "road3")
                {
                    getroadID();
                    getSpecificTraffic();
                    return roadstat3[1].ToString();
                }
                else
                {
                    return "e";
                }
                
            }
            else
            {
                return "E";
            }
            */
        //}
        
        
    }
}
