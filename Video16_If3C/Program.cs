using System;

namespace Video16_If3C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para el calculo de la nota promedio.
            // Introduccion de Nota de Parciales.

            Console.WriteLine("Introduce la nota del Primer Parcial");
            double parcial1=double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del Segundo Parcial");
            double parcial2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del Tercer Parcial");
            double parcial3 = double.Parse(Console.ReadLine());

            // Para aprobar el año es necesario que el estudiante haya aprobado los tres Parciales.

            if(parcial1>=5 && parcial2>=5 && parcial3>=5)
            {
                Console.WriteLine($"La Nota Media de sus Parciales es: {((parcial1+parcial2+parcial3)/3)}");
            }
            else
            {
                Console.WriteLine("Usted No Aprobó alguno de sus parciales, por favor regrese en Septiembre");
            }

            // Para aprobar el año es necesario que el estudiante haya aprobado al menos un Parcial.

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            {
                Console.WriteLine($"La Nota Media de sus Parciales es: {((parcial1 + parcial2 + parcial3) / 3)}");
            }
            else
            {
                Console.WriteLine("Usted No Aprobó alguno de sus parciales, por favor regrese en Septiembre");
            }
        }
    }
}
