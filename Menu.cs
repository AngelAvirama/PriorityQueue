using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public static class Menu
    {
        public static void MostrarMenu() //If auto is -1 we ask for an input
        {

            int opcion = 0;
            int cont = 1;
            bool continueMenu = true;
            PriorityNameQueue priorityQueue = new PriorityNameQueue();

            //for instance
            while (continueMenu)
            {

                VerMenu();
                opcion = Convert.ToInt32(Console.ReadLine()); //Using inputs

                switch (opcion)
                {
                    case 1:



                        int NumeroSolicitud = cont;

                        cont++;

                        Console.Write("Ingresa el nombre: ");

                        string Nombre = Console.ReadLine();

                        Console.Write("Describe el problema: ");

                        string descripcion = Console.ReadLine();

                        Console.Write("Nivel de urgencia: ");

                        int Urgencia = Convert.ToInt32(Console.ReadLine());


                        SoporteTecnico.AgregarSolicitud(NumeroSolicitud, Nombre, descripcion, Urgencia, priorityQueue);
                        break;
                    case 2:
                        SoporteTecnico.AtenderSolicitudes(priorityQueue);
                        break;
                    case 3:
                        SoporteTecnico.VerSolicitudes(priorityQueue);
                        break;
                    case 4:

                        Console.WriteLine("Ingrese el numero de solicitud que quiere actualizar: ");
                        int numeroSolicitud = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el nuevo nivel de urgencia: ");
                        int NuevaUrgencia = Convert.ToInt32(Console.ReadLine());

                        SoporteTecnico.ActualizarUrgencia(numeroSolicitud, NuevaUrgencia, priorityQueue);
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el numero de solicitudes que quiere agregar:");
                        int numeroSolicitudes = Convert.ToInt32(Console.ReadLine());

                        Test.testCode(numeroSolicitudes, priorityQueue);
                        break;
                    case 6:
                        continueMenu = false;
                        break;
                }
            }

        }

        public static void VerMenu()
        {
            Console.WriteLine("Bienvenido:\n" +
                "\n1.Agregar Solicitud" +
                "\n2.Atender solicitudes" +
                "\n3.Ver solicitudes" +
                "\n4.Actualizar Urgencia" +
                "\n5.Cargar Archivo" +
                "\n6.Salir" +
                "\nElige una opcion: ");
        }
    }
}
