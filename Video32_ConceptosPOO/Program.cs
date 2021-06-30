using System;

namespace Video32_ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            
        }

        static void realizarTarea()
        {
            //-----------Constructores--------------------
            Punto origen = new Punto();
            Punto destino = new Punto(128, 88);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre Puntos:{distancia}");

            Console.WriteLine($"Numero de Objetos Creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
