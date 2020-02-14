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
        public MainForm frm { get; set; }
        public Admin Admin { get; set; }
        public List<User> users = new List<User>();
        public MainForm()
        {
            InitializeComponent();
            UpdateForm();

        }

        public MainForm(Admin a)
        {
            Admin = a;
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
            AddConcert addConcert = new AddConcert();
            addConcert.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            listViewUsers.Items.Clear();
            UpdateForm();
        }

        private void btnCancelConcert_Click(object sender, EventArgs e)
        {
            CancelConcert cancelConcert = new CancelConcert();
            cancelConcert.Show();
        }
    }
}
