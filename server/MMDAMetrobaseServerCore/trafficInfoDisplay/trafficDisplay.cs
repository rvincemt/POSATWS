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
    public partial class trafficDisplay : Form
    {
        public trafficDisplay()
        {
            InitializeComponent();
        }

        private void trafficInfoDisplay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mmdametrobaseDataSet.rdlive' table. You can move, or remove it, as needed.
           //d this.rdliveTableAdapter.Fill(this.mmdametrobaseDataSet.rdlive);

        }

        public void changeLocationName(String roadName)
        {

            
        }
        

        
    }
}
