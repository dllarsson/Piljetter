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
    public partial class AddConcert : Form
    {
        public AddConcert()
        {
            InitializeComponent();
        }

        private void btnAddConcert_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (listBoxCity.SelectedIndex == -1 || listBoxStage.SelectedIndex == -1 ||
                listBoxArtist.SelectedIndex == -1 || tbTicketPrice.Text == "" || !int.TryParse(tbTicketPrice.Text, out price))
            {
                MessageBox.Show("You must select all categories");
            }
            else
            {
                try
                {
                    using (var c = new SqlConnection(MainForm.connStr))
                    {
                        c.Open();
                        var sql =@"
                        INSERT INTO Concert ([Name], [Date], [Stage_Id], [Artist_Id], Pesetas) 
                        VALUES (@Name, @date, (SELECT Id FROM Stage WHERE Name = @StageName), (SELECT Id FROM Artist WHERE Name = @ArtistName), @Pesetas);";
                        c.Execute(sql, new
                        {
                            Name = tbConcertName.Text,
                            date = dateTimePicker1.Value.Date,
                            StageName = listBoxStage.SelectedItem,
                            ArtistName = listBoxArtist.SelectedItem,
                            Pesetas = tbTicketPrice.Text
                        }); ;
                        MessageBox.Show("Concert was succesfully added!");
                        tbTicketPrice.Text = "";
                        tbConcertName.Text = "";
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
            if (!int.TryParse(tbTicketPrice.Text, out price)) MessageBox.Show("Price must be only digits");

        }

        private void AddConcert_Load(object sender, EventArgs e)
        {
            listBoxArtist.Items.Clear();
            listBoxCity.Items.Clear();
            listBoxStage.Items.Clear();
            using (var c = new SqlConnection(MainForm.connStr))
            {
                c.Open();
                var sql =
                    "SELECT Name " +
                    "FROM City;";
                var cities = c.Query<City>(sql);
                foreach (var city in cities)
                {
                    listBoxCity.Items.Add(city.Name);
                }

                var sql2 =
                    "SELECT Name " +
                    "FROM Artist;";
                var artists = c.Query<Artist>(sql2);
                foreach (var artist in artists)
                {
                    listBoxArtist.Items.Add(artist.Name);
                }
            }
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBoxStage.Items.Clear();
            using (var c = new SqlConnection(MainForm.connStr))
            {
                c.Open();
                var sql =
                    "SELECT s.Name " +
                    "FROM Stage s " +
                    "INNER JOIN City c ON s.City_Id = c.Id " +
                    "WHERE c.Name = @Name;";
                var stages = c.Query<Stage>(sql, new { Name = this.listBoxCity.SelectedItem });
                foreach (var stage in stages)
                {
                    listBoxStage.Items.Add(stage.Name);
                }
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            AddArtist addArtist = new AddArtist();
            addArtist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AddConcert_Load(sender, e);
        }
    }
}
