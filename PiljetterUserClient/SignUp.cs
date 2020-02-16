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
    public partial class SignUp : Form
    {
        public MainForm MainForm;
        public SignUp(MainForm mainForm)
        {
            this.MainForm = mainForm;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();
                    var sql = @"
                            INSERT INTO Customer ([FirstName], [LastName], [Email], [Username], [Password], [Pesetas])
                            VALUES (@FirstName, @LastName, @Email, @Username, @Password, @Pesetas);";
                    c.Execute(sql, new { FirstName = tbFirstName.Text, LastName = tbLastName.Text, Email = tbEmail.Text, 
                        Pesetas = 10000, Password = tbPassword.Text, Username = tbUsername.Text});

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
