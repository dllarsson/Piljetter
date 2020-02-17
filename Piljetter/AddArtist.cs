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
    public partial class AddArtist : Form
    {
        public AddArtist()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();

                   var sql =
                        @"INSERT INTO Artist ([Name], Popularity) 
                        VALUES (@Name, @Popularity);";
                    c.Execute(sql, new
                    {
                        Name = textBox1.Text,
                        Popularity = textBox2.Text
                    });
                    MessageBox.Show("Artist was succesfully added!");
                    this.Close();

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
