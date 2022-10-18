using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EntityFramework
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeDataSet(comboBox1.SelectedItem.ToString());
        }

        private void InitializeDataSet(string tableName)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            adapter = new SqlDataAdapter($"select * from {tableName}", con);
            new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet, $"{tableName}");

            dataSet.Tables[$"{tableName}"].RowChanged += Form1_RowChanged;
            dataSet.Tables[$"{tableName}"].RowDeleted += Form1_RowDeleted;

            bindingSource1.DataSource = dataSet;
            bindingSource1.DataMember = $"{tableName}";

            dataGridView1.DataSource = bindingSource1;
            if (dataGridView1.Columns.Contains(dataGridView1.Columns["id"]))
            {
                dataGridView1.Columns["id"].Visible = false;
            }
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void Form1_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            DataRow[] rows = new DataRow[1];
            rows[0] = e.Row;
            adapter.Update(rows);
        }

        private void Form1_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow[] rows = new DataRow[1];
            rows[0] = e.Row;
            adapter.Update(rows);
        }

        private void InitializeComboBox()
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection connection = new SqlConnection(conStr);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT name FROM sys.tables";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["name"].ToString() != "sysdiagrams" && reader["name"].ToString() != "__MigrationHistory")
                    {
                        comboBox1.Items.Add(reader["name"].ToString());
                    }
                }
                comboBox1.SelectedIndex = 0;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                var books = cnt.Books.Select(x => new { Id = x.Id, Title = x.Title}).ToList();
                dataGridView1.DataSource = books;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDataSet(comboBox1.SelectedItem.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] bytes = (byte[])dataGridView1.SelectedRows[0].Cells[3].Value;
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                pictureBox1.Image = img;
            }
            catch
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Books":
                    Form_AddBook addBook = new Form_AddBook(this.dataGridView1);
                    addBook.ShowDialog();
                    break;
                case "Sages":
                    Form_AddSage addSage = new Form_AddSage(this.dataGridView1);
                    addSage.ShowDialog();
                    break;
                case "SageBooks":
                    Form_AddSageBooks addSageBooks = new Form_AddSageBooks(this.dataGridView1);
                    addSageBooks.ShowDialog();
                    break;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Books":
                    Form_UpdateBook updateBook = new Form_UpdateBook(this.dataGridView1);
                    updateBook.ShowDialog();
                    break;
                case "Sages":
                    Form_UpdateSage updateSage = new Form_UpdateSage(this.dataGridView1);
                    updateSage.ShowDialog();
                    break;
                case "SageBooks":
                    Form_UpdateSageBooks updateSageBooks = new Form_UpdateSageBooks(this.dataGridView1);
                    updateSageBooks.ShowDialog();
                    break;
            }
        }
    }
}
