using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA6
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
      
        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox10.Text);
            double b = double.Parse(textBox9.Text);
            double s, m, d;
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();

            if (checkBox6.Checked)
            {
                s = a + b;
                textBox8.Text = s.ToString();

            }
            if (checkBox5.Checked)
            {
                m = a * b;
                textBox7.Text = m.ToString();

            }
            if (checkBox4.Checked)
            {
                d = a / b;
                textBox6.Text = d.ToString();

            }
            if (checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                s = a + b;
                m = a * b;
                d = a / b;
                textBox8.Text = s.ToString();
                textBox7.Text = m.ToString();
                textBox6.Text = d.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(N1.Text);
            double b = int.Parse(D1.Text);
            double c = int.Parse(N2.Text);
            double l= int.Parse(D2.Text);
            if (Suma.Checked)
            {
                double s1 = b * l;
                R2.Text = s1.ToString();
                double s2 = (s1 / b) * a;
                double s3 = (s1 / l) * c;
                double s4 = s2 + s3;
                R1.Text = s4.ToString();
            }
            if (Resta.Checked)
            {
                double r1 = b * l;
                R2.Text = r1.ToString();
                double r2 = (r1 / b) * a;
                double r3 = (r1 / l) * c;
                double r4 = r2 - r3;
                R1.Text = r4.ToString();
            }
            if (Multiplicacion.Checked)
            {
                double m1 = a*c;
                R1.Text = m1.ToString();
                double m2 = b * l;
                R2.Text = m2.ToString();
            }
            if (Division.Checked)
            {
                double d1 = a * l;
                R1.Text = d1.ToString();
                double m2 = b * c;
                R2.Text = m2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            N1.Clear();
            N2.Clear();
            D1.Clear();
            D2.Clear();
            R1.Clear();
            R2.Clear();
        }
    }

}
