using System;

namespace Video16_If3B
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // If anidados
            
            char carnetUser = 'N';

            Console.WriteLine("Por favor Introduzca su edad");
            int edadUser = Int32.Parse(Console.ReadLine());

            if (edadUser < 18) Console.WriteLine("Lo siento, usted no puede conducir vehiculos");
            else
            {
                Console.WriteLine("¿Tiene Carnet (Y/N)?");
                carnetUser = Convert.ToChar(Console.ReadLine());
                int compara = string.Compare(Convert.ToString(carnetUser), Convert.ToString('Y'), true);
                // Console.WriteLine(compara);

                if (compara == 0) Console.WriteLine("Felicidades, usted puede conducir vehiculos");
                else Console.WriteLine("Lo siento, usted NO puede condicir vehiculos");
            }
        }
    }
}
