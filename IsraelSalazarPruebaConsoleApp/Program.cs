using System;
using System.Threading;

namespace IsraelSalazarPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread primerHilo = new Thread(PersonasEnEdificio);
            Thread segundoHilo = new Thread(PersonasEnEdificio);

            Console.WriteLine("Ejecutare primerHilo");
            primerHilo.Start();

            Console.WriteLine("Ejecutare segundoHilo");
            segundoHilo.Start();

            Thread.Sleep(500);

            Console.WriteLine("El primerHilo se junta");
            primerHilo.Join();
            Console.WriteLine("El segundoHilo se junta");
            segundoHilo.Join();
        }

        static void PersonasEnEdificio()
        {
            int personasEdificio = 0;

            var hiloActual = Thread.CurrentThread;

            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId);


            for (int i = 1; i <= 96; i++)
            {
                var personas = new Random().Next(1, 6);
                Console.WriteLine("Hilo {0} ", hiloActual.ManagedThreadId);
                personasEdificio += personas;

                Thread.Sleep(1000);
            }
            Console.WriteLine("Total de  persona en el edificico son " + personasEdificio);

        }
    }
}
