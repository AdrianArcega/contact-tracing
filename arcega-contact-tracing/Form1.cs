using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arcega_contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFullName_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoneClick(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\contact tracing.txt");
            file.WriteLine("Full Name :" + txtbxFullName.Text);
            file.WriteLine("Mobile/Phone Number :" + txtbxMobilePhoneNumber.Text);
            file.WriteLine("Email Address :" + txtbxEmailAddress.Text);
            file.WriteLine("Complete Address :" + txtbxCompleteAddress.Text);
            file.WriteLine("Date of visit :" + txtbxDateOfVisit.Text);
            file.WriteLine("Time of visit :" + txtbxTimeIn.Text);
            file.WriteLine("Time out :" + txtbxTimeOut.Text);
            file.WriteLine("Temperature :" + txtbxTemperature.Text);
            file.Close();
        }
    }
}
