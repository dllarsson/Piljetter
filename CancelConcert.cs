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
    public partial class CancelConcert : Form
    {
        public CancelConcert()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();

                    var sql =
                        @"UPDATE Concert
                          SET [IsCanceled] = 1
                          WHERE [Id] = @Id;";
                    c.Query(sql, new { Id = tbConcertId.Text });

                   
                    MessageBox.Show("Concert was succesfully canceled!");
           
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
