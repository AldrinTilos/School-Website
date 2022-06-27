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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var txtFiles = Directory.GetFiles(@"F:\test1");
            foreach (string file in txtFiles)
            {
                string allcontent = File.ReadAllText(file);
                lbl_all.Text = lbl_all.Text + allcontent + "\n";
            }
        }

        private void lbl_all_Click(object sender, EventArgs e)
        {

        }
    }
}
