using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox4.Text);
            b = double.Parse(textBox5.Text);
            c = a * b;
            textBox6.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox7.Text);
            b = double.Parse(textBox8.Text);
            c = a / b;
            textBox9.Text = c.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
