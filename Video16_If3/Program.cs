using System;

namespace Video16_If3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Particularidades de IF
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Por favor Introduzca su edad");
            int edadUser = Int32.Parse(Console.ReadLine());
            char carnetUser = 'N';

            if (edadUser >= 18)
            {
                Console.WriteLine("¿Tienes Carnet (Y/N)?");
                carnetUser = Convert.ToChar(Console.ReadLine());
            }

            if (edadUser >= 18 && carnetUser == 'Y')
            {
                Console.WriteLine("Usted Puede Conducir Vehiculo");
            }
            else
            {
                Console.WriteLine("Lo siento, usted NO puede Conducir Vehiculo");

            }

            
        }
    }
}
