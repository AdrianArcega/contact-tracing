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
using static System.IO.StreamReader;

namespace arcega_contact_tracing
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFilterClick(object sender, EventArgs e)
        {
            StreamReader filter = new StreamReader(@":C\Users\user\Desktop\contact tracing demo\dates\" + txtbxFilterDate.Text + "txt", true);
           
            String filteredlist = filter.ReadToEnd();
            MessageBox.Show(filteredlist);

        }

        private void btnDisplayDataClick(object sender, EventArgs e)
        {
            Form4 all = new Form4();
            all.ShowDialog();
            this.Hide();
        }

        private void btnQRCodeGeneratorClick(object sender, EventArgs e)
        {
            Form6 all = new Form6();
            all.ShowDialog();
            this.Hide();
        }
    }
}
