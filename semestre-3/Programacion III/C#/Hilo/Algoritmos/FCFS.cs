namespace Hilo.Algoritmos
{
    internal class FCFS : Hilo
    {
        public int TiempoEspera { get; set; }
        public int TiempoRespuesta { get; set; }

        private static List<FCFS> list = new List<FCFS>();

        public void Agregar(FCFS hilo)
        {
            list.Add(hilo);

        }

        public void Limpiar()
        {
            list.Clear();
        }

        public List<FCFS> Algoritmo()
        {
            List<FCFS> listaFCFS = new List<FCFS>();
            int tiempoEspera = 0;
            int tiempoRespuesta = 0;
            foreach (FCFS hilo in list)
            {
                //Aqui le asignamos el tiempo de espera al hilo actual
                hilo.TiempoEspera = tiempoEspera;
                tiempoRespuesta += hilo.Burst_time;
                tiempoEspera += hilo.Burst_time;
                //Aqui le asignamos el tiempo de respuesta al hilo actual
                hilo.TiempoRespuesta= tiempoRespuesta;
                //Agregamo el hilo con su tiempo de espera y respuesta agregado al hilo para poder utilizarlo en la llamada desde el form
                listaFCFS.Add(hilo);
            }
            return listaFCFS;
        }
    }
}
