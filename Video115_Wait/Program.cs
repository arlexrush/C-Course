using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Video115_Wait
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTodasTareas();
            Console.ReadLine();
        }

        static void realizarTodasTareas()
        {
            var tarea1=Task.Run(() =>
            {
                ejecutarTarea();
            });

            tarea1.Wait();

            var tarea2=Task.Run(() =>
            {
                ejecutarTarea1();
            });

            tarea2.Wait();

            //Task.WaitAny(tarea1, tarea2);

            var tarea3=Task.Run(() =>
            {
                ejecutarTarea2();
            });
        }

        static void ejecutarTarea()
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Esta vuelta de bucle A N°:{i}, corresponde a la Tarea N° 1");
            }
        }

        static void ejecutarTarea1()
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Esta vuelta de bucle A N°:{i}, corresponde a la Tarea N° 2");
            }
        }

        static void ejecutarTarea2()
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(250);
                Console.WriteLine($"Esta vuelta de bucle C N°:{i}, corresponde a la Tarea N° 3");
            }
        }
    }
}
