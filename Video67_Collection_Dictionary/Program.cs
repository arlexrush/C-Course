using System;
using System.Collections.Generic;

namespace Video67_Collection_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenar el Diccionario

            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);
            edades["Maria"] = 25;
            edades["Antonio"] = 29;

            foreach(KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre: "+ persona.Key + " Edad: "+persona.Value);
                Console.WriteLine("Nombre: {0} Edad: {1}", persona.Key, persona.Value);
            }

        }
    }
}
