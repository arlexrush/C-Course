using System;

namespace Video67_Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de objeto delegado apuntando al metodo MensajeBienvenida

            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            
            // Utilización del delegado para llamar al metodo saludobienvenida

            ElDelegado("Buen día, He llegado");


            ElDelegado = new ObjetoDelegado(MensajeDespedida.Saludodespedida);

            ElDelegado("Me voy, Hasta Luego");
        }

        // Definicion de Objeto delegado

        delegate void ObjetoDelegado(string msj);
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje de Bienvenida {0}", msj);
        }
    }

    class MensajeDespedida
    {
        public static void Saludodespedida(string msj)
        {
            Console.WriteLine("Mensaje de despedida {0}", msj);
        }

    }

}
