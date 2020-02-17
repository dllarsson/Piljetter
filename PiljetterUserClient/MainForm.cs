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
            listView1.Columns[5].Width = 170;
            listView1.Columns[6].Width = 120;


        }

        public void UpdateLoggedInUser()
        {
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
                var customers = conn.Query<Customer>(sql, new { Id = logedInUser.Id });
                foreach (var customer in customers)
                {
                    logedInUser.Pesetas = customer.Pesetas;
                    listBoxTickets.Items.Add("ID: " + customer.TicketId + "  Concert: " + customer.ConcertName);
                }
                
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
                    var sql = @"
                            SELECT c.*, a.Name as ArtistName, cty.Name as Cityname, s.Name as StageName
                            FROM Concert c
                            INNER JOIN Artist a ON (a.Id = c.Artist_Id)
                            INNER JOIN Stage s ON (s.Id = c.Stage_Id)
                            INNER JOIN City cty ON (cty.Id = s.City_Id)
                            WHERE (a.Name = @Artist OR @Artist = '')
                            AND (s.Name = @Stage OR @Stage = '')
                            AND (cty.Name = @City OR @City = '')
                            AND (c.Date = @SpecificDate OR @SpecificDate IS NULL)
                            AND (c.Date BETWEEN @DateFrom AND @DateTo OR (@DateFrom IS NULL OR @DateTo IS NULL))
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
                    using (var t = conn.BeginTransaction())
                    {
                        
                        var sql = @"
                                INSERT INTO Ticket (Concert_Id, Customer_Id, Price)
                                VALUES (@ConcertId, @CustomerId, (SELECT Pesetas FROM Concert WHERE Id = @ConcertId))
                                UPDATE Customer
                                SET Pesetas = Pesetas - (SELECT Pesetas FROM Concert WHERE Id = @ConcertId)
                                WHERE Id = @CustomerId
                                ";
                        conn.Execute(sql, new { ConcertId = tbConcertId.Text, CustomerId = logedInUser.Id}, transaction: t);
                        t.Commit();
                    }


                    this.UpdateLoggedInUser();
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
        }
    }
}
