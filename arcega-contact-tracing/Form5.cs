using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arcega_contact_tracing
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            var filteredlist = Directory.GetFiles(@"C:\Users\user\Desktop\contact tracing demo\dates");
            foreach (string file in filteredlist)
            {
                string filtereddata = System.IO.File.ReadAllText(file);
                lblFiltered.Text = lblFiltered.Text + filtereddata;
            }
        }

    }
}
