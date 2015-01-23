using System.Diagnostics;

namespace roadDisplay_WPF.dataAccess
{
    internal class mySQLConnect
    {
        public void connectToServer()
        {
            string server = Properties.Settings.Default.serverIP.ToString();
            string uid = Properties.Settings.Default.serverUID.ToString();
            string pwd = Properties.Settings.Default.serverPWD.ToString();
            string db = Properties.Settings.Default.serverDB.ToString();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string connString;
            connString = "server="+server +";uid="+uid + ";pwd="+pwd+";database=+"+db+";";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                Debug.WriteLine("Connected!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void updateNotification1()
        {
           

        }

    }
}