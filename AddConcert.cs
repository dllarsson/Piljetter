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
                using (var c = new SqlConnection(MainForm.connStr))
                {
                    c.Open();

                    var sql = 
                        @"SELECT [Id] 
                        FROM [Stage] 
                        WHERE [Name] = @Name;";
                    var stageId = c.ExecuteScalar(sql, new { Name = listBoxStage.SelectedItem });

                    sql =
                        @"SELECT [Id ]
                        FROM [Artist]
                        WHERE [Name] = @Name;";
                    var artistId = c.ExecuteScalar(sql, new { Name = listBoxArtist.SelectedItem });

                    sql =
                        "INSERT INTO Concert ([Name], [Date], [Stage_Id], [Artist_Id]) " +
                        "VALUES (@Name, @date, @Stage_Id, @Artist_Id);";
                    c.Execute(sql, new { Name = tbConcertName.Text, date = dateTimePicker1.Value.Date, Stage_Id = stageId, Artist_Id = artistId });
                }
            }
            if (!int.TryParse(tbTicketPrice.Text, out price)) MessageBox.Show("Price must be only digits");
            
        }

        private void AddConcert_Load(object sender, EventArgs e)
        {
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
                    "INNER JOIN City c ON City_Id = c.Id " +
                    "WHERE c.Name = @Name;";
                var stages = c.Query<Stage>(sql, new { Name = this.listBoxCity.SelectedItem });
                foreach (var stage in stages)
                {
                    listBoxStage.Items.Add(stage.Name);
                }
            }
        }
    }
}
