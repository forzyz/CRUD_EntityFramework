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
    public partial class Form_UpdateSageBooks : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        DataGridView mainDataGridView;
        public Form_UpdateSageBooks(DataGridView mainDataGridView)
        {
            InitializeComponent();
            InitializeDataSet("SageBooks");
            this.mainDataGridView = mainDataGridView;
        }

        private void InitializeDataSet(string tableName)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            adapter = new SqlDataAdapter($"select * from {tableName}", con);
            new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet, $"{tableName}");

            bindingSource1.DataSource = dataSet;
            bindingSource1.DataMember = $"{tableName}";

            sageBooksGridView.DataSource = bindingSource1;
            if (sageBooksGridView.Columns.Contains(sageBooksGridView.Columns["id"]))
            {
                sageBooksGridView.Columns["id"].Visible = false;
            }
        }

        private void sageBooksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sageIdBox.Text = sageBooksGridView.SelectedRows[0].Cells[0].Value.ToString();
                booksIdBox.Text = sageBooksGridView.SelectedRows[0].Cells[1].Value.ToString();
                updateBox.Enabled = true;
            }
            catch
            {

            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int sage = Convert.ToInt32(sageIdBox.Text);
                int book = Convert.ToInt32(booksIdBox.Text);
                int condition = Convert.ToInt32(sageBooksGridView.SelectedRows[0].Cells[0].Value.ToString());
                string sql = $"UPDATE SageBooks SET Sage_Id = {sage}, Book_Id = {book} WHERE Sage_Id = {condition}";
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

        private void Form_UpdateSageBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            adapter = new SqlDataAdapter($"select * from SageBooks", con);
            new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "SageBooks");

            mainDataGridView.DataSource = dataSet;
            mainDataGridView.DataMember = "SageBooks";
        }

        private void Form_UpdateSageBooks_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Select row in DataGridView to update.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
