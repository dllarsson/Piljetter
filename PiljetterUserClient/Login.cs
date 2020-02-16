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

namespace PiljetterUserClient
{
    public partial class Login : Form
    {
        MainForm MainForm { get; set; }
        public Login(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();
                    var sql = @"
                            SELECT *
                            FROM Customer
                            WHERE [Username] = @Username AND [Password] = @Password;";

                    var Customer = c.Query<Customer>(sql, new { Username = textBox1.Text, Password = textBox2.Text });
                    if (Customer.Count() == 1)
                    {
                        foreach  (var cust in Customer)
                        {
                            MainForm.logedInUser = cust;
                        }
                        MessageBox.Show("Sign in succesful");
                        MainForm.IsLoggedIn = true;
                        
                        MainForm.UpdateForm();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
