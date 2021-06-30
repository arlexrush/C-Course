using System;
using System.Collections.Generic;

namespace Video68_Delegado_Predicado2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> Gente = new List<Personas>();

            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Arlex";
            P2.Edad = 26;


            Personas P3 = new Personas();
            P3.Nombre = "Mary";
            P3.Edad = 37;

            Gente.AddRange(new Personas[] { P1, P2, P3 });

            // Delegado predicado con objetos

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = Gente.Exists(elPredicado);

            if (existe) Console.WriteLine("Hay persona(s) que se llaman Juan");
            else Console.WriteLine("No hay nadie llamado Juan");

            foreach (Personas element in Gente)
            {
                Console.WriteLine(element.Nombre);
            }

            Predicate<Personas> elPredicadoII = new Predicate<Personas>(ExistenMayoresEdad);

            bool existeEdad = Gente.Exists(elPredicadoII);

            if (existeEdad) Console.WriteLine("Si hay Mayores de Edad en esta Lista");
            else Console.WriteLine("Todos son menores de Edad");

            foreach (Personas element in Gente)
            {
                Console.WriteLine(element.Edad);
            }

        }

        

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }

        static bool ExistenMayoresEdad(Personas persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
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
