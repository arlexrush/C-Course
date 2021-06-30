using System;
using System.IO;

namespace Video59_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos Miarchivo = new ManejoArchivos();
            Miarchivo.mensaje();
        }
    }

    class ManejoArchivos
    {

        StreamReader archivo = null;
        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"c:\Usuarios\Usuario\texto.txt");
            while ((linea = archivo.ReadLine()) != null) // para leer linea
            {
                Console.WriteLine(linea);
                contador++;
            }

        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }

    }
}
