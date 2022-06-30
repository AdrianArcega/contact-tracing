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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var datafiles = Directory.GetFiles(@"C:\Users\user\Desktop\contact tracing demo\contact tracing list");
            foreach (string data in datafiles)
            {
                string combinedtext = System.IO.File.ReadAllText(data);
                lblData.Text += combinedtext + "\n";
            }
        }
    }
}
