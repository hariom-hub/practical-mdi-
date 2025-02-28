using Microsoft.VisualBasic.Logging;

namespace practical_mdi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin obj = new admin();
            obj.MdiParent = this;
            obj.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration obj = new registration();
            obj.MdiParent = this;
            obj.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.MdiParent = this;
            obj.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 mdj = new MDIParent1();
            mdj.MdiParent = this;
            mdj.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
        }
    }
}
