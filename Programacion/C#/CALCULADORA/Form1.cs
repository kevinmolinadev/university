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
            String Binario = "";
            while (Decimal > 0)
            {
                Binario = Decimal % 2 + Binario;
                Decimal = Decimal / 2;
            }
            textBox2.Text = Binario;
        }
        private void convertirDaH()
        {
            String hexadecimal = "";
            double residuo = 0;
            int Decimal= int.Parse(textBox1.Text);
            do
            {
                residuo = ((double)(Decimal)) / 16;
                Decimal = Decimal / 16;
                residuo = (residuo - Decimal) * 16;
                if (residuo == 10)
                    hexadecimal = "A" + hexadecimal;
                else if (residuo == 11)
                    hexadecimal = "B" + hexadecimal;
                else if (residuo == 12)
                    hexadecimal = "C" + hexadecimal;
                else if (residuo == 13)
                    hexadecimal = "D" + hexadecimal;
                else if (residuo == 14)
                    hexadecimal = "E" + hexadecimal;
                else if (residuo == 15)
                    hexadecimal = "F" + hexadecimal;
                else
                    hexadecimal = residuo + hexadecimal;
            } while (Decimal != 0);
            textBox3.Text=hexadecimal;

        }
        private void convertirDaO()
        {
            int Decimal;
            Decimal = Convert.ToInt32(textBox1.Text);
            OctalFuncion(Decimal);
        }
        void OctalFuncion(int Decimal)
        {
            String Octal = "";
            while (Decimal > 0)
            {
                Octal = Decimal % 8 + Octal;
            }
            textBox4.Text = Octal;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            convertirDaB();
            convertirDaH();
            convertirDaO();
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
