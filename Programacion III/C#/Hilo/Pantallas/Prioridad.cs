namespace Hilo.Pantallas
{
    public partial class Prioridad : Form
    {
        Algoritmos.Prioridad salida = new Algoritmos.Prioridad();
        int proceso = 1;
        int arrivaltime = 0;
        public Prioridad()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Algoritmos.Prioridad hilo = new Algoritmos.Prioridad();
            if (string.IsNullOrEmpty(InputBurts.Text) || string.IsNullOrEmpty(InputPrioridad.Text))
            {
                MessageBox.Show("Campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int burts = int.Parse(InputBurts.Text);
                int prioridad = int.Parse(InputPrioridad.Text);
                hilo.Proceso = proceso;
                hilo.Arrival_time = arrivaltime;
                hilo.Burst_time = burts;
                hilo.Priorida = prioridad;
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
            List<Algoritmos.Prioridad> listaPrioridad = salida.Algoritmo();
            Salida.Text = "";
            label2.Text = "Proceso                Burst Time                Wainting Time                Turnaround Time";
            foreach (Algoritmos.Prioridad hilo in listaPrioridad)
            {
                Salida.Text += $"P{hilo.Proceso}                                 {hilo.Burst_time}                                           {hilo.TiempoEspera}                                                {hilo.TiempoRespuesta}\n";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            proceso = 1;
            arrivaltime = 0;
            salida.Limpiar();
        }
    }
}
