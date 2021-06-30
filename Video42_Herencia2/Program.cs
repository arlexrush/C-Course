using System;

namespace Video42_Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamiferos Cetaseo = new Mamiferos("Ballena");
            Mamiferos Cetaseo2 = new Mamiferos("Orca", "14");
            Caballo loco = new Caballo("Catire Bello");
            Gorila Mono = new Gorila("Negro", "12");
            Humano Juan = new Humano("Profesor");
            
            Cetaseo.getnombre();
            loco.cabalgar();
            loco.cuidarCrias();
            loco.getnombre();
            Mono.getnombre();
            Juan.getnombre();
            Cetaseo2.getfeature();
            Mono.respirar();

        }
        
    }
    class Mamiferos
    {
        public Mamiferos(string nombre) // Constructor
        {
            nombreSerVivo = nombre;
        }

        private string colorSerVivo;
        private string edadSerVivo;
        public Mamiferos(string color, string edad) // constructor
        {
            colorSerVivo = color;
            edadSerVivo = edad;
        }

        public void getfeature()
        {
            Console.WriteLine($"Color del Ser Vivo: {colorSerVivo}, edad: {edadSerVivo}");
        }
        public void getnombre()
        {
            Console.WriteLine($"El nombre del ser vivo es:{nombreSerVivo}");
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de Respirar");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si mismas");
        }
        
        private string nombreSerVivo;
    }




    class Caballo:Mamiferos
    {
        public Caballo(string nombreCaballo):base(nombreCaballo) // Constructor
        {
            
        }

        public Caballo(string color, string edad):base(color, edad)
        {

        }
        public void cabalgar()
        {
            Console.WriteLine("Calbalgo bajo el mando de un jinete");
        }
    }




    class Gorila:Mamiferos
    {
        public Gorila(string color, string edad) : base(color, edad)
        {

        }
        public Gorila(string nombreGorila):base(nombreGorila) // Constructor
        {
            
        }
        public void comerBanano()
        {
            Console.WriteLine("A mi me gusta comer Banano");
        }
    }



    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano) // Constructor
        {

        }
        public Humano(string color, string edad) : base(color, edad)
        {

        }
        public void pensarCabeza()
        {
            Console.WriteLine("Yo uso la cabeza para pensar");
        }
    }
}
