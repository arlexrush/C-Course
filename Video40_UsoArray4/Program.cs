using System;

namespace Video40_UsoArray4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();
            Console.WriteLine();
            string cadenaW="{ ";
            foreach(int i in arrayElementos) 
            { 
                // Console.WriteLine(i);
                cadenaW = cadenaW +i+" ";
            }
            cadenaW = cadenaW + "}";
            Console.WriteLine($"Matriz de sus datos:{cadenaW}");
            double promd= PromedioDatos(arrayElementos);
            Console.WriteLine($"El Promedio de sus datos es:{promd}");
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuanstos Elementos quieres que tenga el ARRAY?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];
            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición N°:{i}");
                int datosElemento = int.Parse(Console.ReadLine());
                datos[i] = datosElemento;
            }
            return datos;
                        
            }

        // Metodo para calcular el promedio de los datos.
        static double PromedioDatos(int[] array)
        {
            double acumulador = 0;
            double promedio;
            for (int i = 0; i < array.Length; i++)
            {
                int arrayTrabajo = array[i];
                acumulador = acumulador + arrayTrabajo;
                                     
            }
            return promedio = acumulador/(array.Length);
            
        }
    }
}
