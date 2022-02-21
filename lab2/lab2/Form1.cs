using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void AddProducer_Click(object sender, EventArgs e)
        {
            Producer newForm = new Producer(this);
            newForm.Show();
        }
    }
}
