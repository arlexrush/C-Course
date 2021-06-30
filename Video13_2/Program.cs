using System;

namespace Video13_2
{
    class Program
    {
        // Parametros opcionales, es util cuando trabajamos en combinación con otros lenguajes que no admiten la sobrecarga de metodos.
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            Console.WriteLine(Suma(valor1, valor2)); // Aquí está usando el segundo metodo suma porque se ajusta más,
                                                     // Empezando desde la cantidad de parametros.


            Console.WriteLine(Suma(valor1, valor2, valor3)); // Aquí esta usando el primer metodo suma.
                                                             // Se pueden incluir 2 parametros,
                                                             // porque ya se tiene uno opcional por defecto e igual a 0,
                                                             // pero podemos incluir los tes parametros dejando sin efecto al parametro opcional
                                                             // tomando el valor que le asignemos al tercer parametro.
        }

        static double Suma(int num1, double num2, double num3 = 0) // Para hacer un parametro opcional, 
                                                                           // se le asigna un valor por defecto.
                                                                           // Primero se colocan los parametros obligatorios
                                                                           // y luego los opcionales.
                                                                           // No hay limite respecto del numero de parametros opcionales.


        {
            return num1 + num2 + num3;
        }

        static double Suma(int num1, double num2) 
        {
            return num1 + num2;
        }
    }
}
