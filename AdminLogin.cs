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
    public partial class AdminLogin : Form
    {
        public MainForm Frm { get; set; }
        public AdminLogin(MainForm frm)
        {
            Frm = frm;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                var connStr = "Server= localhost\\SQLEXPRESS; Database = Piljetter; Integrated Security=True;";
                using (var c = new SqlConnection(connStr))
                {
                    c.Open();
                    var sql = "SELECT * " +
                        "FROM Admin " +
                        "WHERE Name = @Name and Password = @Password;";
                    var result = c.Query<Admin>(sql, new { Name = tbUsername.Text, Password = tbPassword.Text });

                    if (result.Count() == 1)
                    {
                        Admin a = result.First();
                        a.SignedIn = true;
                        Frm.Admin = a;
                        Frm.UpdateForm();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credentials");
                    }
                }
            }
            else MessageBox.Show("Fill out all fields");
        }
    }
}
