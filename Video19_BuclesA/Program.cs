using System;

namespace Video19_BuclesA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseas entrar en el bucle While?");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle While");
                Console.WriteLine("Introduce tu nombre Por favor:");
                string nombre = Console.ReadLine();
                Console.WriteLine($"saldrás del bucle {nombre}cuandorespondas no a la pregunta");
                Console.WriteLine("¿Desear repetir otra vez?");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Has salido del Bucle");
        }
    }
}
