using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public static class SoporteTecnico

    {
        public static void AgregarSolicitud(int numero, string nombre, string descripcion, int urgencia, PriorityNameQueue priorityNameQueue)
        {
            Solicitud solicitud = new Solicitud(numero, nombre, descripcion, urgencia);
            priorityNameQueue.Enqueue(solicitud);
        }

        public static void AtenderSolicitudes(PriorityNameQueue priorityNameQueue)
        {
            List<Solicitud> SolicitudesAtendidas = priorityNameQueue.Dequeue();

            if (SolicitudesAtendidas.Count > 0)
            {
                foreach (var solicitud in SolicitudesAtendidas)
                {
                    Console.WriteLine(solicitud);
                }
                Console.WriteLine("Solicitudes atendidas");
            }
            else
            {
                Console.WriteLine("No hay solicitudes a atender");
            }
        }

        public static void VerSolicitudes(PriorityNameQueue priorityNameQueue)
        {
            List<Solicitud> SolicitudesOrdenadas = priorityNameQueue.GetOrderedQueue();
            foreach (var solicitud in SolicitudesOrdenadas)
            {
                Console.WriteLine(solicitud);
            }
        }

        public static void ActualizarUrgencia(int numeroSolicitud, int NuevaUrgencia, PriorityNameQueue priorityNameQueue)
        {


            // Buscar la solicitud en la cola por su número de solicitud
            Solicitud Solicitud_a_Actualizar = null;
            foreach (var solicitud in priorityNameQueue.GetOrderedQueue())
            {
                if (solicitud.NumeroSolicitud == numeroSolicitud)
                {
                    Solicitud_a_Actualizar = solicitud;
                    break;
                }
            }

            if (Solicitud_a_Actualizar != null)
            {
                Console.WriteLine($"La urgencia actual de la solicitud #{Solicitud_a_Actualizar.NumeroSolicitud}: {Solicitud_a_Actualizar.Urgencia}");

                // Actualizar el nivel de urgencia de la solicitud
                Solicitud_a_Actualizar.Urgencia = NuevaUrgencia;

                Console.WriteLine($"La urgencia ha sido actualizada de la solictud #{Solicitud_a_Actualizar.NumeroSolicitud} updated to {NuevaUrgencia}");
            }
            else
            {
                Console.WriteLine($"Request #{numeroSolicitud} not found in the queue.");
            }
        }

    }
}