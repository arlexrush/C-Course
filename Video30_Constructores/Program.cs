using System;

namespace Video30_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto o instancia de tipo coche //
                                        // dar un estado inicial a nuestro coche.
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());

            Coche coche3 = new Coche(2500.526, 0.750);

            Console.WriteLine(coche3.getInfoCoche());

        }
    }
    class Coche
    {
        // Constructor, para dar un estado inicial y debe llamarse igual que la clase.
        public Coche() // este es el constructor.
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = .800;
        }

        public Coche(double getLargo, double getAncho) // Metodo Getter
        {
            ruedas = 4;
            largo = getLargo;
            ancho = getAncho;
        }

        public string getInfoCoche() // es un metodo para acceder a las propiedades y verlas.
        {
            return "información del Coche:\n"+ "\n" + "Ruedas: " + ruedas + "  Largo: " + largo + "  Ancho: " + ancho + "  Climatizador: " + climatizador + "  Tapiceria: " + tapiceria;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
