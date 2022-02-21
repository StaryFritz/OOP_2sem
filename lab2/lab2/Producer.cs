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
    public partial class Producer : Form
    {
        Product productForm;
        public Producer()
        {
            InitializeComponent();
        }
        public Producer(Product form)
        {
            InitializeComponent();
            productForm = form;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            ProducerClass producer = new ProducerClass(Organisation.Text, Country.Text, Adress.Text, PhoneNumber.Text);
            productForm.ProducerInfo.Text = Organisation.Text;
            Close();
        }
    }
    public class ProducerClass
    {
        string organisation, country, adress, phoneNumber;
        public ProducerClass(string organisation, string country, string adress, string phoneNumber)
        {
            this.organisation = organisation;
            this.country = country;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }
    }
}
