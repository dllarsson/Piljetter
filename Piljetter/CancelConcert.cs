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
                                    --
                                    UPDATE c
                                    SET c.Pesetas = c.Pesetas + sq.TotalPrice
                                    FROM Customer c
                                    INNER JOIN (SELECT SUM(t.Price) as TotalPrice, t.Customer_Id as Customer_Id
                                                FROM Ticket t
                                                INNER JOIN Concert con ON t.Concert_Id = con.Id
                                                WHERE con.Id = @Id
                                                GROUP BY t.Customer_Id) AS sq ON sq.Customer_Id = c.Id
                                    --
                                    INSERT INTO TicketCoupon (Customer_Id, Concert_Id, ExpiryDate)
									SELECT tc.Customer_Id, @Id, DATEADD(day, 30, tc.Date)
									FROM (SELECT t.Customer_Id as Customer_Id, con.Date as Date
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.Id = @Id
                                          GROUP BY t.Customer_Id, t.Id, con.Date) as tc
                                    --
                                    DELETE t 
									FROM Ticket t
                                    INNER JOIN (SELECT c.Id AS Concert_Id
                                                FROM Concert c
                                                WHERE c.IsCanceled = 1) as ConIdTable ON t.Concert_Id = ConIdTable.Concert_Id
                                    WHERE t.Concert_Id = ConIdTable.Concert_Id
                                    ";

                        c.Execute(sql, new { Id = tbConcertId.Text }, transaction: t);
                        

                        t.Commit();
                    }

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
