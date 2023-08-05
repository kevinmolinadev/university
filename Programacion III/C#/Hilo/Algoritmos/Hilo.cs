namespace Hilo.Algoritmos
{
    internal class Hilo
    {
        private int proceso;
        private int arrival_time;
        private int burst_time;

        public int Proceso
        {
            get { return proceso; }
            set { proceso = value; }
        }

        public int Arrival_time
        {
            get { return arrival_time; }
            set { arrival_time = value; }
        }

        public int Burst_time
        {
            get { return burst_time; }
            set { burst_time = value; }
        }
    }
}
