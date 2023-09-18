using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public class PriorityQueue
    {
        private List<Solicitud> solicitudes;

        public PriorityQueue()
        {
            solicitudes = new List<Solicitud>();
        }

        public void Enqueue(Solicitud solicitud)
        {
            int index = 0;

            // Buscar la posición correcta para insertar el elemento según la urgencia
            while (index < solicitudes.Count && solicitud.Urgencia <= solicitudes[index].Urgencia)
            {
                index++;
            }

            // Insertar el elemento en la posición encontrada
            solicitudes.Insert(index, solicitud);
        }

        public Solicitud Dequeue()
        {
            if (solicitudes.Count == 0)
            {
                throw new InvalidOperationException("La cola de prioridad está vacía");
            }

            Solicitud topPriorityRequest = solicitudes[0];
            solicitudes.RemoveAt(0);
            return topPriorityRequest;
        }

        public List<Solicitud> GetOrderedQueue()
        {
            // Devuelve una copia ordenada de la cola sin eliminar los elementos originales
            List<Solicitud> orderedQueue = new List<Solicitud>(solicitudes);
            return orderedQueue;
        }

        public int Count
        {
            get { return solicitudes.Count; }
        }
    }
} 
