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
using System.Text.Json;
using System.Runtime.Serialization.Json;

namespace lab2
{
    public partial class ProductForm : Form
    {
        public ProducerClass producer;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void AddProducer_Click(object sender, EventArgs e)
        {
            Producer newForm = new Producer(this);
            newForm.Show();
        }
        public override string ToString()
        {
            return ProductName.Text;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.Name = ProductName.Text;
            product.Num = ProductNum.Text;
            product.Size = ProductSize.Text;
            product.Weight = ProductWeight.Text;
            product.Type = ProductType.Text;
            product.Date = ProductDate.SelectionStart.ToString();
            product.Count = ProductCount.Text;
            product.Cost = ProductCost.Text;
            product.MyProducer = producer;
            Products.Items.Add(product);
        }

        private void WriteJSON_Click(object sender, EventArgs e)
        {
            using (var sw = new FileStream("file.txt", FileMode.Create))
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(Product));
                jsonFormatter.WriteObject(sw, Products.SelectedItem);
                ProductName.Text = "";
                ProductNum.Text = "";
                ProductSize.Text = "";
                ProductWeight.Text = "";
                ProductType.Text = "";
                ProductDate.SelectionStart = DateTime.Today;
                ProductCount.Text = "";
                ProductCost.Text = "";
                Producer.Text = "";
            }
        }

        private void ReadJSON_Click(object sender, EventArgs e)
        {
            using (var file = new FileStream("file.txt", FileMode.Open))
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(Product));
                var deserialized = jsonFormatter.ReadObject(file) as Product;
                ProductName.Text = deserialized.Name;
                ProductNum.Text = deserialized.Num;
                ProductSize.Text = deserialized.Size;
                ProductWeight.Text = deserialized.Weight;
                ProductType.Text = deserialized.Type;
                ProductDate.SelectionStart = Convert.ToDateTime(deserialized.Date);
                ProductCount.Text = deserialized.Count;
                ProductCost.Text = deserialized.Cost;
                Producer.Text = deserialized.MyProducer.ToString();
            }
        }
        private void Char_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Any(c => !char.IsDigit(c)))
                errorProvider1.SetError((TextBox)sender, "Можно вводить только цифры");
            else
                errorProvider1.Clear();
        }
        private void Length_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
                errorProvider1.SetError((TextBox)sender, "Введите значение");
            else
                errorProvider1.Clear();
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finder finder = new Finder(((System.Windows.Forms.ToolStripMenuItem)sender).Text, this);
            finder.Show();
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Num { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Count { get; set; }
        public string Cost { get; set; }
        public ProducerClass MyProducer { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
