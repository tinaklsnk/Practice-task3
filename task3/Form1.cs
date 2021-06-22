using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.goodsTableAdapter.Fill(this.pCShopDataSet.Goods);
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PCshop"].ConnectionString);
                connection.Open();
                DataGridViewImageColumn photoColumn = new DataGridViewImageColumn();
                photoColumn.HeaderText = "Photo";
                photoColumn.Name = "Photo";
                dataGridView1.Columns.Add(photoColumn);
                if (connection.State != ConnectionState.Open)
                {
                    throw new Exception();
                }
                Table();
            }
            catch
            {
                MessageBox.Show("Помилка підключення!");
                Environment.Exit(0);
            }
        }
        public void Table()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Goods;", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            InsertImages();
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void Insert(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || PriceBox.Text == "" || ProducerBox.Text == "" || TypeBox.Text == "" || WarrantyBox.Text == "")
            {
                MessageBox.Show("Заповніть поля!");
                goto exit;
            }
            try
            {
                int price = Convert.ToInt32(PriceBox.Text);
                int warranty = Convert.ToInt32(WarrantyBox.Text);
                string path = PathBox.Text;
                if (!string.IsNullOrEmpty(path))
                {
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("Файлу не знайдено!");
                        path = null;
                    }
                }
                SqlCommand command = new SqlCommand($"INSERT INTO [Goods] (Name, Price, Type, Producer, Warranty, Path) VALUES (N'{NameBox.Text}', {price}, N'{TypeBox.Text}', N'{ProducerBox.Text}', {warranty}, N'{path}')", connection);
                command.ExecuteNonQuery();
                dataGridView1.Refresh();
                Table();
            }
            catch
            {
                MessageBox.Show("Дані введено невірно!");
                goto exit;
            }
        exit:
            Clear();
        }
        private void Clear()
        {
            NameBox.Clear();
            PriceBox.Clear();
            ProducerBox.Clear();
            TypeBox.Clear();
            WarrantyBox.Clear();
            PathBox.Clear();
            IdBox.Clear();
        }
        public void InsertImages()
        {
            SqlCommand command = new SqlCommand($"SELECT MAX(ID) FROM [Goods]", connection);
            Int32 maxId = (Int32)command.ExecuteScalar();
            Int32 curId = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                command = new SqlCommand($"SELECT ID FROM [Goods] where id>={curId}", connection);
                curId = (Int32)command.ExecuteScalar();
                command = new SqlCommand($"SELECT path FROM [Goods] WHERE id={curId};", connection);
                string path = (string)command.ExecuteScalar();
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1];
                if (File.Exists(path))
                {
                    Image image = Image.FromFile($@"{path}");
                    image = resizeImage(image, new Size(50, 50));
                    cell.Value = image;
                }
                curId++;
            }
            //C:\Users\User\Desktop\pic\1.jpeg
        }
        private void Remove(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IdBox.Text);
                SqlCommand command = new SqlCommand($"DELETE FROM Goods WHERE Id={id}; ", connection);
                command.ExecuteNonQuery();
                Table();
                Clear();
            }
            catch
            {
                MessageBox.Show("Дані введено невірно");
                Clear();
            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(SearchBox.Text);
            }
            catch
            {
                id = 0;
            }
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{SearchBox.Text}%' or Id={id}";
            InsertImages();
        }
    }
}