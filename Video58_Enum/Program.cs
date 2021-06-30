using System;

namespace Video58_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia

            /* Estaciones alergia = Estaciones.Primavera;
            string La_alergia = alergia.ToString(); 
            Console.WriteLine(alergia);

            Bonus Antonio = Bonus.bueno;
            Console.WriteLine(Antonio);

            double bonusAntonio = (double)Antonio;
            Console.WriteLine(bonusAntonio);

            double salarioAntonio = 1500 + bonusAntonio;
            Console.WriteLine(salarioAntonio); */

            Empleado Juan = new Empleado(Bonus.extra, 1900.50);
            Console.WriteLine("El Salario del Empleado es: "+ Juan.getSalario());
        }


    }

    class Empleado
    {
        // enum usado como parametro de un constructor
        public Empleado(Bonus bonusempleado, double salario )
        {

            bonus = (double)bonusempleado;
            this.salario = salario;

        }

        public double getSalario()
        {
            return salario + bonus;
        }
        
        private double salario, bonus;

        // private bonus bonusEmpleado;      // puede ser encapsulado.
        // private double salario;      

    }


    enum Estaciones { Primavera, Verano, Otoño, Invierno}; 
    enum Bonus {bajo=500, normal= 1000, bueno=1500, extra=3000 };
}
