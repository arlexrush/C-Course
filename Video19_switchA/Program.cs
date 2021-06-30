using System;

namespace Video19_switchA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elección de un modo de transporte.

            Console.WriteLine("Elije un medio de Transporte(coche, tren, avion)");
            string mediodeTransporte = Console.ReadLine();

            switch (mediodeTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad Media de un Coche: 100 KPH");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad Media de un tren: 160 KPH");
                    break;
                case "Avión":
                    Console.WriteLine("Velocidad Media de un Avión: 800 KPH");
                    break;
                default:
                    Console.WriteLine("Velocidad Media de un barco: 200 KPH");
                    break;
            }

            // Calculo de comision por mes.

            Console.WriteLine("Introduce N° de mes para calculo de comision:");
            int nmes = Int32.Parse(Console.ReadLine());



        }
    }
}
