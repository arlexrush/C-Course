using System;
using System.Collections.Generic;

namespace Video64_Colecciones_linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int num in new int[] {10, 8, 6, 4, 2, 0 })
            {
                numeros.AddFirst(num); // puede usar de la misma manera AddLast(num)
            }

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            for (LinkedListNode <int> nodo=numeros.First; nodo!=null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value);
                
            }  
        }
    }
}
