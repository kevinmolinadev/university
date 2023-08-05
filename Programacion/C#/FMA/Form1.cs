using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMA
{
    public partial class FMA : Form
    {
        public FMA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = float.Parse(textBox2.Text);
            b = float.Parse(textBox3.Text);        
            c = a / b;
            textBox1.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = float.Parse(textBox3.Text);
            b = float.Parse(textBox1.Text);
            c = a / b;
            textBox2.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
