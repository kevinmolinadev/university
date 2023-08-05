using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hilo.Algoritmos;

namespace Hilo.Pantallas
{
    public partial class SRTF : Form
    {
        private Algoritmos.SRTF srtf = new Algoritmos.SRTF();
        private int tiempoLlegada;
        int id = 1;

        public SRTF()
        {
            InitializeComponent();
            tiempoLlegada = 0;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int rafaga = int.Parse(txtRafaga.Text);

            Algoritmos.SRTF hilo = new Algoritmos.SRTF();
            hilo.Proceso = id;
            hilo.Arrival_time = tiempoLlegada;
            hilo.Burst_time = rafaga;
            id++;
            srtf.Agregar(hilo);

            tiempoLlegada++;

            // Limpiar los campos de entrada
            txtRafaga.Text = string.Empty;
            txtRafaga.Focus();
        }

        private void btnEjecutar_Click_1(object sender, EventArgs e)
        {
            // Mostrar los tiempos de espera y respuesta en una ListBox
            listBox1.Items.Clear();
            foreach (Algoritmos.SRTF hilo in srtf.Ejecutar())
            {
                listBox1.Items.Add($"Proceso {hilo.Proceso}: Burst Time = {hilo.Burst_time} Tiempo de espera = {hilo.TiempoEspera}, Tiempo de respuesta = {hilo.TiempoRespuesta}");
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            srtf.Limpiar();
            tiempoLlegada = 0;
            listBox1.Items.Clear();
        }
    }
}
