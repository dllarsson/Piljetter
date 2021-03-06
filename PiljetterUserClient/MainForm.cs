﻿using Dapper;
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
    public partial class MainForm : Form
    {
        public static string connStr = "Server= localhost\\SQLEXPRESS; Database = Piljetter; Integrated Security=True;";
        public bool IsLoggedIn { get; set; }
        public Customer logedInUser { get; set; } = new Customer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            radioButton3.Checked = true;
            listView1.Columns[0].Width = 170;
            listView1.Columns[1].Width = 170;
            listView1.Columns[2].Width = 170;
            listView1.Columns[3].Width = 220;
            listView1.Columns[4].Width = 120;
            listView1.Columns[5].Width = 80;
            listView1.Columns[6].Width = 120;
            listView1.Columns[7].Width = 120;


            if (IsLoggedIn)
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
                updateTicketsAndCoupons();
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
            }

            this.btnLogin.Enabled = true;
            this.btnSingUp.Enabled = true;
        }

        public void UpdateLoggedInUser()
        {
            btnLogin.Enabled = false;

            listBoxTickets.Items.Clear();
            listBoxCoupons.Items.Clear();
            MainForm_Load(this, new EventArgs());
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var sql = @"SELECT Pesetas FROM Customer WHERE Id = @Id";
                var pesetas = conn.ExecuteScalar(sql, new { Id = logedInUser.Id });
                logedInUser.Pesetas = (int)pesetas;

            }

            lblUsername.Text = "Username: " + logedInUser.Username;
            lblBalance.Text = "Pesetas: " + logedInUser.Pesetas.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var city = TbSearchCity.Text;
            var artist = tbSearchArtists.Text;
            var stage = tbSearchStages.Text;
            DateTime? dateFrom = dateTimePicker1.Value.Date;
            DateTime? dateTo = dateTimePicker2.Value.Date;
            DateTime? specificDate = dateTimePicker3.Value.Date;

            if (!radioButton2.Checked)
            {
                dateFrom = null;
                dateTo = null;
            }
            if (!radioButton1.Checked)
            {
                specificDate = null;
            }

            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    //var sql = @"
                    //        SELECT c.*, a.Name as ArtistName, cty.Name as Cityname, s.Name as StageName
                    //        FROM Concert c
                    //        INNER JOIN Artist a ON (a.Id = c.Artist_Id)
                    //        INNER JOIN Stage s ON (s.Id = c.Stage_Id)
                    //        INNER JOIN City cty ON (cty.Id = s.City_Id)
                    //        WHERE (a.Name = @Artist OR @Artist = '')
                    //        AND (s.Name = @Stage OR @Stage = '')
                    //        AND (cty.Name = @City OR @City = '')
                    //        AND (c.Date = @SpecificDate OR @SpecificDate IS NULL)
                    //        AND (c.Date BETWEEN @DateFrom AND @DateTo OR (@DateFrom IS NULL OR @DateTo IS NULL))
                    //        ";


                    var sql = @"
                               SELECT TOP 100 * FROM searchResultConcert
                               WHERE (ArtistName = @Artist OR @Artist = '')
                               AND (StageName = @Stage OR @Stage = '')
                               AND (Cityname = @City OR @City = '')
                               AND (Date = @SpecificDate OR @SpecificDate IS NULL)
                               AND (Date BETWEEN @DateFrom AND @DateTo OR (@DateFrom IS NULL OR @DateTo IS NULL))
                                ";

                    var concerts = conn.Query<Concert>(sql, new
                    {
                        Artist = artist,
                        Stage = stage,
                        City = city,
                        SpecificDate = specificDate,
                        DateFrom = dateFrom,
                        DateTo = dateTo
                    });
                    foreach (var concert in concerts)
                    {
                        if (!concert.IsCanceled)
                        {
                            ListViewItem item = new ListViewItem(concert.Name);
                            item.SubItems.Add(concert.ArtistName);
                            item.SubItems.Add(concert.CityName);
                            item.SubItems.Add(concert.StageName);
                            item.SubItems.Add(concert.Date.ToString("yyyy/MM/dd"));
                            item.SubItems.Add(concert.Pesetas.ToString());
                            item.SubItems.Add(concert.AvaibleTickets.ToString());
                            item.SubItems.Add(concert.Id.ToString());
                            listView1.Items.Add(item);

                        }


                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dateTimePicker3.Enabled = true;
            }
            else
            {
                dateTimePicker3.Enabled = false;
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                        var sql = @"SELECT s.MaxVisitors, c.AvaibleTickets
                                FROM Concert c
                                INNER JOIN Stage s ON c.Stage_Id = s.Id
                                WHERE c.Id = @ConcertId";
                        var ticketsLeft = conn.Query<Concert>(sql, new { ConcertId = tbConcertId.Text });

                    foreach (Concert c in ticketsLeft)
                    {
                        var limit = c.MaxVisitors * 0.1;
                        if (c.AvaibleTickets <= limit)
                        {

                            using (var t = conn.BeginTransaction(IsolationLevel.Serializable))
                            {



                                if (cbCoupon.Checked)
                                {
                                    sql = @"
                                    SELECT * FROM TicketCoupon t WHERE t.Customer_Id = @CustomerId         
                                    ";

                                    var coupons = conn.Query(sql, new { CustomerId = logedInUser.Id }, transaction: t);

                                    if (coupons.Count() > 0)
                                    {
                                        sql = @"
                                        WITH sq AS 
                                        (
                                             SELECT c.Id AS CustomerId, con.Id AS ConcertId
                                             FROM Customer c, Concert con
                                             WHERE con.Id = @ConcertId AND c.Id = @CustomerId AND con.IsCanceled = 0
                                        )
                                        INSERT INTO Ticket (Customer_Id, Concert_Id)
                                        SELECT sq.CustomerId, sq.ConcertId
                                        FROM sq;
                                        WITH tc AS 
                                        (
                                        	SELECT TOP (1) *
                                        	FROM TicketCoupon t
                                        	WHERE t.Customer_Id = @CustomerId
                                        	ORDER BY t.ExpiryDate
                                        )
                                        DELETE FROM tc
                                        UPDATE c
                                        SET c.AvaibleTickets = AvaibleTickets -1
                                        FROM Concert c
                                        WHERE c.Id = @ConcertId
                                        ";
                                    }
                                }

                                else
                                {
                                    sql = @"
                                WITH sq AS 
                                (
                                      SELECT c.Id AS CustomerId, con.Id AS ConcertId
                                      FROM Customer c, Concert con
                                      WHERE con.Id = @ConcertId AND c.Id = @CustomerId AND con.IsCanceled = 0
                                 )
                                INSERT INTO Ticket (Customer_Id, Concert_Id, Price)
                                SELECT sq.CustomerId, sq.ConcertId, (SELECT Pesetas FROM Concert WHERE Id = @ConcertId)
                                FROM sq;
                                UPDATE Customer
                                SET Pesetas = Pesetas - (SELECT Pesetas FROM Concert WHERE Id = @ConcertId)
                                WHERE Id = @CustomerId
                                UPDATE c
                                SET c.AvaibleTickets = AvaibleTickets -1
                                FROM Concert c
                                WHERE c.Id = @ConcertId
                                ";
                                }
                                conn.Execute(sql, new { ConcertId = tbConcertId.Text, CustomerId = logedInUser.Id }, transaction: t);


                                t.Commit();
                            }
                        }
                        else
                        {
                            using (var t = conn.BeginTransaction())
                            {



                                if (cbCoupon.Checked)
                                {
                                    sql = @"
                                    SELECT * FROM TicketCoupon t WHERE t.Customer_Id = @CustomerId         
                                    ";

                                    var coupons = conn.Query(sql, new { CustomerId = logedInUser.Id }, transaction: t);

                                    if (coupons.Count() > 0)
                                    {
                                        sql = @"
                                        WITH sq AS 
                                        (
                                             SELECT c.Id AS CustomerId, con.Id AS ConcertId
                                             FROM Customer c, Concert con
                                             WHERE con.Id = @ConcertId AND c.Id = @CustomerId AND con.IsCanceled = 0
                                        )
                                        INSERT INTO Ticket (Customer_Id, Concert_Id)
                                        SELECT sq.CustomerId, sq.ConcertId
                                        FROM sq;
                                        WITH tc AS 
                                        (
                                        	SELECT TOP (1) *
                                        	FROM TicketCoupon t
                                        	WHERE t.Customer_Id = @CustomerId
                                        	ORDER BY t.ExpiryDate
                                        )
                                        DELETE FROM tc
                                        UPDATE c
                                        SET c.AvaibleTickets = AvaibleTickets -1
                                        FROM Concert c
                                        WHERE c.Id = @ConcertId
                                        ";
                                    }
                                }

                                else
                                {
                                    sql = @"
                                WITH sq AS 
                                (
                                      SELECT c.Id AS CustomerId, con.Id AS ConcertId
                                      FROM Customer c, Concert con
                                      WHERE con.Id = @ConcertId AND c.Id = @CustomerId AND con.IsCanceled = 0
                                 )
                                INSERT INTO Ticket (Customer_Id, Concert_Id, Price)
                                SELECT sq.CustomerId, sq.ConcertId, (SELECT Pesetas FROM Concert WHERE Id = @ConcertId)
                                FROM sq;
                                UPDATE Customer
                                SET Pesetas = Pesetas - (SELECT Pesetas FROM Concert WHERE Id = @ConcertId)
                                WHERE Id = @CustomerId
                                UPDATE c
                                SET c.AvaibleTickets = AvaibleTickets -1
                                FROM Concert c
                                WHERE c.Id = @ConcertId
                                ";
                                }
                                conn.Execute(sql, new { ConcertId = tbConcertId.Text, CustomerId = logedInUser.Id }, transaction: t);


                                t.Commit();
                            }


                        }
                            this.UpdateLoggedInUser();
                    }

                    }
                 


                    

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshBalance_Click(object sender, EventArgs e)
        {
            UpdateLoggedInUser();
            updateTicketsAndCoupons();

        }
        private void updateTicketsAndCoupons()
        {
            listBoxCoupons.Items.Clear();
            listBoxTickets.Items.Clear();
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                var sql = @"
                            SELECT c.Pesetas, t.Id as TicketId, con.Name as ConcertName
                            FROM Customer c
                            INNER JOIN Ticket t ON c.Id = t.Customer_Id
                            INNER JOIN Concert con ON t.Concert_Id = con.Id
                            WHERE c.Id = @Id
                            AND c.Id = t.Customer_Id;";
                var tickets = conn.Query<Customer>(sql, new { Id = logedInUser.Id });
                sql = @"
                            SELECT tc.Id as CouponId, con.Name AS ConcertName, tc.ExpiryDate
                            FROM TicketCoupon tc
                            INNER JOIN Customer c ON tc.Customer_Id = c.Id
                            INNER JOIN Concert con ON tc.Concert_Id = con.Id
                            WHERE c.Id = @Id";

                var coupons = conn.Query<Customer>(sql, new { Id = logedInUser.Id });
                foreach (var ticket in tickets)
                {
                    listBoxTickets.Items.Add("ID: " + ticket.TicketId + "  Concert: " + ticket.ConcertName);

                }
                foreach (var coupon in coupons)
                {
                    listBoxCoupons.Items.Add("ID: " + coupon.CouponId + " Concert: " + coupon.ConcertName + " Expiry date: " + coupon.ExpiryDate);

                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            IsLoggedIn = false;
            listBoxCoupons.Items.Clear();
            listBoxTickets.Items.Clear();
            listView1.Items.Clear();
            this.btnLogOut.Hide();
            Update();
        }

        private void btnBuyPesetas_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connStr))
            {
                try
                {


                    conn.Open();
                    conn.Execute(@"UPDATE c
                               SET c.Pesetas = c.Pesetas + @Pesetas
                               FROM Customer c
                               WHERE c.Id = @Id", new { Id = logedInUser.Id, Pesetas = tbBuyPesetas.Text });
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
