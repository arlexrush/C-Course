using System;
using System.Collections.Generic;

namespace Video68_Delegado_predicado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,17 });
            Predicate<int> eldelegadoPred = new Predicate<int>(DamePares);
            List<int> numPares = listaNumeros.FindAll(eldelegadoPred);
            foreach(int element in numPares)
            {
                Console.WriteLine(element);
            }
            Predicate<int> eldelegadoPred2 = new Predicate<int>(DamePrimos);
            List<int> numPrimos = listaNumeros.FindAll(eldelegadoPred2);
            foreach(int elem in numPrimos)
            {
                Console.WriteLine(elem);
            }
        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        static bool DamePrimos(int num2)
        {
            double i = 2;

            while (i <= num2/i)
            {

                if (num2 % i == 0)
                {
                    return false;
                }

            
                i++;
            }

            return true;
                 
                
                                  
        }
    }
}
