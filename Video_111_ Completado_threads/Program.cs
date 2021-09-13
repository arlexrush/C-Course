using System;
using System.Threading;
using System.Threading.Tasks;

namespace Video_111__Completado_threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(()=> {
            
                for (int i=0; i<5;i++)
                {
                    Console.WriteLine("Hilo1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });
            

            var hilo2 = new Thread(() => {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo2");
                    Thread.Sleep(1000);
                }

            });

            var hilo3 = new Thread(() => {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo3");
                    Thread.Sleep(1000);
                }

            });

            hilo1.Start();

            var resultado = tareaTerminada.Task.Result;

            hilo2.Start();

            hilo3.Start();
        }
    }
}
