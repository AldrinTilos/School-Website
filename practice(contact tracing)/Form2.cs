using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_contact_tracing_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            Form3 all = new Form3();
            all.ShowDialog();
        }
        private void btn_date_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            string Date = dtp_date.Text;
            int dateResults = 0;
            var txtFiles = Directory.EnumerateFiles(@"F:\test1");
            foreach (string file in txtFiles)
            {
                string contents = File.ReadAllText(file);
                if (contents.Contains(Date))
                {
                    var date = contents.Substring(contents.IndexOf("=") + 1);
                    dateResults++;
                    dates.Add(contents);
                    continue;
                }
            }
            if (dateResults == 0)
            {
                MessageBox.Show("No records found on the selected date");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"F:\test1\Date\Specified Date.txt");
                foreach (string contents in dates)
                {
                    _ = dates.LastOrDefault();
                    file.WriteLine(contents);
                }
                file.Close();
                MessageBox.Show("Found " + dateResults + " record(s) on the selected date");
                MessageBox.Show("This file will be saved in the Date folder");
                Form4 date = new Form4();
                date.ShowDialog();
            }
        }

        
    }
}
