using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data;
namespace roadDisplay_WPF.dataAccess
{
    class mySQLConnect
    {
        public void connectToServer(){

         MySql.Data.MySqlClient.MySqlConnection conn;
         string myConnectionString;
         myConnectionString = "server=127.0.0.1;uid=root;" +"pwd=12345;database=test;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                Debug.WriteLine("Connected!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

    }
}
