using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime F;
            F = dateTimePicker1.Value;
            label1.Text = F.ToString();
            int dia = F.Day;
            int mes = F.Month;
            int año = F.Year;
            label1.Text= " Hoy es " + dia.ToString() + " de " + mes.ToString() + " del año " + año .ToString();
                

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fe,fs;
            fe = dateTimePicker1.Value;
            fs = dateTimePicker2.Value;
            int est = fs.Day - fe.Day;
            String p = textBox1.Text;
            int prec = 500 * est;
            label1.Text = " Cliente " + p.ToString() + " Su estadia fue de " + est.ToString() + " dias el monto a cancelar es " + prec.ToString() + " bs, Por la " + comboBox1.Text.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fe, fs;
            fe = dateTimePicker1.Value;
            fs = dateTimePicker2.Value;
            int est = fs.Day - fe.Day;
            String p = textBox1.Text;
            if (comboBox1.Text== "Tipo A")
            {             
                int precA = 200 * est;
                label1.Text = " Cliente " + p.ToString() + " Su estadia fue de " + est.ToString() + " dias el monto a cancelar es " + precA.ToString() + " bs, Por la Habitacion " + comboBox1.Text.ToString();
            }
            if(comboBox1.Text== "Tipo B")
            {
                int precB = 300 * est;
                label1.Text = " Cliente " + p.ToString() + " Su estadia fue de " + est.ToString() + " dias el monto a cancelar es " + precB.ToString() + " bs, Por la Habitacion " + comboBox1.Text.ToString();
            }
            if(comboBox1.Text== "Tipo C")
            {
                int precC = 400 * est;
                label1.Text = " Cliente " + p.ToString() + " Su estadia fue de " + est.ToString() + " dias el monto a cancelar es " + precC.ToString() + " bs, Por la Habitacion " + comboBox1.Text.ToString();
            }
        }

    }

}
