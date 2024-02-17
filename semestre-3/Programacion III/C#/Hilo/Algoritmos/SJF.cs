using System;
using System.Collections.Generic;
using System.Linq;

namespace Hilo.Algoritmos
{
    internal class SJF : Hilo
    {
        public int TiempoEspera { get; set; }
        public int TiempoRespuesta { get; set; }

        private List<SJF> list = new List<SJF>();

        public void Limpiar()
        {
            list.Clear();
        }

        public void Agregar(SJF hilo)
        {
            list.Add(hilo);
        }

        public void Ejecutar()
        {
            // Ordenar los hilos por tiempo de ráfaga (burst time) de forma ascendente
            list.Sort((x, y) => x.Burst_time.CompareTo(y.Burst_time));

            int tiempoTotal = 0;
            int procesoActual = 0;

            foreach (SJF hilo in list)
            {
                procesoActual = hilo.Proceso;

                // Ejecutar el proceso completo
                tiempoTotal += hilo.Burst_time;

                // Actualizar los tiempos de espera y respuesta
                hilo.TiempoEspera = tiempoTotal - hilo.Burst_time;
                hilo.TiempoRespuesta = tiempoTotal;

                // Actualizar el tiempo total con el tiempo de espera
                tiempoTotal += hilo.TiempoEspera;
            }
        }

        public List<SJF> ObtenerHilos()
        {
            return list;
        }

    }
}

