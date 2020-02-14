using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piljetter
{
    
    public partial class MainForm : Form
    {
        public static string connStr = "Server= localhost\\SQLEXPRESS; Database = Piljetter; Integrated Security=True;";
        public MainForm frm { get; set; }
        public Admin Admin { get; set; }
        public List<User> users = new List<User>();
        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(Admin a)
        {
            Admin = a;
        }
        public void UpdateForm()
        {

            lblSignedIn.Text = "Logged in as: " + Admin.Name;
            lblSignedIn.Font = new Font("Arial", 20, FontStyle.Bold);
            if(Admin.SignedIn == true)
            {
                using (var c = new SqlConnection(connStr))
                {
                    c.Open();
                    var sql =
                        "SELECT * " +
                        "FROM Concert;";
                    var concerts = c.Query<Concert>(sql);
                    foreach (var concert in concerts)
                    {
                        ListViewItem item = new ListViewItem(concert.Name);
                        item.SubItems.Add(concert.Artist_Id.ToString());
                        item.SubItems.Add(concert.Price.ToString());
                        item.SubItems.Add(concert.Date.ToString());
                        listViewUsers.Items.Add(item);


                    }
                }
            }
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

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin(this);
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Admin.Name + "   " + Admin.Password);
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddConcert_Click(object sender, EventArgs e)
        {
            AddConcert addConcert = new AddConcert();
            addConcert.Show();
        }
    }
}
