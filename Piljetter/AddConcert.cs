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
        public MainForm M { get; set; }
        public AddConcert(MainForm main)
        {

            M = main;
            InitializeComponent();
        }

        private void btnAddConcert_Click(object sender, EventArgs e)
        {
            
                try
                {
                    using (var c = new SqlConnection(MainForm.connStr))
                    {
                        c.Open();
                    var sql = @"
                            WITH cte AS 
                            (
	                            SELECT (((a.Popularity * s.StageQuality) * s.MaxVisitors) / s.MaxVisitors) * 1.5 AS TicketPrice, a.Id AS ArtistId, s.Id AS StageId, s.MaxVisitors AS MaxVisitors
	                            FROM Artist a, Stage s
	                            WHERE a.Name = @ArtistName AND s.Name = @StageName

                            )
                            INSERT INTO Concert (Name, Date, Stage_Id, Artist_Id, Pesetas, AvaibleTickets)
                            SELECT @Name, @date, c.StageId, c.ArtistId, c.TicketPrice, c.MaxVisitors
                            FROM cte c
                                ";



                        //Gammla insert concert

                        //INSERT INTO Concert ([Name], [Date], [Stage_Id], [Artist_Id], Pesetas, AvaibleTickets) 
                        //VALUES (@Name, @date, (SELECT Id FROM Stage WHERE Name = @StageName), 
                        //       (SELECT Id FROM Artist WHERE Name = @ArtistName), @Pesetas, (SELECT MaxVisitors
                        //                                                                    FROM Stage
                        //                                                                    WHERE Id = (SELECT Id 
                        //                                                                                FROM Stage 
                        //                                                                                WHERE Name = @StageName)));";
                        c.Execute(sql, new
                        {
                            Name = tbConcertName.Text,
                            date = dateTimePicker1.Value.Date,
                            StageName = listBoxStage.SelectedItem,
                            ArtistName = listBoxArtist.SelectedItem,
                        }); ;
                        MessageBox.Show("Concert was succesfully added!");
                        tbConcertName.Text = "";
                    M.UpdateForm();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

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
