using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Video108_threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Metodosaludo);
            t.Start();
            t.Join();

            Thread t2 = new Thread(Metodosaludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hola Alumnos desde thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 1");
            Thread.Sleep(1000);
            
            //Metodosaludo();

        }

        static void Metodosaludo()
        {
            

            Console.WriteLine("Hola Alumnos desde thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola Alumnos desde thread 2");
            Thread.Sleep(1000);
        }
    }
}
