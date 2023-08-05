namespace Hilo.Algoritmos
{
    internal class RoundRobin : Hilo
    {
        public int TiempoRespuesta { get; set; }
        public int BurstOriginal { get; set; }

        private static List<RoundRobin> list = new List<RoundRobin>();

        public void Agregar(RoundRobin hilo)
        {
            list.Add(hilo);

        }

        public void Limpiar()
        {
            list.Clear();
        }

        public List<RoundRobin> Algoritmo(int quantum)
        {
            List<RoundRobin> listaRoundRobin = new List<RoundRobin>();
            int tiempoRespuesta = 0;


            for (int i = 0; i < list.Count; i++)
            {
                RoundRobin hilo = list[i];
                if (hilo.Burst_time <= quantum)
                {
                    tiempoRespuesta += Tiempo(hilo);
                    hilo.TiempoRespuesta = tiempoRespuesta;
                    listaRoundRobin.Add(hilo);
                    list.Remove(hilo);
                    i--; // Disminuir el índice después de eliminar un elemento de la lista
                }
                else
                {
                    tiempoRespuesta += Tiempo(hilo);
                    list.Add(hilo);
                }
            }
            return listaRoundRobin;

            int Tiempo(RoundRobin hilo)
            {
                int time = 0;
                if (hilo.Burst_time <= quantum)
                {
                    time = hilo.Burst_time;
                    //hilo.Burst_time = 0;
                }
                else
                {
                    time = quantum;
                    hilo.Burst_time -= quantum;
                }
                return time;
            }
        }

    }
}