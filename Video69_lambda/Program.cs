using System;
using System.Collections.Generic;

namespace Video69_lambda
{
    class Program
    {
        public delegate bool ComparaPersonas(int edad1, int edad2);

        public delegate bool ComparaPersonas2(string edad1, string edad2);
        static void Main(string[] args)
        {
            List<Personas> Gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Arlex";
            P2.Edad = 26;

            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            ComparaPersonas2 comparaNombre = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));
            Console.WriteLine(comparaNombre(P1.Nombre, P2.Nombre));


            OperacionesMatematicas Potencia = new OperacionesMatematicas(Cuadrado);
            Console.WriteLine(Potencia(4));

            //Uso de Expresion lambda
            OperacionesMatematicas Potencia2 = new OperacionesMatematicas(x => x * x * x);
            Console.WriteLine(Potencia2(4));

            OperacionesMatematicas2 Potencia3 = new OperacionesMatematicas2((x, y) => x + y);
            Console.WriteLine(Potencia3(4, 3));

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            foreach (int element in numeros)
            {
                Console.WriteLine(element);
            }

            List<int> NumerosPares = numeros.FindAll(x => (x % 2 == 0));

            foreach (int elem in NumerosPares)
            {
                Console.WriteLine(elem);
            }

            NumerosPares.ForEach(nume => { Console.WriteLine(nume); Console.WriteLine("numero Par"); });
        }

        public delegate int OperacionesMatematicas(int numero);

        public delegate int OperacionesMatematicas2(int num1, int num2);
        public static int Cuadrado(int num)
        {
            return num * num;
        }

        public static int Sumatoria(int x, int y)
        {
            return x + y;
        }

        
    }


    class Personas
    {
        private string nombre;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
