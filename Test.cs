using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolicitudesSoprteTecnico
{
    public static class Test
    {
        public static List<String> StringDataRequests = FileHandling.ReadFile("C:\\Users\\avira\\source\\repos\\SolicitudesSoprteTecnico\\SolicitudesSoprteTecnico\\txtSolicitudes.txt");

        public static void testCode(int numberOfRequests, PriorityNameQueue queueTest)
        {
            Stopwatch enqueueStopwatch = new Stopwatch(); // Cronómetro para medir el encolado
            enqueueStopwatch.Start();

            for (int i = 0; i < numberOfRequests; i++)
            {
                string[] dataRequest = StringDataRequests[i].Split(',');
                Solicitud newRequest = new Solicitud(Convert.ToInt32(dataRequest[0]), dataRequest[1], dataRequest[2], Convert.ToInt32(dataRequest[3]));

                queueTest.Enqueue(newRequest); // La solicitud se encola en la cola proporcionada
                Console.WriteLine(i + ". Encolando..." + newRequest);
            }

            enqueueStopwatch.Stop();
            long enqueueTimeMilli = enqueueStopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Tiempo encolando {numberOfRequests} solictudes: {enqueueTimeMilli} Milisegundos");
        }


        /*Stopwatch dequeueStopwatch = new Stopwatch();
        dequeueStopwatch.Start();

        for (int i = 0; i < numberOfRequests; i++)
        {

            Request dequeueRequest = queueTest.Dequeue();

            Console.WriteLine(i + ". DEQUEUING..." + dequeueRequest);
        }
        dequeueStopwatch.Stop();
        long dequeueTimeMilli = dequeueStopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Time Dequeuing {numberOfRequests} elements: {dequeueTimeMilli} Milliseconds");*/
    }



}
