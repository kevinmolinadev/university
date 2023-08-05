using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYECTO_CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tu()
        {
            double a = double.Parse(textBox2.Text);
            double z = Math.Cos(a);
            textBox3.Text = z.ToString();
            
        }

        private void CbtnIgual_Click(object sender, EventArgs e)
        {
            tu();
        }
    }
}
