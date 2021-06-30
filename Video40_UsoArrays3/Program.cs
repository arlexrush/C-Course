using System;

namespace Video40_UsoArrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            Console.WriteLine();
            Console.WriteLine();
            ProcesaDatos0(numeros);
            Console.WriteLine();
            ProcesaDatos(numeros);
            Console.WriteLine();
            // ProcesaDatos1(numeros);
            ProcesaDatos2(numeros);
            Console.WriteLine();
            ProcesaDatos1(numeros);
            Console.WriteLine();

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

        }

        static void ProcesaDatos0(int[] datos) // El metodo recibe por parametro un array.
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
        }

        static void ProcesaDatos(int[] datos) // El metodo recibe por parametro un array.
        {                                       // Al contrario de lo que dice el profe este Bucle si que puede cambiar los datos del array
            foreach(double i in datos)
            {
                double i2 =System.Math.Pow(2,i);
                Console.WriteLine(i2);
            }
        }

        static void ProcesaDatos1(int[] datos) 
        {
            for (int i=0; i<4; i++)
            {
                datos[i] += 10;
            }
        }

        static double FuncionExterna(double i)
        {
            double i2;
            i2 = System.Math.Pow(2, i); // antes o despues de return, el efecto es el mismo.
            return i2; //= System.Math.Pow(2, i);
        }

        static void ProcesaDatos2(int[] datos) 
        {                                     
            foreach (double i in datos)
            {
                Console.WriteLine(FuncionExterna(i));
            }
        }

    }
}
