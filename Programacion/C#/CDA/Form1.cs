using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P, D;
            P = double.Parse(textBox1.Text);
            if(P>2000)
            {
                D = P - P * 0.020;
                textBox2.Text=D.ToString(); 
            }
            if(P>=1001 & P<=2000)
            {
                D = P - P * 0.010;
                textBox2.Text = D.ToString();
            }
            if(P>=501 & P<=1000)
            {
                D = P - P * 0.05;
                textBox2.Text = D.ToString();
            }
            if (P<500)
            {
                D = P; 
                textBox2.Text = D.ToString();
            }

        }
    }
}
