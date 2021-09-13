using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Video_113_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea = new Task(ejecutarTarea);
            tarea.Start();

            Task tarea2 = new Task(()=> {
                for (int j = 0; j < 100; j++)
                {
                    var miThread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(100);
                    Console.WriteLine($"Esta vuelta de bucle B N°:{j}, corresponde al Thread N°:" + miThread);
                }


            });
            tarea2.Start();

            Console.ReadLine();
        }

        static void ejecutarTarea()
        {
            for (int i = 0; i < 100; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(100);
                Console.WriteLine($"Esta vuelta de bucle N°:{i}, corresponde al Thread N°:" + miThread);
            }
        }
    }
}
