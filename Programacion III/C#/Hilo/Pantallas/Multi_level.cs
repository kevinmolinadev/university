using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hilo.Algoritmos;

namespace Hilo.Pantallas
{
    public partial class Multi_level : Form
    {
        private Algoritmos.Multi_level multiLevel;
        private int tiempoLlegada;
        int id = 1;

        public Multi_level()
        {
            InitializeComponent();
            multiLevel = new Algoritmos.Multi_level();
            tiempoLlegada = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nivel = int.Parse(txtNivel.Text);
            int rafaga = int.Parse(txtRafaga.Text);

            Hilo.Algoritmos.Multi_level hilo = new Hilo.Algoritmos.Multi_level();
            hilo.Arrival_time = tiempoLlegada;
            hilo.Burst_time = rafaga;
            hilo.Proceso = id;
            multiLevel.AgregarHilo(nivel, hilo);
            id++;
            tiempoLlegada++;

            // Limpiar los campos de entrada
            txtNivel.Text = string.Empty;
            txtRafaga.Text = string.Empty;

            txtRafaga.Focus();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //multiLevel.Ejecutar();
            // Mostrar los tiempos de espera y respuesta en una ListBox
            listBox1.Items.Clear();
            foreach (Algoritmos.Multi_level hilo in multiLevel.Ejecutar())
            {
                listBox1.Items.Add($"Proceso {hilo.Proceso}: BurstTime = {hilo.Burst_time},  Tiempo de espera = {hilo.TiempoEspera}, Tiempo de respuesta = {hilo.TiempoRespuesta}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            multiLevel.Limpiar();
            tiempoLlegada = 0;
            listBox1.Items.Clear();
        }
    }
}
