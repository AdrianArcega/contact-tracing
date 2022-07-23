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
            List<string> dates = new List<string>();
            string Date = txtbxFilterDate.Text;
            int dateResult = 0;
            var txtfiles = Directory.EnumerateFiles(@"C:\Users\acer\Desktop\contact tracing demo\dates");
            foreach (string file in txtfiles)
            {
                string contents = File.ReadAllText(file);
                if (contents.Contains(Date))
                {
                    dates.Add(contents);
                    dateResult++;
                    continue;
                }
            }
            if (dateResult == 0)
            {
                MessageBox.Show("No records found");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\acer\Desktop\contact tracing demo\dates\" + txtbxFilterDate.Text +".txt");
                foreach (string contents in dates)
                {
                    var lastItem = dates.LastOrDefault();
                    file.WriteLine(contents);
                }
                file.Close();
                MessageBox.Show("Found " + dateResult + "records on the selected date");
                MessageBox.Show("This will be save in the Contact Tracing folder");
            }
        }

        private void btnDisplayDataClick(object sender, EventArgs e)
        {
            Form4 all = new Form4();
            all.ShowDialog();
            this.Hide();
        }
    }
}
