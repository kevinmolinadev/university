namespace Hilo.Algoritmos
{
    internal class Prioridad : Hilo
    {
        public int TiempoEspera { get; set; }
        public int TiempoRespuesta { get; set; }
        public int Priorida { get; set; }

        private static List<Prioridad> list = new List<Prioridad>();

        public void Agregar(Prioridad hilo)
        {
            list.Add(hilo);
        }

        public void Limpiar()
        {
            list.Clear();
        }

        public List<Prioridad> Algoritmo()
        {
            List<Prioridad> listaPrioridad = new List<Prioridad>();

            list.Sort((h1, h2) => h1.Priorida.CompareTo(h2.Priorida));

            int tiempoEspera = 0;

            foreach (Prioridad hilo in list)
            {
                hilo.TiempoEspera = tiempoEspera;
                tiempoEspera += hilo.Burst_time;
                hilo.TiempoRespuesta = tiempoEspera;

                listaPrioridad.Add(hilo);
            }

            return listaPrioridad;
        }
    }
}
