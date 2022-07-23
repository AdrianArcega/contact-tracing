using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
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
        VideoCaptureDevice videoDevice;


        private void form7Load(object sender, EventArgs e)
        {
            filterCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterCollection)
                cboxCamera.Items.Add(filterInfo.Name);
            cboxCamera.SelectedIndex = 0;
        }
        private void btnRunClick(object sender, EventArgs e)
        {
            videoDevice = new VideoCaptureDevice(filterCollection[cboxCamera.SelectedIndex].MonikerString);
            videoDevice.NewFrame += CaptureDevice_NewFrame;
            videoDevice.Start();
            timerQR.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbxCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void formScannerClosing(object sender, FormClosingEventArgs e)
        {
            if (videoDevice.IsRunning)
                videoDevice.Stop();
        }

        private void timerQRTick(object sender, EventArgs e)
        {
            if (picbxCam.Image != null)
            {
                BarcodeReader QRReader = new BarcodeReader();
                Result result = QRReader.Decode((Bitmap)picbxCam.Image);
                if (result != null)
                {
                    timerQR.Stop();
                    string data = result.ToString();
                    StringBuilder build = new StringBuilder(data);
                    data = build.ToString();
                    string showData = data;
                    MessageBox.Show(showData);
                    MessageBox.Show("Your response have been recorded, Thank you! , Recorded");
                    StreamWriter file = new StreamWriter(@"C:\Users\acer\Desktop\contact tracing demo\contact tracing list\" + txtbxFullName1.Text + " " + txtbxDateOfVisit1.Text + ".txt");
                    file.Write(showData);
                    file.Close();
                    if (videoDevice.IsRunning)
                        videoDevice.Stop();
                }
            }
        }
    }
}