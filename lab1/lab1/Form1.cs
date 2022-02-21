using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            MyCalculator = new Calculator();
        }

        Calculator MyCalculator;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = ((Button)sender).Text;
            else
                textBox1.Text += ((Button)sender).Text;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            MyCalculator.Sin(this);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            MyCalculator.Cos(this);
        }

        private void tang_Click(object sender, EventArgs e)
        {
            MyCalculator.Tg(this);
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            MyCalculator.Ctg(this);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            MyCalculator.Sqrt(this);
        }

        private void Cbrt_Click(object sender, EventArgs e)
        {
            MyCalculator.CubeRoot(this);
        }

        private void pow_Click(object sender, EventArgs e)
        {
            MyCalculator.Pow(this);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            MyCalculator.Equals(this);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            MyCalculator.Clear(this);
        }
        private void ChangeSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = textBox1.Text.Insert(0, "-");
        }

        interface ICalculator
        {
            public void Sin(Form1 form);
            public void Cos(Form1 form);
            public void Tg(Form1 form);
            public void Ctg(Form1 form);
            public void Sqrt(Form1 form);
            public void CubeRoot(Form1 form);
            public void Pow(Form1 form);
            public void Equals(Form1 form);
            public void Clear(Form1 form);
        }
        public class Calculator : ICalculator
        {
            public void Sin(Form1 form)
            {
                form.textBox1.Text = Math.Sin(Convert.ToDouble(form.textBox1.Text)).ToString();
            }
            public void Cos(Form1 form)
            {
                form.textBox1.Text = Math.Cos(Convert.ToDouble(form.textBox1.Text)).ToString();
            }
            public void Tg(Form1 form)
            {
                form.textBox1.Text = Math.Tan(Convert.ToDouble(form.textBox1.Text)).ToString();
            }
            public void Ctg(Form1 form)
            {
                form.textBox1.Text = (1 / Math.Tan(Convert.ToDouble(form.textBox1.Text))).ToString();
            }
            public void Sqrt(Form1 form)
            {
                if (form.textBox1.Text.StartsWith("-"))
                    throw new Exception("Нельзя найти корень отрицательного числа");
                else
                    form.textBox1.Text = Math.Sqrt(Convert.ToDouble(form.textBox1.Text)).ToString();
            }
            public void CubeRoot(Form1 form)
            {
                form.textBox1.Text = Math.Cbrt(Convert.ToDouble(form.textBox1.Text)).ToString();
            }
            public void Pow(Form1 form)
            {
                form.textBox1.Text += "^";
            }
            public void Equals(Form1 form)
            {
                double firstNum = Convert.ToDouble(form.textBox1.Text.Substring(0, form.textBox1.Text.IndexOf("^")));
                double secondNum = Convert.ToDouble(form.textBox1.Text.Substring(form.textBox1.Text.IndexOf("^") + 1));
                form.textBox1.Text = Math.Pow(firstNum, secondNum).ToString();
            }
            public void Clear(Form1 form)
            {
                form.textBox1.Text = "0";
            }
        }

        private void TextInput(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Any(c => char.IsLetter(c)))
                throw new Exception("Нельзя вводить символы");
        }
    }
}
