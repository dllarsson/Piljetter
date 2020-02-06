using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piljetter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            
        }
        public void SetLogout()
        {
            this.loginToolStripMenuItem.Enabled = true;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login(this);
            l.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
