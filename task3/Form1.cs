using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

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
            this.goodsTableAdapter.Fill(this.pCShopDataSet.Goods);
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PCshop"].ConnectionString);
            connection.Open();
            DataGridViewImageColumn photoColumn = new DataGridViewImageColumn();
            photoColumn.HeaderText = "Photo";
            photoColumn.Name = "Photo";
            dataGridView1.Columns.Add(photoColumn);
            //if(connection.State==ConnectionState.Open)
            //{
            //    MessageBox.Show("Connected to DB");
            //}
            Table();
        }

        public void Table()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Goods;", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
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

            //InsertImages(path);
            //command.\\
            //string[] path = { @"D:\Studying\Практика\task3\Photo\83564.jpg",
            //@"D:\Studying\Практика\task3\Photo\99734.jpg",
            //@"D:\Studying\Практика\task3\Photo\117076.jpg",
            //@"D:\Studying\Практика\task3\Photo\96730.jpg",
            //@"D:\Studying\Практика\task3\Photo\110290.jpg",
            //@"D:\Studying\Практика\task3\Photo\77679.jpg",
            //@"D:\Studying\Практика\task3\Photo\105234.jpg",
            //@"D:\Studying\Практика\task3\Photo\98050.jpg",
            //@"D:\Studying\Практика\task3\Photo\121877.jpg",
            //@"D:\Studying\Практика\task3\Photo\93151.jpg"};
            //for (int i = 0; i < path.Length; i++)
            //{
            //    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1];
            //    Image image = Image.FromFile($"{path[i]}");
            //    image = resizeImage(image, new Size(50, 50));
            //    cell.Value = image;
            //}

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
            string path = PathBox.Text;
            if (PathBox.Text == "")
                path = null;
            else path = PathBox.Text;
            SqlCommand command = new SqlCommand($"INSERT INTO [Goods] (Name, Price, Type, Producer, Warranty, Path) VALUES ('{NameBox.Text}', {PriceBox.Text}, N'{TypeBox.Text}', '{ProducerBox.Text}', {WarrantyBox.Text}, '{path}')", connection);
            dataGridView1.Refresh();
            InsertImages(path);
            command.ExecuteNonQuery();
            dataGridView1.Refresh();
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
        }
        public void InsertImages(string path)
        {
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.ColumnCount - 1];
                Image image = Image.FromFile($@"{path}");
                image = resizeImage(image, new Size(50, 50));
                cell.Value = image;
            }
        }
    }


}
