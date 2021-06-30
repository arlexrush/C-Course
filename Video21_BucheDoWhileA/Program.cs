using System;

namespace Video21_BucheDoWhileA
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 10;

            while (z < 10)
            {
                Console.WriteLine("Impresion" + z);
                z++;
            }
            while (z < 14)
            {
                Console.WriteLine("Impresion" + z + z);
                z++;
            }
            do
            {
                Console.WriteLine("Impresion" + z);
                z++;
            } while (z <= 25);
        }
    }
}
