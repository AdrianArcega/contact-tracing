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
            file.WriteLine("Temperature :" + txtbxBodyTemperature.Text);

            if (checkBoxYes1.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion1.Text + " : Yes");
            }
            if (checkBoxNo1.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion1.Text + " : No");
            }

            if (checkBoxYesA2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion2.Text +  lblQuestionA2.Text + " : Yes");
            }
            if (checkBoxNoA2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion2.Text + lblQuestionA2.Text + " : No");
            }

            if (checkBoxYesB2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionB2.Text + " : Yes");
            }
            if (checkBoxNoB2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionB2.Text + " : No");
            }

            if (checkBoxYesC2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionC2.Text + " : Yes");
            }
            if (checkBoxNoC2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionC2.Text + " : No");
            }

            if (checkBoxYesD2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionD2.Text + " : Yes");
            }
            if (checkBoxNoD2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionD2.Text + " : No");
            }

            if (checkBoxYesE2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionE2.Text + " : Yes");
            }
            if (checkBoxNoE2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionE2.Text + " : No");
            }

            if (checkBoxYesF2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionF2.Text + " : Yes");
            }
            if (checkBoxNoF2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionF2.Text + " : No");
            }

            if (checkBoxYesG2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionG2.Text + " : Yes");
            }
            if (checkBoxNoG2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionG2.Text + " : No");
            }

            if (checkBoxYesH2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionH2.Text + " : Yes");
            }
            if (checkBoxNoH2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionH2.Text + " : No");
            }

            if (checkBoxYesI2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionI2.Text + " : Yes");
            }
            if (checkBoxNoI2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionI2.Text + " : No");
            }

            if (checkBoxYesJ2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionJ2.Text + " : Yes");
            }
            if (checkBoxNoJ2.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionJ2.Text + " : No");
            }

            if (checkBoxYes3.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion3.Text + " : Yes");
            }
            if (checkBoxNo3.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestion3.Text + " : No");
            }

            if (checkBoxYes4.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionA4.Text + " : Yes" + "Specific country : " + txtbxQuestion4);
            }
            if (checkBoxNo4.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionA4.Text + " : No");
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
            txtbxBodyTemperature.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
