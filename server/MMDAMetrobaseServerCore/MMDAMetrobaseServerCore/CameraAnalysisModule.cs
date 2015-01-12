﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace WindowsFormsApplication1
{
    public partial class CameraAnalysisModule : Form
    {
        private Capture _capture = null;
        Image<Bgr, Byte> frame;
             
        int cam = 0;
        double webcam_frm_cnt = 0;
        double FrameRate = 0;
        double TotalFrames = 0;
        double Framesno = 0;
        double codec_double = 0;
        

        public CameraAnalysisModule()
        {
            InitializeComponent();
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                Framesno = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                frame = _capture.QueryFrame();

                if (frame != null)
                {
                    imgboxPrev.Image = frame;
                    if (cam == 0)
                    {
                        Video_seek.Value = (int)(Framesno);
                        
                        double time_index = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_MSEC);
                        Time_Label.Text = "Time: " + TimeSpan.FromMilliseconds(time_index).ToString().Substring(0, 8);

                        double framenumber = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                        Frame_lbl.Text = "Frame: " + framenumber.ToString();

                        Thread.Sleep((int)(1000.0 / FrameRate));
                    }

                    if (cam == 1)
                    {
                        Frame_lbl.Text = "Frame: " + (webcam_frm_cnt++).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select Capture Method");
            }
            else
                if (button1.Text == "Play")
                {
                    #region cameracapture
                    if (comboBox1.Text == "Capture From Camera")
                    {
                        try
                        {
                            _capture = null;
                            _capture = new Capture(0);
                            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS, 30);
                            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240);
                            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320);

                            Time_Label.Text = "Time: ";
                            Codec_lbl.Text = "Codec: ";
                            Frame_lbl.Text = "Frame: ";

                            webcam_frm_cnt = 0;
                            cam = 1;
                            Video_seek.Value = 0;

                            Application.Idle += ProcessFrame;
                            button1.Text = "Stop";
                            comboBox1.Enabled = false;
                        }
                        catch (NullReferenceException excpt)
                        {
                            MessageBox.Show(excpt.Message);
                        }
                    }
                    #endregion cameracapture

                    #region filecapture
                    if (comboBox1.Text == "Capture From File")
                    {
                        openFileDialog1.Filter = "MP4|*.mp4";
                        openFileDialog1.FileName = "";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                _capture = null;
                                _capture = new Capture(openFileDialog1.FileName);
                                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240);
                                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320);
                                FrameRate = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
                                TotalFrames = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
                                codec_double = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FOURCC);
                                string s = new string(System.Text.Encoding.UTF8.GetString(BitConverter.GetBytes(Convert.ToUInt32(codec_double))).ToCharArray());
                                Codec_lbl.Text = "Codec: " + s;
                                cam = 0;
                                Video_seek.Minimum = 0;
                                Video_seek.Maximum = (int)TotalFrames - 1;
                                Application.Idle += ProcessFrame;
                                button1.Text = "Stop";
                                comboBox1.Enabled = false;
                            }
                            catch (NullReferenceException excpt)
                            {
                                MessageBox.Show(excpt.Message);
                            }
                        }
                    }
                    #endregion filecapture
                }
                else
                    #region stopcapture
                    if (button1.Text == "Stop")
                    {
                        _capture.Stop();

                        Application.Idle -= ProcessFrame;
                        ReleaseData();
                        button1.Text = "Play";
                        comboBox1.Enabled = true;                        
                       
                        if (cam == 1)
                        {
                            _capture.Dispose();
                            cam = 0;
                        }
                    }
                    #endregion stopcapture
        }

        private void Video_seek_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
