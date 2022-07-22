using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arcega_contact_tracing
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGenerateQRClick(object sender, EventArgs e)
        {
            QRCodeGenerator GenerateQR = new QRCodeGenerator();
            QRCodeData qrcode = GenerateQR.CreateQrCode(txtbxQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qr = new QRCode(qrcode);
            pcbxQRCode.Image = qr.GetGraphic(5);
        }

        private void btnSaveQRClick(object sender, EventArgs e)
        {
            string location = @"C:\Users\acer\Desktop\QR codes";
            var qrimage = new SaveFileDialog();
            qrimage.InitialDirectory = location;
            qrimage.Filter = "PNG|*.png|JPEG|*.jpg";
            if (qrimage.ShowDialog() == DialogResult.OK)
            {
                pcbxQRCode.Image.Save(qrimage.FileName);
            }
        }
    }
}
