using System;
using System.Text.RegularExpressions;

namespace Video70_ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {   // define la cadena de caracteres
            string frase = "Mi nombre es Arlex y mi N° de Telefono  es (+58)412-396-35-07 en Venezuela y (+34)314-208-41-42, mi codigo postal es 1412 y mi pagina es https://wwww.pildorasinformaticas.com y correo: cursos@pildorasinformaticas.com";

            // guardo en una variable el patron de busqueda
            string patron = "[e]";

            // define la expresion regular
            Regex miReyex = new Regex(patron);

            // busca en la cadena de texto "frase" la coincidencia de la letra J y la guardo en la coleccion ElMatch
            MatchCollection ElMatch = miReyex.Matches(frase);

            if (ElMatch.Count > 0) Console.WriteLine("Se ha encontrado la letra 'e' en {0} oportunidad(es)", ElMatch.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron2 = @"\d";
            Regex miReyex2 = new Regex(patron2);
            MatchCollection ElMatch2 = miReyex2.Matches(frase);
            if (ElMatch2.Count > 0) Console.WriteLine("Se han encontrado numeros en {0} oportunidad(es) en la cadena de Texto", ElMatch2.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron3 = @"\d\d";
            Regex miReyex3 = new Regex(patron3);
            MatchCollection ElMatch3 = miReyex3.Matches(frase);
            if (ElMatch3.Count > 0) Console.WriteLine("Se han encontrado numeros en {0} oportunidad(es) en la cadena de Texto", ElMatch3.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron4 = @"\d{3}";
            Regex miReyex4 = new Regex(patron4);
            MatchCollection ElMatch4 = miReyex4.Matches(frase);
            if (ElMatch4.Count > 0) Console.WriteLine("Se han encontrado numeros en {0} oportunidad(es) en la cadena de Texto", ElMatch4.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron5 = @"\d{3}-\d{3}-\d{2}-\d{2}";
            Regex miReyex5 = new Regex(patron5);
            MatchCollection ElMatch5 = miReyex5.Matches(frase);
            if (ElMatch5.Count > 0) Console.WriteLine("Se han encontrado numeros de telefono en {0} oportunidad(es) en la cadena de Texto", ElMatch5.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron6 = @"\+34|\+58";
            Regex miReyex6 = new Regex(patron6);
            MatchCollection ElMatch6 = miReyex6.Matches(frase);
            if (ElMatch6.Count > 0) Console.WriteLine("Se han encontrado numeros de telefono en {0} oportunidad(es) en la cadena de Texto", ElMatch6.Count);
            else Console.WriteLine("No existen coincidencia");

            string patron7 = "https?://(www.)?"; // el interrogativo para el primer caso funciona solo para la s, pero para el segundo funciona para todo lo que hay en el parentesis.
            Regex miReyex7 = new Regex(patron7);
            MatchCollection ElMatch7 = miReyex7.Matches(frase);
            if (ElMatch7.Count > 0) Console.WriteLine("hay una pagina web");
            else Console.WriteLine("No existen coincidencia");

            
                
            

        }

        
    }
}
