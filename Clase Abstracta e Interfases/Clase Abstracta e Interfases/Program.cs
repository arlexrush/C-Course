using System;

namespace Clase_Abstracta_e_Interfases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Usar Clases Abstractas sólo en situaciones de maxima jerarquia en la herencia, Ej. Todas las aves tienen alas, una clase abstracta alas representa la maxima jerarquia entre las propiedades heredables de las aves.
        // Se dice entonces que las alas son la maxima abstraccion de un ave.
        public abstract class Bird
        {
            public int _wings;

            public Bird(int wings) => _wings = wings;
        }

        // Isar interfaces para categorizar las diferentes jerarquias de las propiedades de las aves

        interface IFly
        {
            // las interfaces no admiten atributos
            void fly()
            {
                Console.WriteLine("Yo Vuelo");
            }
        }

        interface IRun
        {
            // las interfaces no admiten atributos
            int legs { get; set; }

            void Run();
        }

        interface ISwin
        {
            // las interfaces no admiten atributos
            void swin();
        }

        public class Ostrich : Bird, IRun, ISwin, IFly
        {
            // Esto es un atributo
            public int _legs;

            // esto es una propiedad, tiene get y set
            public int legs
            {
                get
                {
                    return _legs;
                }
                set
                {
                    _legs = value;
                }
            }
            
            // Constructor

            public Ostrich(int wings): base(wings)
            {

            }

            public void Run()
            {
                Console.WriteLine("Yo Corro");
            }

            public void swin()
            {
                Console.WriteLine("Yo nado)");
            }
        }
    }
}
