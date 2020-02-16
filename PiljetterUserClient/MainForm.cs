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
        public MainForm()
        {
            InitializeComponent();
            ResizeListViewColumns(listView1);
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        public void UpdateForm()
        {

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
                            SELECT c.*
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
                    var concerts = conn.Query<Concert>(sql, new { Artist = artist, Stage = stage, City = city, 
                                SpecificDate = specificDate, DateFrom = dateFrom, DateTo = dateTo });
                        foreach (var concert in concerts)
                        {
                            if (!concert.IsCanceled)
                            {
                                ListViewItem item = new ListViewItem(concert.Name);
                                item.SubItems.Add(concert.Date.ToString());
                                item.SubItems.Add(concert.Pesetas.ToString());

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = 230;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
