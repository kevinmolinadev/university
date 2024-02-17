using Hilo.Algoritmos;
using System.Threading;
namespace Hilo.Pantallas
{
    public partial class FCFS : Form
    {
        Algoritmos.FCFS salida = new Algoritmos.FCFS();
        int proceso = 1;
        int arrivaltime = 0;
        public FCFS()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputBurts.Text))
            {
                MessageBox.Show("Campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Algoritmos.FCFS hilo = new Algoritmos.FCFS();
                int burts = int.Parse(InputBurts.Text);
                hilo.Proceso = proceso;
                hilo.Arrival_time = arrivaltime;
                hilo.Burst_time = burts;
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
            List<Algoritmos.FCFS> listaFCFS = salida.Algoritmo();
            label2.Text = "Proceso                Burst Time                Wainting Time                Turnaround Time";
            foreach (Algoritmos.FCFS hilo in listaFCFS)
            {
                Salida.Text += $"P{hilo.Proceso}                                 {hilo.Burst_time}                                           {hilo.TiempoEspera}                                                {hilo.TiempoRespuesta}\n";
                Thread.Sleep(1000);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Salida.Text = "";
            proceso = 1;
            arrivaltime = 0;
            salida.Limpiar();
        }
    }
}
