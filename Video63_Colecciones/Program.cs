using System;
using System.Collections.Generic;

namespace Video63_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); // Declarar una Lista(Coleccion de tipo List)

            numeros.Add(5);
            numeros.Add(7);
            numeros.Add(9);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            for(int i=0; i<5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for (int i=0;i<8; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            // OTRA LISTA, CON EL USO DE LA PROPIEDAD COUNT

            List<int> numeros1 = new List<int>();

            Console.WriteLine("Cuantos Elementos quiere introducir:");
            int elemento =Int32.Parse(Console.ReadLine());

            for(int i=1; i<=elemento; i++)
            {
                Console.WriteLine("Por favor ingrese el valor de la posición: "+i);
                numeros1.Add(Int32.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine();
            Console.WriteLine();

            for(int i=0; i < elemento; i++)
            {
                Console.WriteLine(numeros1[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i=0; i < numeros1.Count; i++)
            {
                
                Console.WriteLine(numeros1[i]);
            }

            // OTRA LISTA PARA USAR FOR EACH

            List<int> numeros2 = new List<int>();

            Console.WriteLine("Introduce Elementos en la Colección (0 para salir)");
            int elemento2 = 1;

            while (elemento2 != 0)
            {
                elemento2 = Int32.Parse(Console.ReadLine());
                numeros2.Add(elemento2);
            }

            Console.WriteLine("Elementos Introducidos: " + numeros2.Count);

            foreach (int i in numeros2)
            {
                Console.WriteLine(i);
            }

            numeros2.RemoveAt(numeros2.Count - 1); // remueve el ultimo valor de la lsita

            Console.WriteLine("Elementos Introducidos: "+numeros2.Count);

            foreach(int i in numeros2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
