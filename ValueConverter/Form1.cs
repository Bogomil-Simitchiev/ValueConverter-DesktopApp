using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

       

        

       

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            double bgn = double.Parse(textBox1.Text);
            double sum = bgn * 0.60;
            label2.Text = $"{bgn:F2}" + " leva =" + " " + $"{sum:F2}" + " $";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double usd = double.Parse(textBox1.Text);
            double sum = usd * 1.66;
            label2.Text = $"{usd:F2}" + " $ =" + " " + $"{sum:F2}" + " leva";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double bgn = double.Parse(textBox1.Text);
            double sum = bgn * 0.51;
            label2.Text = $"{bgn:F2}" + " leva =" + " " + $"{sum:F2}" + " €";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double eur = double.Parse(textBox1.Text);
            double sum = eur * 1.96;
            label2.Text = $"{eur:F2}" + " € =" + " " + $"{sum:F2}" + " leva";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double eur = double.Parse(textBox1.Text);
            double sum = eur * 1.18;
            label2.Text = $"{eur:F2}" + " € =" + " " + $"{sum:F2}" + " $";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double usd = double.Parse(textBox1.Text);
            double sum = usd * 0.85;
            label2.Text = $"{usd:F2}" + " $ =" + " " + $"{sum:F2}" + " €";
        }
    }
}
