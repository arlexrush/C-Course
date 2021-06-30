using System;

namespace Video17_If3D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura else If
            
            Console.WriteLine("Introduzca su Edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad <= 18) Console.WriteLine("Eres un niño");
            else if (edad <= 30) Console.WriteLine("Eres un Joven");
            else if (edad <= 60) Console.WriteLine("Eres Maduro");
            else Console.WriteLine("Debes Cuidarte");

            // Evalua el primer if, luego else if, despues el siguiente else if, hasta que llegue al primero que se cumpla, ejecuta las instrucciones y regresa al flujo del metodo Main.

        }
    }
}
