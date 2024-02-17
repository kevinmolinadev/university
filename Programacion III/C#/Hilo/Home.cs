namespace Hilo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallas.FCFS FCFS = new Pantallas.FCFS();
            FCFS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantallas.SJF SJF = new Pantallas.SJF();
            SJF.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantallas.SRTF SRTF = new Pantallas.SRTF();
            SRTF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantallas.RoundRobin Round = new Pantallas.RoundRobin();
            Round.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantallas.Prioridad Prioridad = new Pantallas.Prioridad();
            Prioridad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantallas.Multi_level Multi = new Pantallas.Multi_level();
            Multi.Show();
        }
    }
}