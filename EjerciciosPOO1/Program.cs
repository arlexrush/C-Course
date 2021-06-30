using System;

namespace EjerciciosPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche MiCoche = new Coche(001, "Chevrolet", "Montana", 180000, 30000);

            Console.WriteLine(MiCoche.toString());
        }
    }
}
