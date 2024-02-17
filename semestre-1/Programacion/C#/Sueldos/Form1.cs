using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); 
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n, i;
            double s,ss,afp,sl;
            i = 1;
            ss= 0;
            n= listBox1.Items.Count;
            while (i<=n)
            {
                s = double.Parse(listBox1.Items[i-1].ToString());
                afp = s * 0.127;
                if (s>2164)
                {
                    sl = s - afp;
                    ss = ss + sl;
                }
                i= i + 1;
            }
            label1.Text = "La suma total de los sueldos que ganan mayor al minimo nacional son de " + ss +"bs".ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n, i;
            double s, sM,sm;
            i = 1;
            sM = 0;
            sm = 10000;
            n = listBox1.Items.Count;
            while (i <= n)
            {
                s = double.Parse(listBox1.Items[i-1].ToString());
                if(s>sM)
                {
                    sM = s;
                }
                if(s<sm)
                {
                    sm = s;
                }
                i = i + 1;
            }
            label2.Text = "El sueldo mayor de la lista es " + sM + "bs y el sueldo menor de la lista es " + sm + "bs".ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "".ToString();
            label2.Text = "".ToString();
        }
    }
}
