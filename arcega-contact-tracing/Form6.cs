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

        }

        private void btnScanQRClick(object sender, EventArgs e)
        {

        }
    }
}
