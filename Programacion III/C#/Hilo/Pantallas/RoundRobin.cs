using System.Diagnostics;

namespace Hilo.Pantallas
{
    public partial class RoundRobin : Form
    {
        Algoritmos.RoundRobin salida = new Algoritmos.RoundRobin();
        int proceso = 1;
        int arrivaltime = 0;
        public RoundRobin()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Algoritmos.RoundRobin hilo = new Algoritmos.RoundRobin();
            if (string.IsNullOrEmpty(InputBurts.Text))
            {
                MessageBox.Show("Campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int burts = int.Parse(InputBurts.Text);
                hilo.Proceso = proceso;
                hilo.Arrival_time = arrivaltime;
                hilo.Burst_time = burts;
                hilo.BurstOriginal = burts;
                hilo.Agregar(hilo);
                proceso++;
                arrivaltime++;
                //MessageBox.Show("Se agrego el proceso correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InputBurts.Clear();
                InputBurts.Focus();
            }

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputQuantum.Text))
            {
                MessageBox.Show("Ingrese el tiempo del Quantum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                InputQuantum.ReadOnly = true;
                int quantum = int.Parse(InputQuantum.Text);
                List<Algoritmos.RoundRobin> listaRoundRobin = salida.Algoritmo(quantum);
                Salida.Text = "";
                label2.Text = "Proceso                Burst Time                Turnaround Time";
                foreach (Algoritmos.RoundRobin hilo in listaRoundRobin)
                {
                    Salida.Text += $"P{hilo.Proceso}                                 {hilo.BurstOriginal}                                           {hilo.TiempoRespuesta}\n";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Salida.Text = "";
            proceso = 1;
            arrivaltime = 0;
            InputQuantum.Clear();
            InputQuantum.ReadOnly = false;
            salida.Limpiar();
        }
    }
}
