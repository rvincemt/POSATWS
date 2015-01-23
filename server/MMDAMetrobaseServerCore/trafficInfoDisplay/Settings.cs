using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafficInfoDisplay
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBServerIP = txtDBServer.Text;
            Properties.Settings.Default.DBServerName = txtDBName.Text;
            Properties.Settings.Default.DBServerUID = txtDBName.Text;
            Properties.Settings.Default.DBServerPWD = txtDBPWD.Text;


        }

        private void txtDevSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DevID = txtDevID.Text;
            Properties.Settings.Default.RoadID = txtDEVRID.Text;
            Properties.Settings.Default.TSAPI = txtDevTSAPI.Text;
            Properties.Settings.Default.NotificationInterval = txtDevNotInt.Text;
            Properties.Settings.Default.AdInterval = txtDevAdInt.Text;
            Properties.Settings.Default.AdvisoryInterval = txtDevAdvInt.Text;

        }
    }
}
