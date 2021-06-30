using System;

namespace Video9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnpantalla();
            sumaNumeros(10, 15);
            Console.WriteLine($"La suma de Enteros: {sumaEnteros(4, 5)}");
            Console.WriteLine($"La División de Reales: {divideNumeros(16, 5)}"); // Esta nomenclatura es valida si y solo si el metodo tiene una sola linea de codigo.
        }

        // metodos sin return, usan void.
        static void mensajeEnpantalla()
        {
            Console.WriteLine("Mensaje en Pantalla");
        }

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es:" + (num1 + num2));
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
        }

        // Metodos con return, sustituye el void por el tipo de datos que debe retornar el metodo.
        static int sumaEnteros(int num1, int num2)
        {
            return num1 + num2;
            // Console.WriteLine(num1+num2); da un error de codigo inaccesible.
        }

        // otra forma de declarar el metodo.
        
        static double divideNumeros(double num1, int num2) => num1 / num2;
    }
}
