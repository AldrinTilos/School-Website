namespace practice_contact_tracing_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StreamWriter detail = new StreamWriter(@"F:\test1\" + txt_lname.Text + txt_fname.Text + ".txt", true);
            detail.WriteLine("Date: " + dtp_date.Text);
            detail.WriteLine("");
            detail.WriteLine("First Name: " + txt_fname.Text);
            detail.WriteLine("Last Name: " + txt_lname.Text);
            MessageBox.Show("Thank you for filling up this form!", "Contact Tracing", MessageBoxButtons.OK);
            detail.Close();
            Application.Restart();
            Environment.Exit(0);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.ShowDialog();
        }
    }
}