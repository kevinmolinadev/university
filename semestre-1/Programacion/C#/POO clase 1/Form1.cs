using System;
using System.Windows.Forms;

namespace ghsef
{
    public partial class Form1 : Form
    {
        Punto p = new Punto();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.X = int.Parse(textBox1.Text);
            p.Y = int.Parse(textBox2.Text);
 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = p.X.ToString();
            label4.Text = p.Y.ToString();
            textBox3.Text = p.verificar();




        }
    }
}
