using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Timers;
namespace WindowsFormApplication1
{
    public partial class SensorServer : Form
    {
        private AutoResetEvent receiveNow;
        private SerialPort port;

        public SensorServer()
        {
            InitializeComponent();
            port = null;
            receiveNow = new AutoResetEvent(false);
           
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Get and verify port name
            string portName = cboPort.Text;
            if (portName.Length == 0)
            {
                MessageBox.Show(this, "You must enter a port name.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblReady.Text = "No";
                btnReceivingMode.Enabled = false;
                btnReceivingMode.Visible = false;
                return;
                
            }

            lvwMessages.Items.Clear();
            Update();

            // Set up the phone and read the messages
            ShortMessageCollection messages = null;
            try
            {
                this.port = OpenPort(portName);
                Cursor.Current = Cursors.WaitCursor;
                // Check connection
                ExecCommand("AT", 300, "No phone connected at " + portName + ".");
                // Use message format "Text mode"
                ExecCommand("AT+CMGF=1", 300, "Failed to set message format.");
                // Use character set "ISO 8859-1"
                //ExecCommand("AT+CSCS=\"8859-1\"", 300, "Failed to set character set.");
                // Select SIM storage
                ExecCommand("AT+CPMS=\"SM\"", 300, "Failed to select message storage.");
                // Read the messages
                string input = ExecCommand("AT+CMGL=\"ALL\"", 5000, "Failed to read the messages.");
                messages = ParseMessages(input);
                Cursor.Current = Cursors.Default;
                lblReady.Text = "Yes";
                btnReceivingMode.Visible = true;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblReady.Text = "No";
                btnReceivingMode.Visible = false;

                return;
               
            }
            finally
            {
                if (port != null)
                {
                    ClosePort(this.port);
                    this.port = null;
                    lblStat.Text = "Ready";
                    btnReceivingMode.Visible = true;
                }
            }

            if (messages != null)
                DisplayMessages(messages);
        }
        private void reloadMessages()
        {
            // Get and verify port name
            string portName = cboPort.Text;
            if (portName.Length == 0)
            {
                MessageBox.Show(this, "You must enter a port name.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lvwMessages.Items.Clear();
            Update();

            // Set up the phone and read the messages
            ShortMessageCollection messages = null;
            try
            {
                this.port = OpenPort(portName);
                Cursor.Current = Cursors.WaitCursor;
                // Check connection
                ExecCommand("AT", 300, "No phone connected at " + portName + ".");
                // Use message format "Text mode"
                ExecCommand("AT+CMGF=1", 300, "Failed to set message format.");
                // Use character set "ISO 8859-1"
                //ExecCommand("AT+CSCS=\"8859-1\"", 300, "Failed to set character set.");
                // Select SIM storage
                ExecCommand("AT+CPMS=\"SM\"", 300, "Failed to select message storage.");
                // Read the messages
                string input = ExecCommand("AT+CMGL=\"ALL\"", 5000, "Failed to read the messages.");
                messages = ParseMessages(input);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (port != null)
                {
                    ClosePort(this.port);
                    this.port = null;
                }
            }

            if (messages != null)
                DisplayMessages(messages);
        }

        private void DisplayMessages(ShortMessageCollection messages)
        {
            lvwMessages.BeginUpdate();
            foreach (ShortMessage msg in messages)
            {
                ListViewItem item = new ListViewItem(new string[] { msg.Sender, msg.Message });
                item.Tag = msg;
                lvwMessages.Items.Add(item);
            }
            lvwMessages.EndUpdate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            colMessage.Width = -2;
        }

        private ShortMessageCollection ParseMessages(string input)
        {
            ShortMessageCollection messages = new ShortMessageCollection();
            Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
            Match m = r.Match(input);
            while (m.Success)
            {
                ShortMessage msg = new ShortMessage();
                msg.Index = int.Parse(m.Groups[1].Value);
                msg.Status = m.Groups[2].Value;
                msg.Sender = m.Groups[3].Value;
                msg.Alphabet = m.Groups[4].Value;
                msg.Sent = m.Groups[5].Value;
                msg.Message = m.Groups[6].Value;
                messages.Add(msg);
                

                //SQL

                DataSet ds = new DataSet();
                MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                //Search for duplicates
                int count = 0;
                try
                {

                    cs.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select * from sensormessage where smsSender=@sender and smsTime=@time;", cs);
                    MySqlDataReader myreader;
                    SelectCommand.Parameters.AddWithValue("@sender", msg.Sender);
                    SelectCommand.Parameters.AddWithValue("@time", msg.Sent);


                    
                    myreader = SelectCommand.ExecuteReader();
                    
                    while (myreader.Read())
                    {
                        count = count + 1;

                    }

                    if (count < 1 )
                    {
                        try
                        {
                            cs.Close();
                            cs.Open();
                            MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO sensormessage (smsSender, smsTime, smsMessage) VALUES (@sender, @time, @messages);", cs);
                            MySqlDataReader myreader1;
                            InsertCommand.Parameters.AddWithValue("@sender", msg.Sender);
                            InsertCommand.Parameters.AddWithValue("@time", msg.Sent);
                            InsertCommand.Parameters.AddWithValue("@messages", msg.Message);


                            //tsConStatus.Text = "Connected";
                            myreader1 = InsertCommand.ExecuteReader();
                            MessageBox.Show("Data added");

                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
              

               

                
                m = m.NextMatch();
            }

            return messages;
        }

        #region Communication
        private SerialPort OpenPort(string portName)
        {
            SerialPort port = new SerialPort();
            port.PortName = portName;
            port.BaudRate = 19200;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.Parity = Parity.None;
            port.ReadTimeout = 300;
            port.WriteTimeout = 300;
            port.Encoding = Encoding.GetEncoding("iso-8859-1");
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            port.DtrEnable = true;
            port.RtsEnable = true;
            return port;
        }

        private void ClosePort(SerialPort port)
        {
            port.Close();
            port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Chars)
                receiveNow.Set();
        }

        private string ReadResponse(int timeout)
        {
            string buffer = string.Empty;
            do
            {
                if (receiveNow.WaitOne(timeout, false))
                {
                    string t = port.ReadExisting();
                    buffer += t;
                }
                else
                {
                    if (buffer.Length > 0)
                        throw new ApplicationException("Response received is incomplete.");
                    else
                        throw new ApplicationException("No data received from phone.");
                }
            }
            while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\nERROR\r\n"));
            return buffer;
        }

        private string ExecCommand(string command, int responseTimeout, string errorMessage)
        {
            try
            {
                port.DiscardOutBuffer();
                port.DiscardInBuffer();
                receiveNow.Reset();
                port.Write(command + "\r");

                string input = ReadResponse(responseTimeout);
                if ((input.Length == 0) || (!input.EndsWith("\r\nOK\r\n")))
                    throw new ApplicationException("No success message was received.");
                return input;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(errorMessage, ex);
            }
        }
        #endregion

        private void SensorServer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sensorUpdate_data.sensorupdates' table. You can move, or remove it, as needed.
            this.sensorupdatesTableAdapter.Fill(this.sensorUpdate_data.sensorupdates);

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
        static System.Timers.Timer _timer;

        private void btnReceivingMode_Click(object sender, EventArgs e)
        {

            if (lblStat.Text == "Automatic" & lblReady.Text=="Yes")
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            
        }
    
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblStat.Text = "Manual";
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblStat.Text = "Auto";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblStat.Text == "Auto")
            {
                reloadMessages();
                parse();
            }
            else
            {

            }
            if (lblParse.Text == "Yes")
            {
                
            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnParse_Click(object sender, EventArgs e)
        {

            parse();
        }

        
        private void parse()
        {
            DataSet ds = new DataSet();
            MySqlConnection cs = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();


            int countnew = 0;

            try
            {

                cs.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select distinct smssender from sensormessage;", cs);
                MySqlDataReader myreader;


                myreader = SelectCommand.ExecuteReader();
                while (myreader.Read())
                {
                    
                    countnew = countnew + 1;

                }
                

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            int recent = 0;
            string[] gsmnum = new string[countnew];
            string[] gsmmsg = new string[countnew];
            //DO create a loop and  SELECT smsmessage FROM sensormessage where smssender = "smssender[x]" ORDER BY smstime DESC LIMIT 1
            //DO get result of the above message and update sensorupdates where smssender = smssender[x]
            DataSet ds_getsender = new DataSet();
            MySqlConnection cs_getsender = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

            MySqlDataAdapter da_getsender = new MySqlDataAdapter();
            DataTable dt_getsender = new DataTable();


            try
            {

                cs_getsender.Open();
                MySqlCommand SelectCommand_getsender = new MySqlCommand("select distinct smsSender from sensormessage;", cs_getsender);
                MySqlDataReader myreader_getsender;


                myreader_getsender = SelectCommand_getsender.ExecuteReader();
                while (myreader_getsender.Read())
                {
                    gsmnum[recent] = myreader_getsender.GetString("smsSender");
                    //GET messsage where smssender = gsmnum[count]

                    DataSet ds_getmsg = new DataSet();
                    MySqlConnection cs_getmsg = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");

                    MySqlDataAdapter da_getmsg = new MySqlDataAdapter();
                    DataTable dt_getmsg = new DataTable();



                    try
                    {

                        cs_getmsg.Open();
                        MySqlCommand SelectCommand_getmsg = new MySqlCommand("select smsMessage from sensormessage where smsSender = @smssender ORDER BY smstime DESC LIMIT 1;", cs_getmsg);
                        MySqlDataReader myreader_getmsg;
                        SelectCommand_getmsg.Parameters.AddWithValue("@smssender", gsmnum[recent]);


                        myreader_getmsg = SelectCommand_getmsg.ExecuteReader();
                        while (myreader_getmsg.Read())
                        {
                            gsmmsg[recent] = myreader_getmsg.GetString("smsMessage");
                

                            DataSet ds_update = new DataSet();
                            MySqlConnection cs_update = new MySqlConnection(@"SERVER= 127.0.0.1;username=root;password=mmdametrobase;Allow Zero Datetime=true; Initial Catalog = mmdametrobase");
                            MySqlDataAdapter da_update = new MySqlDataAdapter();
                            DataTable dt_update = new DataTable();


                            try
                            {

                                cs_update.Open();

                                MySqlCommand UpdateCommand_update = new MySqlCommand("UPDATE sensorupdates SET sensorStatus=@sensorStat WHERE sender=@sender;", cs_update);
                                MySqlDataReader myreader_update;
                                UpdateCommand_update.Parameters.AddWithValue("@sensorStat", gsmmsg[recent]);
                                UpdateCommand_update.Parameters.AddWithValue("@sender", gsmnum[recent]);




                                myreader_update = UpdateCommand_update.ExecuteReader();
                                MessageBox.Show("Row Updated");
                                recent = recent + 1;

                            }
                            catch (MySql.Data.MySqlClient.MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }


                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    countnew = countnew + 1;

                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //DO select distinct smssender from smsmessage and put it in an array of smssender

           
        }
    }
}