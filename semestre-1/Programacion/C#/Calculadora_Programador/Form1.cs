using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double op1, op2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            double.Parse(textBox1.Text = textBox1.Text + ",");
        }
        

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            op = '*';
            textBox1.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            op = '+';
            textBox1.Clear();


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            op = '^';
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            double rs = op1 * op1* op1;
            textBox1.Text = rs.ToString();
           
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            double rs = op1 * op1;
            textBox1.Text=rs.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op1 = double.Parse(textBox1.Text);
            double rs = Math.Sqrt(op1);
            textBox1.Text = rs.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void convertirDaB()
        {
            int Decimal = int.Parse(textBox1.Text);
            textBox2.Text = Convert.ToString(Decimal, 2);
        }
        private void convertirDaH()
        {
            
            int Decimal= int.Parse(textBox1.Text);
            textBox3.Text=Convert.ToString(Decimal,16);
            

        }
        private void convertirDH()
        {
            int Decimal = int.Parse(textBox1.Text);
            textBox3.Text = Convert.ToString(Decimal, 16);
        }
        private void convertirDaO()
        {
            int Decimal=int.Parse(textBox1.Text);
            textBox4.Text=Convert.ToString(Decimal,8);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            convertirDaB();
            convertirDaH();
            convertirDaO();
            
        }

        private void Opuesto()
        {
            double r=double.Parse(textBox1.Text);
            double o = r * -1;
            textBox1.Text=o.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           Opuesto();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            op2 = double.Parse(textBox1.Text);
            double rs;
            if (op == '+')
            {
                rs = op1 + op2;
                textBox1.Text =rs.ToString();
            }
            if (op == '-')
            {
                rs = op1 - op2;
                textBox1.Text = rs.ToString();
            }
            if (op == '*')
            {
                rs = op1 * op2;
                textBox1.Text = rs.ToString();
            }
            if (op == '/')
            {
                rs = op1 / op2;
                textBox1.Text = rs.ToString();
            }
            if (op == '^')
            {
                rs =Math.Pow(op1,op2);
                textBox1.Text = rs.ToString();
            }
            
            
        }

        
    }
}
