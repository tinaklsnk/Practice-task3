using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public partial class Goods
    {
        int id;
        string name;
        float price;
        string type;
        string producer;
        int warranty;
        string path;
        Image photo;
        public Goods(int id, string name, float price, string type, string producer, int warranty, string path)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.producer = producer;
            this.warranty = warranty;
            this.path = path;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public string Producer { get => producer; set => producer = value; }
        public int Warranty { get => warranty; set => warranty = value; }
        public string Path { get => path; set => path = value; }
        [NotMapped]
        public Image Photo
        {
            get
            {
                if (!string.IsNullOrEmpty(Path))
                {
                    if (File.Exists(Path))
                        
                        return Image.FromFile(Path);
                }
                return null;
            }
            set => photo = value;
        }

    }
}
