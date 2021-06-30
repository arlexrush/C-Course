using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // Creación de Objeto de tipo circulo. Variable/Objeto de tipo circulo.
            miCirculo = new Circulo(); // iniciación de Variable/Objeto de tipo circulo. Instanciar una clase.
            // Lo de la linea de arriba: Instanciacion o Ejemplarizacion o Creacion de ejemplar de clase
            Console.WriteLine(miCirculo.CalculoArea(10));

            Circulo miCirculo2 = new Circulo(); // Este es otro Objeto.
            Console.WriteLine(miCirculo2.CalculoArea(6));
                        
        }

    }

    class Circulo // Esto es la construcción del molde.
    {
        // Propiedad pi, si veis es como una variable, tambien llamado campo de clase.
        private const double pi = 3.1416;
        public double CalculoArea(int radio) // Comportamiento: Metodo de clase, esta es una accion que puede hacer la clase circulo.
        {
            return pi * radio * radio;
        }

    }


}
