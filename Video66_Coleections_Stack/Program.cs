using System;
using System.Collections.Generic;

namespace Video66_Coleections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            foreach(int element in new int[] { 2, 4, 6, 8, 10, 12, 14, 16 })
            {
                numeros.Push(element);
            }

            foreach(int element1 in numeros)
            {
                Console.WriteLine(element1);
            }

        }
    }
}
