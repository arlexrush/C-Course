using System;

namespace Video22_excepcionesA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es un programa para hallar el Valor de un numero aleatorio entre (0,100).

            Console.WriteLine("RANDOM HUNTER v1.0");
            Console.WriteLine();
            Random numero = new();
            int numAle = numero.Next(0, 100);
            // Console.WriteLine(numAle);
            Console.WriteLine("Se ha Generado un numero Aleatorio entre 0 y 100.");
            Console.WriteLine("Trate de identificar el numero a traves de aproximaciones.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Por favor introduzca su primera aproximación:");
            int numApp=1000;
            try
            {
                numApp = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Ha introducido un caracter NO VALIDO, por favor ingrese un numero entre 0 y 100");
                
            }
            //Console.WriteLine(numApp);
            int contadorApp = 1;
            while (numApp != numAle)
            {
                if (numApp <= 100 && numApp >= 0)
                {
                    if (numApp > numAle)
                    {
                        Console.WriteLine("Su Aproximación es Mayor que el numero Aleatorio");
                        Console.WriteLine();
                        Console.WriteLine("Por favor introduzca otra aproximación menor:");
                        try
                        {
                            numApp = Int32.Parse(Console.ReadLine());
                        }catch(FormatException ex)
                        {
                            Console.WriteLine("Ha introducido un caracter NO VALIDO, por favor ingrese un numero entre 0 y 100");
                        }
                        contadorApp++;
                    }
                    else
                    {
                        Console.WriteLine("Su Aproximación es Menor que el numero Aleatorio");
                        Console.WriteLine();
                        Console.WriteLine("Por favor introduzca otra aproximación mayor:");
                        try
                        {
                            numApp = Int32.Parse(Console.ReadLine());
                        }catch(FormatException ex)
                        {
                            Console.WriteLine("Ha introducido un caracter NO VALIDO, por favor ingrese un numero entre 0 y 100");
                        }
                        
                        contadorApp++;
                    }

                }
                else
                {
                    Console.WriteLine("Su Aproximación esta fuera del rango de (0 a 100)");
                    Console.WriteLine();
                    Console.WriteLine("Por favor introduzca otra aproximación:");
                    try
                    {
                        numApp = Int32.Parse(Console.ReadLine());
                    }catch(FormatException ex)
                    {
                        Console.WriteLine("Ha introducido un caracter NO VALIDO, por favor ingrese un numero entre 0 y 100");
                    }
                    contadorApp++;
                }
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"¡¡¡¡Enhorabuena!!! has hallado el Valor {numApp} Aleatorio, has requerido {contadorApp} intentos");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();
        }
    }
}
