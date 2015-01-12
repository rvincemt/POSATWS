using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace WindowsFormsApplication1
{
    public partial class CameraAnalysis : Form
    {
        public String vidFileName = "";
   
        private bool captureInProgress;
        Image<Bgr, Byte> frame;
        private bool _captureInProgress;
        private Capture _capture = null;
        double webcam_frm_cnt = 0;
        double FrameRate = 0;
        double TotalFrames = 0;
        double Framesno = 0;
        double codec_double = 0;        
        public CameraAnalysis()
        {
            InitializeComponent();
          
        }
        //global var
    
        private void CameraAnalysis_Load(object sender, EventArgs e)
        {

        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                Framesno = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                frame = _capture.QueryFrame();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnTestCam_Click(object sender, EventArgs e)
        {
            
        }
        private void ReleaseData()
        {
            if (_capture != null)
               _capture.Dispose();
        }

        private void btnOpenVid_Click(object sender, EventArgs e)
        {
            ofdVideo.Filter = "MP4|*.mp4";
            ofdVideo.FileName = "";
            if (ofdVideo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _capture = null;
                    _capture = new Capture(ofdVideo.FileName);
                  
                    Application.Idle += ProcessFrame;
                   
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
             
        }


    }   
}
