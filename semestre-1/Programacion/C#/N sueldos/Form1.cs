using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_sueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b,cM,cm;
            double s;
            a=int.Parse(textBox1.Text);
            cM = 0;
            cm = 0;
            b = 1;
            while(b<=a)
            {
                s = 1000;
                if(s>2164)
                {
                    cM = cM + 1;
                }
                else
                {
                    cm = cm + 1;
                }
                textBox2.Text = cM.ToString();
                textBox3.Text = cm.ToString();
            }
        }
    }
}
