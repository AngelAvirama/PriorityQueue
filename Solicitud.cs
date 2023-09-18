using SolicitudesSoprteTecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public class Solicitud
    {
        public int NumeroSolicitud { get; set; }
        public string Nombre { get; set; }


        public string Problema { get; set; }

        public int Urgencia { get; set; }

        public Solicitud(int numeroSolicitud, string nombre, string problema, int urgencia)
        {
            NumeroSolicitud = numeroSolicitud;
            Nombre = nombre;
            Problema = problema;
            Urgencia = urgencia;


        }

        public override string ToString()
        {
            String representation = $"Request #{NumeroSolicitud}\n" +
                                   $"Customer:{Nombre}\n" +
                                   $"Problem Description:{Problema}\n" +
                                   $"Urgency Level: {Urgencia}\n";

            return representation;

        }
    }

}
