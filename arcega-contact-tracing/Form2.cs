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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            if(txtbxUser.Text == "adrian")
            {
                if (txtbxPassword.Text == "pogi")
                {
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Wrong username or password");
                }
            }
            else
            {
                MessageBox.Show("Error: Wrong username or password");
            }
        }
    }
}
