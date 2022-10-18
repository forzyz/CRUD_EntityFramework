using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EntityFramework
{
    public partial class Form_AddBook : Form
    {
        DataGridView mainDataGridView;
        public Form_AddBook(DataGridView mainDataGridView)
        {
            InitializeComponent();
            this.mainDataGridView = mainDataGridView;
        }

        private void Form_AddBook_Load(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                booksGridView.DataSource = cnt.Books.Select(x => new { Title = x.Title }).ToList();
            }
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                titleBox.Text = (string)booksGridView.SelectedRows[0].Cells[0].Value;
            }
            catch
            {

            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleBox.Text;
                string sql = "INSERT INTO Books (Title) VALUES (@title)";
                string con = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@title", title);
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                mainDataGridView.DataSource = cnt.Books.Select(x => new { Id = x.Id, Title = x.Title }).ToList();
                if (mainDataGridView.Columns.Contains(mainDataGridView.Columns["Id"]))
                {
                    mainDataGridView.Columns["Id"].Visible = false;
                }
            }
        }
    }
}
