using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Finder : Form
    {
        string FindType { get; set; }
        ProductForm product;
        public Finder()
        {
            InitializeComponent();
        }
        public Finder(string findType, ProductForm product)
        {
            FindType = findType;
            this.product = product;
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            switch (FindType)
            {
                case "названию":
                    Regex regex = new Regex($@"{findingString.Text}");
                    foreach (var item in product.Products.Items) 
                    {
                        if (regex.IsMatch(item.ToString()))
                        {
                            findingResult.Items.Add(item);
                        }
                    }
                    break;
                case "типу":
                    regex = new Regex($@"\w*{findingString.Text}\w*");
                    foreach (var item in product.Products.Items)
                    {
                        if (regex.IsMatch(((Product)item).Type))
                        {
                            findingResult.Items.Add(item);
                        }
                    }
                    break;
                case "диапазону цены":
                    string a = findingString.Text.Substring(0, findingString.Text.IndexOf(','));
                    string b = findingString.Text.Substring(findingString.Text.IndexOf(',')+1);
                    regex = new Regex($@"[{a}-{b}]+");
                    foreach (var item in product.Products.Items)
                    {
                        if (regex.IsMatch(((Product)item).Cost))
                        {
                            findingResult.Items.Add(item);
                        }
                    }
                    break;
            }
        }
    }
}
