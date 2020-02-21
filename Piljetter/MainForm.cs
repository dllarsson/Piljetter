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
        public MainForm()
        {
            InitializeComponent();
            UpdateForm();

        }


        public void UpdateForm()
        {
            try
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
                        item.SubItems.Add(concert.Id.ToString());
                        item.SubItems.Add(concert.Pesetas.ToString());
                        item.SubItems.Add(concert.Date.ToString());
                        if (concert.IsCanceled)
                        {
                            item.SubItems.Add("YES");
                        }
                        else
                        {
                            item.SubItems.Add("NO");
                        }
                        listViewUsers.Items.Add(item);


                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnAddConcert_Click(object sender, EventArgs e)
        {
            AddConcert addConcert = new AddConcert(this);
            addConcert.Show();

        }



        private void btnCancelConcert_Click(object sender, EventArgs e)
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
                                    UPDATE c
                                    SET c.Pesetas = c.Pesetas + sq.TotalPrice
                                    FROM Customer c
                                    INNER JOIN (SELECT SUM(t.Price) as TotalPrice, t.Customer_Id as Customer_Id
                                                FROM Ticket t
                                                INNER JOIN Concert con ON t.Concert_Id = con.Id
                                                WHERE con.Id = @Id
                                                GROUP BY t.Customer_Id) AS sq ON sq.Customer_Id = c.Id
                                    INSERT INTO TicketCoupon (Customer_Id, Concert_Id, ExpiryDate)
									SELECT tc.Customer_Id, @Id, DATEADD(day, 30, tc.Date)
									FROM (SELECT t.Customer_Id as Customer_Id, con.Date as Date
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.Id = @Id
                                          GROUP BY t.Customer_Id, t.Id, con.Date) as tc
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

                    listViewUsers.Items.Clear();
                    UpdateForm();


                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnGetSoldTickets_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(connStr))
                {
                    c.Open();
                    var sql = @"
                                SELECT SUM(t.Price) AS TotalPrice, COUNT(t.Id) AS TotalTickets
                                FROM Ticket t
                                WHERE t.TimeBought BETWEEN @DateFrom AND @DateTo
                                 ";
                    var stats = c.Query<Stats>(sql, new { DateFrom = timeFrom.Value.Date, DateTo = timeTo.Value.Date });

                    if (stats.Count() == 1)
                    {
                        foreach (Stats item in stats)
                        {
                            tbPesetasFromTickets.Text = item.TotalPrice.ToString();
                            tbSoldTickets.Text = item.TotalTickets.ToString();
                        }

                    }



                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var c = new SqlConnection(connStr))
                {
                    c.Open();
                    var sql = @"
                          SELECT (a.Popularity * s.StageQuality) * s.MaxVisitors AS VenueCost ,
                                    s.MaxVisitors * c.Pesetas as Income, 
                                    ((s.MaxVisitors - c.AvaibleTickets) * c.Pesetas) - ((a.Popularity * s.StageQuality) * s.MaxVisitors) AS Profits,
                                    ((a.Popularity * s.StageQuality) * s.MaxVisitors) / c.Pesetas AS NumberOfTicketsToSellToBreakEven,
                                        c.Pesetas, s.MaxVisitors - c.AvaibleTickets AS TicketsSold
                          FROM Concert c
                          INNER JOIN Artist a ON a.Id = c.Artist_Id
                          INNER JOIN Stage s ON s.id = c.Stage_Id
                          WHERE c.Id = @ConcertId";
                    var stats = c.Query<Stats>(sql, new { ConcertId = tbConcertId2.Text });


                    if (stats.Count() == 1)
                    {
                        
                        foreach (Stats item in stats)
                        {
                            

                            tbIncome.Text = item.Income.ToString();
                            tbVenuecost.Text = item.VenueCost.ToString();
                            tbProfits.Text = item.Profits.ToString();
                            if (item.TicketsSold < item.NumberOfTicketsToSellToBreakEven)
                            {
                                tbTicketsToMakeProfits.BackColor = Color.Red;

                                tbTicketsToMakeProfits.Text = item.TicketsSold + " / " + item.NumberOfTicketsToSellToBreakEven.ToString();

                            }
                            else
                            {
                                tbTicketsToMakeProfits.BackColor = Color.Green;

                                tbTicketsToMakeProfits.Text = item.TicketsSold + " / " + item.NumberOfTicketsToSellToBreakEven.ToString();

                            }
                        }

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
