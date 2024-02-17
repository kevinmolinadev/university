using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M, A;
            string C;
            C=textBox1.Text;
            M=double.Parse(textBox2.Text);
            A=double.Parse(textBox3.Text);
            double T = A * 12;
            double D = M * T;
            double Ganancias= D+D*0.02;
            label5.Text= " El cliente " + C + " ahorro durante " + A + " años un monto de " +M+"bs" + " El banco le paga a razon de un 2% mesual, sus ganancias fueron " + Ganancias+"bs".ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Examen_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Años, Hm;
            string Tr;
            Tr=textBox4.Text;
            Años=double.Parse(textBox5.Text);
            Hm=double.Parse(textBox6.Text);
            double Sm = Hm * 80;
            double Sa= Sm* 12;
            if(Años<5)
            {
                double l = Sa * 0.018;
                double G = Sa - l;
                textBox7.Text = G + "Bs".ToString();
            }
            if(Años>=5)
            {
                double f = Sa * 0.05;
                double G=Sa+f;
                textBox7.Text = G + "Bs".ToString();
            }
            label9.Text = " El trabajador " + Tr + " tiene un sueldo anual de " + textBox7.Text.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            x1=double.Parse(textBox8.Text);
            y1=double.Parse(textBox9.Text);
            x2=double.Parse(textBox10.Text);
            y2=double.Parse(textBox11.Text);
            double v = x2 - x1;
            double m = v * v;
            double n=y2 - y1;
            double c = n * n;
            double t = m + c;
            double Distancia=Math.Sqrt(t);
            textBox12.Text=Distancia.ToString();    
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
