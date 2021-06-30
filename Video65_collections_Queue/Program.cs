using System;
using System.Collections.Generic;

namespace Video65_collections_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            
                // rellenando elementos a la cola

            foreach(int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }

            // Recorriendo la cola

            Console.WriteLine("recoirriendo el QUEUE");

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Eliminando elemntos de QUEUE

            Console.WriteLine("Eliminando Elementos");
            numeros.Dequeue();

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();

            // Cuantos Elementos tiene el QUEUE

            Console.WriteLine(numeros.Count);

            Console.WriteLine();

                // hacer una copia del QUEUE en formato de Array

            Queue<int> queueCopy = new Queue<int>(numeros.ToArray());

            foreach(int element in queueCopy)
            {
                Console.WriteLine(element);
            }

        }
    }
}
