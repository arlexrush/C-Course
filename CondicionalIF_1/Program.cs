using System;

namespace CondicionalIF_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables Booleanas.

            bool haceFrio;
            haceFrio = true;

            Console.WriteLine(!haceFrio);

            // Condicional If.

            int edad = 19;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if (edad >= 18)
            {
                Console.WriteLine("Adelante puedes pasar porque eres mayor de edad");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vamos a Evaluar su puedes conducir un vehiculo");
            bool carnet = false;

            // Uso de else.

            if (carnet)
            {
                Console.WriteLine("Puedes conducir vehiculo");
            }
            else
            {
                Console.WriteLine("Lo siento usted no puede conducir vehiculos");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Por favor Introduzca su edad");
            int edadUser = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿Tienes Carnet (Y/N)?");
            char carnetUser =  Convert.ToChar(Console.ReadLine());

            if(edadUser>= 18  &&  carnetUser == 'Y')
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
 