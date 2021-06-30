using System;

namespace Video31_metodos_getter_setter
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto o instancia de tipo coche //
                                        // dar un estado inicial a nuestro coche.
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());

            Coche coche3 = new Coche(2500.526, 0.750); // creando un nuevo objeto con otro constructor de la clase Coche (Cambio del estado inicial)

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true,"cuero"); // metodo setter, para establecer cambio en las propiedades
            Console.WriteLine(coche3.getExtras());

        }
    }
    partial class Coche
    //-----------------partial class de constructores------------------------------
    {
        // Constructor, para dar un estado inicial y debe llamarse igual que la clase.
        public Coche() // este es el constructor.
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = .800;
            climatizador = false;
            tapiceria = "tela";
        }
    }

    //------------------------- partial class de setters y getters---------------------

    partial class Coche
    {
        public Coche(double getLargo, double getAncho) // Metodo Getter
        {
            ruedas = 4;
            largo = getLargo;
            ancho = getAncho;
            climatizador = false;
            tapiceria = "tela";
        }

        public string getInfoCoche() // es un metodo para acceder a las propiedades y verlas.
        {
            return "información del Coche:\n" + "\n" + "Ruedas: " + ruedas + "  Largo: " + largo + "  Ancho: " + ancho + "  Climatizador: " + climatizador + "  Tapiceria: " + tapiceria;
        }

        public void setExtras(bool paramClimatizador, string paramTapiceria) // Metodo para establecer las propiedades extras (climatizador y tapiceria) Extras.
        {
            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }

        public string getExtras()
        {
            return "Extras del Coche: \n" + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;

        }

    }

    // -----------------------------partial class de declaración de Variables-----------------------------

    partial class Coche
    {            
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}

