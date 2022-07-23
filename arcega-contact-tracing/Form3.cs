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
            List<string> date = new List<string>();
            string Date = txtbxFilterDate.Text;
            int resultsFound = 0;
            var txtfiles = Directory.EnumerateFiles(@"C:\Users\acer\Desktop\contact tracing demo\dates");
            foreach (string file in txtfiles)
            {
                string contents = File.ReadAllText(file);
                if (contents.Contains(Date))
                {
                    date.Add(contents);
                    resultsFound++;
                    continue;
                }
            }
            if (resultsFound == 0)
            {
                MessageBox.Show("No records found");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\acer\Desktop\contact tracing demo\dates\" + txtbxFilterDate.Text +".txt");
                foreach (string contents in date)
                {
                    var lastItem = date.LastOrDefault();
                    file.WriteLine(contents);
                    MessageBox.Show(contents);

                }
                file.Close();

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
