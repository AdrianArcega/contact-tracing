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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFilterClick(object sender, EventArgs e)
        {

        }

        private void btnDisplayDataClick(object sender, EventArgs e)
        {
            Form4 all = new Form4();
            all.ShowDialog();
            this.Hide();
        }
    }
}
