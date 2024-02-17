using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hilo.Algoritmos;

namespace Hilo.Pantallas
{
    public partial class SJF : Form
    {
        private Algoritmos.SJF sjf;
        private int tiempoLlegada;
        int id = 1;

        public SJF()
        {
            InitializeComponent();
            sjf = new Algoritmos.SJF();
            tiempoLlegada = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int rafaga = int.Parse(txtRafaga.Text);

            Algoritmos.SJF hilo = new Algoritmos.SJF();
            hilo.Proceso = id;
            hilo.Arrival_time = tiempoLlegada;
            hilo.Burst_time = rafaga;

            sjf.Agregar(hilo);
            id++;
            tiempoLlegada++;

            // Limpiar los campos de entrada
            txtRafaga.Text = string.Empty;
            txtRafaga.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            sjf.Limpiar();
            tiempoLlegada = 0;
            listBox1.Items.Clear();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            sjf.Ejecutar();

            // Mostrar los tiempos de espera y respuesta en una ListBox
            listBox1.Items.Clear();
            foreach (Algoritmos.SJF hilo in sjf.ObtenerHilos())
            {
                listBox1.Items.Add($"Proceso {hilo.Proceso}: BusrtTime = {hilo.Burst_time}, Tiempo de espera = {hilo.TiempoEspera}, Tiempo de respuesta = {hilo.TiempoRespuesta}");
            }
        }
    }
}
