using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA5
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
            
            if(radioButton1.Checked)
            {
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                a = Math.Sqrt( b * b + c * c);
                textBox1.Text=a.ToString(); 
            }
            if (radioButton2.Checked)
            {
                a = double.Parse(textBox1.Text);
                c = double.Parse(textBox3.Text);
                b = Math.Sqrt( a  * a + c * c);
                textBox2.Text = b.ToString();
            }
            if (radioButton3.Checked)
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = Math.Sqrt( a * a + b * b);
                textBox3.Text = c.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
        }
    }
}
