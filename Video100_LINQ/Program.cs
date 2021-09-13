using System;
using System.Collections.Generic;
using System.Linq;

namespace Video100_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valorNumerico = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares: ");

            List<int> numerosPares = new List<int>();

            foreach(int i in valorNumerico)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
            }

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }

            int[] Numeros= new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares: ");

            IEnumerable<int> NumeroPares = from numero in Numeros where numero % 2 == 0 select numero;

            foreach(int i in NumeroPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
