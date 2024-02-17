using System;
using System.Collections.Generic;
using System.Linq;
using Hilo.Algoritmos;
using Hilo.Pantallas;

namespace Hilo.Algoritmos
{
    internal class Multi_level : Hilo
    {
        public int TiempoEspera { get; set; }
        public int TiempoRespuesta { get; set; }

        private  List<Multi_level> queues = new List<Multi_level>();
        private  List<Multi_level> queues2 = new List<Multi_level>();

        public void Limpiar()
        {
            queues.Clear();
            queues2.Clear();
        }

        public void AgregarHilo(int nivel, Multi_level hilo)
        {
            if (nivel >= queues.Count)
            {
                // Agregar una nueva cola para el nivel si no existe
                for (int i = queues.Count; i <= nivel; i++)
                {
                    queues.Add(new Multi_level());
                }
            }

            queues[nivel].queues.Add(hilo);
        }
        public List<Multi_level> Ejecutar()
        {
            int tiempoTotal = 0;
            int nivelActual = 0;
            List<Multi_level> hilosEjecutados = new List<Multi_level>();

            while (queues.Exists(queue => queue.queues.Count > 0))
            {
                // Obtener el siguiente hilo a ejecutar según el nivel actual
                Multi_level hilo = null;

                while (hilo == null && nivelActual < queues.Count)
                {
                    if (queues[nivelActual].queues.Count > 0)
                    {
                        hilo = queues[nivelActual].queues[0];
                        queues[nivelActual].queues.RemoveAt(0);
                    }
                    else
                    {
                        nivelActual++;
                    }
                }

                if (hilo == null)
                {
                    // Si no hay hilos en los niveles superiores, reiniciar al nivel 0
                    nivelActual = 0;
                    continue;
                }

                // Actualizar los tiempos de espera y respuesta
                hilo.TiempoEspera = tiempoTotal;
                tiempoTotal += hilo.Burst_time;
                hilo.TiempoRespuesta = tiempoTotal;

                hilosEjecutados.Add(hilo);
            }
            return hilosEjecutados;
        }

        /*public List<Multi_level> ObtenerHilos()
        {
            List<Multi_level> hilos = new List<Multi_level>();

            foreach (Multi_level queue in queues)
            {
                hilos.AddRange(queue.queues);
            }

            return hilos;
        }*/
    }
}


