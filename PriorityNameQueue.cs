using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public class PriorityNameQueue : PriorityQueue
    {
        private List<Queue<Solicitud>> Lotes;

        public PriorityNameQueue()
        {
            Lotes = new List<Queue<Solicitud>>();
            // Inicializar las colas para cada nivel de urgencia
            for (int i = 15; i >= 0; i--)
            {
                Lotes.Add(new Queue<Solicitud>());
            }
        }

        public new void Enqueue(Solicitud solicitud)
        {
            base.Enqueue(solicitud); // Utiliza el método Enqueue de la clase base para mantener la prioridad por urgencia

            // Agrega la solicitud a la cola correspondiente al nivel de urgencia
            Lotes[solicitud.Urgencia].Enqueue(solicitud);
        }

        public List<Solicitud> Dequeue()
        {
            List<Solicitud> Solicitudes = new List<Solicitud>();

            for (int i = Lotes.Count - 1; i >= 0; i--)
            {
                if (Lotes[i].Count > 0)
                {
                    while (Lotes[i].Count > 0)
                    {
                        Solicitud dequeuedRequest = Lotes[i].Dequeue();
                        Solicitudes.Add(dequeuedRequest);
                    }
                    break; // Solo atiende el primer lote con mayor urgencia y luego sale del bucle
                }
            }
            
            return Solicitudes;
        }


        public List<Solicitud> GetOrderedQueue()
        {
            List<Solicitud> PilaOrdenada = new List<Solicitud>();

            // Recorre las colas por nivel de urgencia y agrega las solicitudes ordenadas por nombre
            for (int i = Lotes.Count - 1; i >= 0; i--)
            {
                List<Solicitud> sortedRequests = Lotes[i].OrderBy(r => r.Nombre).ToList();
                PilaOrdenada.AddRange(sortedRequests);
            }

            return PilaOrdenada;
        }


    }

}
