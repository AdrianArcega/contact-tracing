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
            StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\contact tracing demo\" + txtbxFullName.Text +  "  + txtbxDateOfVisit.Text + .txt", true);
            file.WriteLine("");
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
                file.WriteLine(lblQuestionA4.Text + " : Yes , Specific Country : " + txtbxQuestion4.Text);
            }
            if (checkBoxNo4.CheckState == CheckState.Checked)
            {
                file.WriteLine(lblQuestionA4.Text + " : No");
            }
            file.WriteLine("");
            file.Close();

            MessageBox.Show("You have submitted your form" , "Thank you!");
        }

        private void buttonResetClick(object sender, EventArgs e)
        {
            txtbxFullName.Text = "";
            txtbxMobilePhoneNumber.Text = "";
            txtbxEmailAddress.Text = "";
            txtbxCompleteAddress.Text = "";
            txtbxDateOfVisit.Text = "";
            txtbxTimeIn.Text = "";
            txtbxTimeOut.Text = "";
            txtbxBodyTemperature.Text = "";

            if (checkBoxYes1.CheckState == CheckState.Checked)
            {
                checkBoxYes1.Checked = false;
            }
            if (checkBoxNo1.CheckState == CheckState.Checked)
            {
                checkBoxNo1.Checked = false;
            }

            if (checkBoxYesA2.CheckState == CheckState.Checked)
            {
                checkBoxYesA2.Checked = false;
            }
            if (checkBoxNoA2.CheckState == CheckState.Checked)
            {
                checkBoxNoA2.Checked = false;
            }

            if (checkBoxYesB2.CheckState == CheckState.Checked)
            {
                checkBoxYesB2.Checked = false;
            }
            if (checkBoxNoB2.CheckState == CheckState.Checked)
            {
                checkBoxNoB2.Checked = false;
            }

            if (checkBoxYesC2.CheckState == CheckState.Checked)
            {
                checkBoxYesC2.Checked = false;
            }
            if (checkBoxNoC2.CheckState == CheckState.Checked)
            {
                checkBoxNoC2.Checked = false;
            }

            if (checkBoxYesD2.CheckState == CheckState.Checked)
            {
                checkBoxYesD2.Checked = false;
            }
            if (checkBoxNoD2.CheckState == CheckState.Checked)
            {
                checkBoxNoD2.Checked = false;
            }

            if (checkBoxYesE2.CheckState == CheckState.Checked)
            {
                checkBoxYesE2.Checked = false;
            }
            if (checkBoxNoE2.CheckState == CheckState.Checked)
            {
                checkBoxNoE2.Checked = false;
            }

            if (checkBoxYesF2.CheckState == CheckState.Checked)
            {
                checkBoxYesF2.Checked = false;
            }
            if (checkBoxNoF2.CheckState == CheckState.Checked)
            {
                checkBoxNoF2.Checked = false;
            }

            if (checkBoxYesG2.CheckState == CheckState.Checked)
            {
                checkBoxYesG2.Checked = false;
            }
            if (checkBoxNoG2.CheckState == CheckState.Checked)
            {
                checkBoxNoG2.Checked = false;
            }

            if (checkBoxYesH2.CheckState == CheckState.Checked)
            {
                checkBoxYesH2.Checked = false;
            }
            if (checkBoxNoH2.CheckState == CheckState.Checked)
            {
                checkBoxNoH2.Checked = false;
            }

            if (checkBoxYesI2.CheckState == CheckState.Checked)
            {
                checkBoxYesI2.Checked = false;
            }
            if (checkBoxNoI2.CheckState == CheckState.Checked)
            {
                checkBoxNoI2.Checked = false;
            }

            if (checkBoxYesJ2.CheckState == CheckState.Checked)
            {
                checkBoxYesJ2.Checked = false;
            }
            if (checkBoxNoJ2.CheckState == CheckState.Checked)
            {
                checkBoxNoJ2.Checked = false;
            }

            if (checkBoxYes3.CheckState == CheckState.Checked)
            {
                checkBoxYes3.Checked = false;
            }
            if (checkBoxNo3.CheckState == CheckState.Checked)
            {
                checkBoxNo3.Checked = false;
            }

            txtbxQuestion4.Text = "";
            if (checkBoxYes4.CheckState == CheckState.Checked)
            {
                checkBoxYes4.Checked = false;
            }
            if (checkBoxNo4.CheckState == CheckState.Checked)
            {
                checkBoxNo4.Checked = false;
            }
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
