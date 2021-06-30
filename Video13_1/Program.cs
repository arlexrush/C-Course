using System;

namespace Video13_1
{
    // Parametros opcionales.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(3, 4)); // puedes llamar un Metodo, click botom derecho, 
                                           // click a la opcion de acciones rapidas y refactorizaciones, 
                                           // escoje la opcion que mas te sirva. Puedes pedir que VS te 
                                           // genere un metodo, con lo cual economizas escritura de codigo, 
                                           // despues lo ajustas a lo que deseas que haga ese metodo. 
                                           // Puedes llamar el metodo sin antes haberlo construido.
        }

        private static double Suma(int v1, double v2)
        {
            return v1 + v2;
        }
    }
}
