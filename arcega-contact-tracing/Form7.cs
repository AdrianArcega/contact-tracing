using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.IO;

namespace arcega_contact_tracing
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterCollection;
        VideoCaptureDevice videoCapture;


        private void form7Load(object sender, EventArgs e)
        {
            filterCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterCollection)
                cboxCamera.Items.Add(filterInfo.Name);
            cboxCamera.SelectedIndex = 0;
        }
        private void btnRunClick(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice(filterCollection[cboxCamera.SelectedIndex].MonikerString);
            videoCapture.NewFrame += CaptureDevice_NewFrame;
            videoCapture.Start();
            timer1.Start();
        }
        private void formScannerClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture.IsRunning)
                videoCapture.Stop();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbxCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timerQRScannerTick(object sender, EventArgs e)
        {
            if (picbxCam.Image !=null)
            {
                BarcodeReader QRReader = new BarcodeReader();
                Result result = QRReader.Decode((Bitmap)picbxCam.Image);
                if (result != null)
                {
                    timer1.Stop();
                    MessageBox.Show("Your response have been recorded, Thank you! , Recorded");
                    string data = result.ToString();
                    StringBuilder build = new StringBuilder(data);
                    data = build.ToString();
                    string showData = data;
                    StreamWriter file = new StreamWriter(@"C:\C:\Users\acer\Desktop\contact tracing demo\contact tracing list\" + txtbxFullName1.Text + " " + txtbxDateOfVisit1.Text + ".txt", true);
                    file.Write(showData);
                    file.Close();
                    if (videoCapture.IsRunning)
                        videoCapture.Stop();
                }
            }

        }
    }
}
