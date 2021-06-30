using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video40_UsoArrays3
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

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
                int datosElemento=int.Parse(Console.ReadLine());
                datos[i] = datosElemento;
            }
            return datos;


        }
    }
}
