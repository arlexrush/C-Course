using System;

namespace Video12_2
{
    class Program
    {
        //Sobrecarga de Metodos
        static void Main(string[] args)
        {

            Console.WriteLine(Suma(3,4));
        }

        static int Suma(int operador1, int operador2) => operador1 + operador2;
        static double Suma(int operador1, double operador2) => operador1 + operador2;
        static int Suma(int operador1, int operador2, int operador3, int operador4) => operador1 + operador2;

    }
}
