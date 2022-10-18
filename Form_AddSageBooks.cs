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
    public partial class Form_AddSageBooks : Form
    {
        DataGridView mainDataGridView;
        public Form_AddSageBooks(DataGridView mainDataGridView)
        {
            InitializeComponent();
            this.mainDataGridView = mainDataGridView;
        }

        private void Form_AddSage_Load(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                booksGridView.DataSource = cnt.Books.Select(x => new { Id = x.Id, Title = x.Title }).ToList();
                sagesGridView.DataSource = cnt.Sages.Select(x => new { Id = x.Id, Name = x.Name, x.Image }).ToList();
            }
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookBox.Text = (string)booksGridView.SelectedRows[0].Cells[1].Value;
            }
            catch
            {
                
            }
        }

        private void sagesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sageBox.Text = sagesGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int book = Convert.ToInt32(booksGridView.SelectedRows[0].Cells[0].Value);
                int sage = Convert.ToInt32(sagesGridView.SelectedRows[0].Cells[0].Value);
                string sql = $"INSERT INTO SageBooks (Book_Id, Sage_Id) VALUES ({book}, {sage})";
                string con = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = sql;
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

        private void Form_AddSageBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSet dataSet;
            SqlDataAdapter adapter;
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            adapter = new SqlDataAdapter($"select * from SageBooks", con);
            new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "SageBooks");

            mainDataGridView.DataSource = dataSet;
            mainDataGridView.DataMember = "SageBooks";
        }
    }
}
