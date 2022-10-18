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
    public partial class Form_UpdateBook : Form
    {
        DataGridView mainDataGridView;
        public Form_UpdateBook(DataGridView mainDataGridView)
        {
            InitializeComponent();
            this.mainDataGridView = mainDataGridView;
        }
        
        private void OKbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleBox.Text;
                int condition = Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value.ToString());
                string sql = "UPDATE Books SET Title = @title WHERE Id = @condition";
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
                        command.Parameters.AddWithValue("@condition", condition);
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
        
        private void Form_UpdateBook_Load(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                booksGridView.DataSource = cnt.Books.Select(x => new { Id = x.Id, Title = x.Title }).ToList();
                if (booksGridView.Columns.Contains(booksGridView.Columns["Id"]))
                {
                    booksGridView.Columns["Id"].Visible = false;
                }
            }
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateBox.Enabled = true;
                titleBox.Text = (string)booksGridView.SelectedRows[0].Cells[1].Value;
            }
            catch
            {

            }
        }

        private void Form_UpdateBook_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Select row in DataGridView to update.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form_UpdateBook_FormClosed(object sender, FormClosedEventArgs e)
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
