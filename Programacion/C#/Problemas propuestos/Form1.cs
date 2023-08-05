using System;
using System.Windows.Forms;

namespace Problemas_propuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
        }
        //EJERCICIO 1
        private void button1_Click(object sender, EventArgs e)
        {
            int n, i;
            i = 0;
            n = int.Parse(textBox1.Text);
            while (i <= n)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }
        //EJERCICIO 2
        private void button2_Click(object sender, EventArgs e)
        {
            int n, i;
            i = int.Parse(textBox2.Text);
            n = int.Parse(textBox3.Text);
            while (i <= n)
            {
                listBox2.Items.Add(i);
                i++;
            }
        }
        //EJERCICIO 3
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox4.Text);
            textBox4.Clear();
        }
        private void buttonN_Click(object sender, EventArgs e)
        {
            int s, i;
            i = 1;
            Random p = new Random();
            while (i <= 5)
            {
                s = p.Next(1, 100);
                listBox3.Items.Add(s);
                i++;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int i, n, c;
            string codigo;
            double nota, promedio, s;
            codigo = textBox5.Text;
            i = 0;
            s = 0;
            c = 0;
            n = listBox3.Items.Count;
            while (i < n)
            {
                nota = double.Parse(listBox3.Items[i].ToString());
                if (nota > 1)
                {
                    s = s + nota;
                    c = c + 1;
                }
                i++;
            }
            promedio = s / c;
            listBox4.Items.Add("El codigo " + codigo + " tiene un promedio de " + promedio);
            listBox3.Items.Clear();
            textBox5.Clear();
        }
        //EJERCICIO 4
        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(textBox6.Text);
            textBox6.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int i, n;
            double s, sl;
            i = 0;
            n = listBox5.Items.Count;
            while (i < n)
            {
                s = double.Parse(listBox4.Items[i].ToString());
                if (s > 1500)
                {
                    sl = s + s * 0.05;
                    listBox6.Items.Add(sl);
                }
                else
                {
                    if (s >= 800 && s <= 1500)
                    {
                        sl = s + s * 0.10;
                        listBox6.Items.Add(sl);
                    }
                    if (s < 800)
                    {
                        sl = s + s * 0.20;
                        listBox6.Items.Add(sl);
                    }
                }
                i++;
            }
        }
        //EJERCICIO 5
        private void button7_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add(textBox7.Text);
            textBox7.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int n, i, s, nu;
            i = 0;
            s = 0;
            n = listBox7.Items.Count;
            while (i < n)
            {
                nu = int.Parse(listBox7.Items[i].ToString());
                if (nu % 3 == 0)
                {
                    s = s + nu;
                }
                i++;
            }
            textBox8.Text = s.ToString();

        }
        //EJERCICIO 6
        private void button9_Click(object sender, EventArgs e)
        {
            int n, i, r;
            i = 1;
            n = int.Parse(textBox9.Text);
            while (i <= 10)
            {
                r = n * i;
                listBox8.Items.Add(n + "x" + i + "=" + r);
                i++;
            }

        }
        //EJERCICIO 7
        private void button10_Click_1(object sender, EventArgs e)
        {
            int s, i, n;
            i = 1;
            n = int.Parse(textBox10.Text);
            Random p = new Random();
            while (i <= n)
            {
                s = p.Next(0, 40);
                listBox9.Items.Add(s);
                i++;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int c1, c2, c3, c4, i, n, niños;
            i = 0;
            c1 = 0;
            c2 = 0;
            c3 = 0;
            c4 = 0;
            n = listBox9.Items.Count;
            while (i < n)
            {
                niños = int.Parse(listBox9.Items[i].ToString());
                if (niños >= 0 && niños <= 10)
                {
                    c1 = c1 + 1;
                    textBox11.Text = c1.ToString();
                }
                else
                {
                    if (niños > 10 && niños <= 20)
                    {
                        c2 = c2 + 1;
                        textBox12.Text = c2.ToString();
                    }
                    else
                    {
                        if (niños > 20 && niños <= 30)
                        {
                            c3 = c3 + 1;
                            textBox13.Text = c3.ToString();
                        }
                        else
                        {
                            if (niños > 30)
                                c4 = c4 + 1;
                            textBox14.Text = c4.ToString();
                        }
                    }
                }
                i++;
            }
        }
        //EJERCICIO 8
        private void button12_Click(object sender, EventArgs e)
        {
            string n;
            double n1, n2, n3, pro;
            n = textBox18.Text;
            n1 = double.Parse(textBox15.Text);
            n2 = double.Parse(textBox16.Text);
            n3 = double.Parse(textBox17.Text);
            pro = (n1 + n2 + n3) / 3;
            listBox10.Items.Add("El estudiante " + n + " tiene un promedio de " + pro);
        }
        //EJERCICIO 9
        private void button13_Click(object sender, EventArgs e)
        {
            double n, s, r;
            s = 0;
            n = 10;
            while (n <= 50)
            {
                label16.Text = label16.Text + "1/" + n + "  ";
                r = 1 / n;
                s = s + r;
                n++;
            }
            textBox19.Text = s.ToString();
        }
        //EJERCICIO 10
        private void button14_Click(object sender, EventArgs e)
        {
            string n, g;
            double h, s, t;
            n = textBox20.Text;
            g = textBox21.Text;
            h = double.Parse(textBox22.Text);
            s = double.Parse(textBox23.Text);
            t = s * h;
            if (g == "M")
            {
                listBox11.Items.Add(n + " = " + t + "Bs");
            }
            if (g == "F")
            {
                listBox12.Items.Add(n + " = " + t + "Bs");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            
            double h, s, t,  v, prom, v2, prom2;
            int cf, i, c;
            cf = 0; 
            i = 0;
            h = double.Parse(textBox22.Text);
            s = double.Parse(textBox23.Text);
            t = s * h;
            c = listBox11.Items.Count;
            v = double.Parse(listBox13.Items[i].ToString());
            v = v + t;
            prom = v / c;
            clear();
            listBox13.Items.Add(v);
            listBox13.Items.Add(prom);


            cf = listBox9.Items.Count;
            v2 = double.Parse(listBox12.Items[i].ToString());
            v2 = v2 + t;
            prom2 = v2 / cf;
            clearF();
            listBox12.Items.Add(v2);
            listBox12.Items.Add(prom2);
        }
        private void clear()
        {
            listBox11.Items.Clear();
        }
        private void clearF()
        {
            listBox12.Items.Clear();
        }
    }

}
