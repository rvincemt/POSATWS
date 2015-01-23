using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace trafficInfoDisplay
{
    class Logic
    {
        public MySqlConnection connectToDB(){
            string serverIP = Properties.Settings.Default.DBServerIP;
            string serverUID = Properties.Settings.Default.DBServerUID;
            string serverPWD = Properties.Settings.Default.DBServerPWD;
            string serverNAME = Properties.Settings.Default.DBServerName;

            MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");



            return cs;
        }

        public void getroadID()
        {
            string roadID = Properties.Settings.Default.RoadID;
            string roadID1 = "";
            string roadID2 = "";
            string roadID3 = "";
            string adID = "";

            try
            {

                connectToDB().Open();
                MySqlCommand selectCMD = new MySqlCommand("SELECT roadID1, roadID2, roadID3, adID FROM rdSetup WHERE roadID = "+roadID +";", connectToDB());
                MySqlDataReader myreader;

                myreader = selectCMD.ExecuteReader();
                while (myreader.Read())
                {
                    roadID1 = myreader[0].ToString();
                    roadID2 = myreader[1].ToString();
                    roadID3 = myreader[2].ToString();
                    adID = myreader[3].ToString();
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
        }
        public List<string> roadstat1 = new List<string>();
        public List<string> roadstat2 = new List<string>();
        public List<string> roadstat3 = new List<string>();

        public void getSpecificTraffic()
        {
            //retrieveWeatherUpdates()
            //if(dbConnect=fail) {allValues = "e")

            string roadID1 = Properties.Settings.Default.roadID1;
            string roadID2 = Properties.Settings.Default.roadID2;
            string roadID3 = Properties.Settings.Default.roadID3;
            //List<string> roadstat1 = new List<string>

            //roadID1
            try
            {

                connectToDB().Open();

                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel, advID*notsure* WHERE roadID = "+ roadID1 + ";", connectToDB());
                MySqlDataReader rdrRoadID1;

                rdrRoadID1 = selectCMD.ExecuteReader();
                while (rdrRoadID1.Read())
                {
                    roadstat1.Add(rdrRoadID1[0].ToString());
                    roadstat1.Add(rdrRoadID1[1].ToString());
                    roadstat1.Add(rdrRoadID1[2].ToString());
                    roadstat1.Add(rdrRoadID1[3].ToString());
                  rdrRoadID1.Close();

                    

                }
               

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            //roadID2
            try
            {

                connectToDB().Open();

                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel, advID*notsure* WHERE roadID = " + roadID2 + ";", connectToDB());
                MySqlDataReader rdrRoadID2;

                rdrRoadID2 = selectCMD.ExecuteReader();
                while (rdrRoadID2.Read())
                {
                    roadstat2.Add(rdrRoadID2[0].ToString());
                    roadstat2.Add(rdrRoadID2[1].ToString());
                    roadstat2.Add(rdrRoadID2[2].ToString());
                    roadstat2.Add(rdrRoadID2[3].ToString());
                    rdrRoadID2.Close();



                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            //roadID3
            try
            {

                connectToDB().Open();

                MySqlCommand selectCMD = new MySqlCommand("SELECT trafficStatus, weatherStat, floodLevel, advID*notsure* WHERE roadID = " + roadID3 + ";", connectToDB());
                MySqlDataReader rdrRoadID3;

                rdrRoadID3 = selectCMD.ExecuteReader();
                while (rdrRoadID3.Read())
                {
                    roadstat3.Add(rdrRoadID3[0].ToString());
                    roadstat3.Add(rdrRoadID3[1].ToString());
                    roadstat3.Add(rdrRoadID3[2].ToString());
                    roadstat3.Add(rdrRoadID3[3].ToString());
                    rdrRoadID3.Close();



                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

        public string setTrafficStats(string type, string source)
        {
            //TODO: ALGO
            String result = "";
            //if type =="trafficstat" 
                //if source == "roadID*n*
                    //result == value;
            return result;
        }
    }
}
