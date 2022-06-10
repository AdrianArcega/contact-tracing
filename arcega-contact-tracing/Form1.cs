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
            if (checkBoxYes1.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion1.Text + " : Yes");
            }
            if (checkBoxNo1.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion1.Text + " : No");
            }
            file.Close();
            
           

        }
        private void buttonNewFormClick(object sender, EventArgs e)
        {
            txtbxFullName.Text = "";
            txtbxMobilePhoneNumber.Text = "";
            txtbxEmailAddress.Text = "";
            txtbxCompleteAddress.Text = "";
            txtbxDateOfVisit.Text = "";
            txtbxTimeIn.Text = "";
            txtbxTimeOut.Text = "";
            txtbxTemperature.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
