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
    public partial class Form_AddSage : Form
    {
        DataGridView mainDataGridView;
        public Form_AddSage(DataGridView mainDataGridView)
        {
            InitializeComponent();
            this.mainDataGridView = mainDataGridView;
            imageBox.Image = imageBox.ErrorImage;
        }

        private void Form_AddSage_Load(object sender, EventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                sagesGridView.DataSource = cnt.Sages.Select(x => new { Name = x.Name, Birthday = x.Birthday, x.Image }).ToList();
            }
        }

        private void sagesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameBox.Text = sagesGridView.SelectedRows[0].Cells[0].Value.ToString();
                birthdayPicker.Value = (DateTime)sagesGridView.SelectedRows[0].Cells[1].Value;
                try
                {
                    byte[] bytes = (byte[])sagesGridView.SelectedRows[0].Cells[2].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    imageBox.Image = img;
                }
                catch
                {
                    imageBox.Image = imageBox.ErrorImage;
                }
            }
            catch
            {
                
            }
        }

        private void SIbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                imageBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameBox.Text;
                DateTime birthday = birthdayPicker.Value;
                byte[] image = ImageToByte(imageBox.Image);
                string sql = "INSERT INTO Sages (Name, Birthday, Image) VALUES (@name, @birthday, @image)";
                string con = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(con))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@birthday", birthday);
                        command.Parameters.AddWithValue("@image", image);
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

        private void Form_AddSage_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (MyDbContext cnt = new MyDbContext())
            {
                mainDataGridView.DataSource = cnt.Sages.Select(x => new { Id = x.Id, Name = x.Name, Birthday = x.Birthday, x.Image }).ToList();
                if (mainDataGridView.Columns.Contains(mainDataGridView.Columns["Id"]))
                {
                    mainDataGridView.Columns["Id"].Visible = false;
                }
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
