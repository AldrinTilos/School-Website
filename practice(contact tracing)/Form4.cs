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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var dateFiles = Directory.GetFiles(@"F:\test1\Date\");
            foreach (string file in dateFiles)
            {
                string dates = File.ReadAllText(file);
                lbl_date.Text = lbl_date.Text + dates + "\n";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
