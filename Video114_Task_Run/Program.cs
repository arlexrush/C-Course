using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Video114_Task_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea = Task.Run(() => ejecutarTarea());  // Simplifica la intanciación y la ejecución del task

            Task tarea2 = tarea.ContinueWith(ejecutarOtraTarea);

            Console.ReadLine();
        }

        static void ejecutarTarea()
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(100);
                Console.WriteLine($"Esta vuelta de bucle A N°:{i}, corresponde al Thread N°:" + miThread);
            }
        }

        static void ejecutarOtraTarea(Task obj)
        {
            for (int j = 0; j < 10; j++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(100);
                Console.WriteLine($"Esta vuelta de bucle B N°:{j}, corresponde al Thread N°:" + miThread);
            }
        }
    }
}
