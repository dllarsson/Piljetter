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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (tbEmail.Text != "" && tbFirstName.Text != "" && tbLastName.Text != ""
                && tbUsername.Text != "" && tbPassword.Text != "")
            {
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();
                    var sql = "INSERT INTO Customer (FirstName, LastName, Email, Pesetas, CreatedOnDate, UserName, Password) VALUES (@FirstName, @LastName, @Email, 1000, GetDate(), @UserName, @Password);";
                    c.Execute(sql, new { FirstName = tbFirstName.Text, lastName = tbLastName.Text, Email = tbEmail.Text, UserName = tbUsername.Text, Password = tbPassword.Text });
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields to create a new user");
            }
        }
    }
}

