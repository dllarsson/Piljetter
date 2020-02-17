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

                    using (var t = c.BeginTransaction())
                    {
                        var sql = @"
                                    UPDATE Concert
                                    SET IsCanceled = 1
                                    WHERE Id = @Id
                                    UPDATE Customer
                                    SET c.Pesetas = c.Pesetas + sq.TotalPrice
                                    FROM 
                                         (SELECT SUM(t.Price) as TotalPrice
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.id = @Id
                                          GROUP BY t.Customer_Id) AS sq
                                    INNER JOIN Ticket t ON c.Id = t.Customer_Id
                                    INNER JOIN Concert con ON t.Concert_Id = con.Id
                                    WHERE con.Id = @Id
                                    ";
                        c.Execute(sql, new { Id = tbConcertId.Text }, transaction: t);
                        t.Commit();
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
