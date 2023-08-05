using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f, k, cf, ck, fc, fk, kc, kf;
            c=double.Parse(textBox1.Text);  
            f=double.Parse(textBox1.Text);
            k=double.Parse(textBox1.Text);
            if (comboBox1.Text == "Celsius" & comboBox2.Text == "Fahrenheit")
            {
                cf = (9 * c / 5) + 32;
                textBox2.Text = cf.ToString();
            }
            if (comboBox1.Text == "Celsius" & comboBox2.Text == "Kelvin")
            {
                ck = c + 273.15;
                textBox2.Text = ck.ToString();
            }
            if (comboBox1.Text == "Fahrenheit" & comboBox2.Text == "Celsius")
            {
                fc = 5 * (f - 32) / 9;
                textBox2.Text = fc.ToString();

            }
            if (comboBox1.Text == "Fahrenheit" & comboBox2.Text == "Kelvin")
            {
                fk = (5 * (f - 32) / 9) + 273.15;
                textBox2.Text = fk.ToString();
            }
            if (comboBox1.Text == "Kelvin" & comboBox2.Text == "Celsius")
            {
                kc = k - 273.15;
                textBox2.Text = kc.ToString();
            }
            if (comboBox1.Text == "Kelvin" & comboBox2.Text == "Fahrenheit")
            {
                kf = (9*(k - 273.15) / 5) + 32;
                textBox2.Text = kf.ToString();
            }



        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double h,m,s,hm,hs,mh,ms,sh,sm
            c = double.Parse(textBox1.Text);
            f = double.Parse(textBox1.Text);
            k = double.Parse(textBox1.Text);
            if (comboBox1.Text == "Celsius" & comboBox2.Text == "Fahrenheit")
            {
                cf = (9 * c / 5) + 32;
                textBox2.Text = cf.ToString();
            }
            if (comboBox1.Text == "Celsius" & comboBox2.Text == "Kelvin")
            {
                ck = c + 273.15;
                textBox2.Text = ck.ToString();
            }
            if (comboBox1.Text == "Fahrenheit" & comboBox2.Text == "Celsius")
            {
                fc = 5 * (f - 32) / 9;
                textBox2.Text = fc.ToString();

            }
            if (comboBox1.Text == "Fahrenheit" & comboBox2.Text == "Kelvin")
            {
                fk = (5 * (f - 32) / 9) + 273.15;
                textBox2.Text = fk.ToString();
            }
            if (comboBox1.Text == "Kelvin" & comboBox2.Text == "Celsius")
            {
                kc = k - 273.15;
                textBox2.Text = kc.ToString();
            }
            if (comboBox1.Text == "Kelvin" & comboBox2.Text == "Fahrenheit")
            {
                kf = (9 * (k - 273.15) / 5) + 32;
                textBox2.Text = kf.ToString();
            }
        }
    }

}



