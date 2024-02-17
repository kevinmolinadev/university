using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                                                //ejercicio 1
        private void button1_Click(object sender, EventArgs e)
        {
            double cll, t;
            cll = double.Parse(textBox1.Text);
            if(cll<5)
            {
                t = cll * 800;
                textBox2.Text = t.ToString();
            }
            else
            {
                if(cll>=5)
                {
                    t = cll * 700;
                    textBox2.Text = t.ToString()+" Bs";
                }
           
            }
            
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cExamnen1, cExamnen2, cExamenfinal, cPracticos,NotaT,Estado;
            cExamnen1 = double.Parse(textBox3.Text);
            cExamnen2 = double.Parse(textBox4.Text);
            cExamenfinal = double.Parse(textBox5.Text);
            cPracticos = double.Parse(textBox6.Text);
            cExamnen1 = cExamnen1 * 20 / 100;
            cExamnen2 = cExamnen2 * 20 / 100;
            cExamenfinal = cExamenfinal * 40 / 100;
            cPracticos = cPracticos * 20 / 100;
            NotaT = cExamnen1 + cExamnen2 + cExamenfinal + cPracticos;
            textBox7.Text = NotaT.ToString();
            if (NotaT >= 51)
            {
                textBox8.Text = "Aprobado";
            }
            else
            {
                if(NotaT<51)
                {
                    textBox8.Text = "Reprobado";
                }
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
