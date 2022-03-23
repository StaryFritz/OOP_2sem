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
        ProductForm productForm;
        public Producer()
        {
            string[] countries = { "Беларусь", "Украина", "Польша", "Тайвань", "США" };
            Country.Items.AddRange(countries);
            InitializeComponent();
        }
        public Producer(ProductForm form)
        {
            InitializeComponent();
            string[] countries = { "Беларусь", "Украина", "Польша", "Тайвань", "США" };
            Country.Items.AddRange(countries);
            productForm = form;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            ProducerClass producer = new ProducerClass(Organisation.Text, Country.Text, Adress.Text, PhoneNumber.Text);
            productForm.Producer.Text = producer.ToString();
            productForm.producer = producer;
            Close();
        }
        private void Organisation_Validating(object sender, CancelEventArgs e)
        {
            if (Organisation.Text.Length == 0)
                errorProvider1.SetError(Organisation, "Можно вводить только цифры");
            else
                errorProvider1.Clear();
        }

        private void Adress_Validating(object sender, CancelEventArgs e)
        {
            if (Adress.Text.Length == 0)
                errorProvider1.SetError(Adress, "Введите значение");
            else
                errorProvider1.Clear();
        }

        private void Country_Validating(object sender, CancelEventArgs e)
        {
            if (Country.SelectedItem == null)
                errorProvider1.SetError(Country, "Выберите страну");
            else
                errorProvider1.Clear();
        }

        private void PhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (PhoneNumber.Text.Any(c => !char.IsDigit(c)))
                errorProvider1.SetError(PhoneNumber, "Можно вводить только цифры");
            else if (PhoneNumber.Text.Length == 0)
                errorProvider1.SetError(PhoneNumber, "Введите значение");
            else
                errorProvider1.Clear();
        }
    }
    [Serializable]
    public class ProducerClass
    {
        string Organisation { get; set; }
        string Country { get; set; }
        string Adress { get; set; }
        string PhoneNumber { get; set; }
        public ProducerClass(string organisation, string country, string adress, string phoneNumber)
        {
            Organisation = organisation;
            Country = country;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return Organisation;
        }
    }
}
