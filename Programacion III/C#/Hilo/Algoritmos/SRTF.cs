namespace Hilo.Algoritmos
{
    class SRTF : Hilo
    {
        public int TiempoEspera { get; set; }
        public int TiempoRespuesta { get; set; }

        private List<SRTF> list = new List<SRTF>();

        public void Limpiar()
        {
            list.Clear();
        }

        public void Agregar(SRTF hilo)
        {
            list.Add(hilo);
        }

        public List<SRTF> Ejecutar()
        {
            List<SRTF> listaSRTF = new List<SRTF>();
            int tiempoEspera = 0;
            int tiempoRespuesta = 0;

            while (list.Count > 0)
            {
                // Ordenar los hilos restantes por tiempo de ráfaga restante de forma ascendente
                list.Sort((x, y) => x.Burst_time.CompareTo(y.Burst_time));

                SRTF hilo = list[0];
                hilo.TiempoEspera = tiempoEspera;
                tiempoEspera += hilo.Burst_time; // Usar la propiedad Proceso

                // Ejecutar el proceso completo
                tiempoRespuesta += hilo.Burst_time;
                hilo.TiempoRespuesta = tiempoRespuesta;

                // Actualizar los tiempos de espera y respuesta
                //hilo.TiempoEspera = tiempoTotal - hilo.Arrival_time - hilo.Burst_time;
                //hilo.TiempoRespuesta = tiempoTotal - hilo.Arrival_time;

                // Eliminar el hilo ejecutado de la lista
                listaSRTF.Add(hilo);
                list.RemoveAt(0);
            }
            return listaSRTF;
        }
    }
}


