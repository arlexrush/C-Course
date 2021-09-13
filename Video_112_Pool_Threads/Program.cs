using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Video_112_Pool_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                //Thread t = new Thread(ejecutarTarea);
                //t.Start();
                ThreadPool.QueueUserWorkItem(ejecutarTarea,i);
                
            }

            Console.ReadLine();
            
        }

        static void ejecutarTarea(Object o)
        {
            int ntask = (int)o;
            Console.WriteLine($"thread N°: {Thread.CurrentThread.ManagedThreadId} Ha comenzado la tarea"+ntask);
            Thread.Sleep(1000);
            Console.WriteLine($"thread N°: {Thread.CurrentThread.ManagedThreadId} Ha terminado la tarea"+ntask);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
