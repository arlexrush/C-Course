using System;

namespace Video45_Polimorfismo
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

            // Pincipio de sustitución

            Mamiferos myEquino = new Caballo("Silverado");
            Mamiferos persona = new Humano("Juan");
            Mamiferos myKiny = new Gorila("Lalo");
            //

            // Otra forma de sustitucion

            Mamiferos animal = new Mamiferos("Equino");
            Caballo bucefalo = new Caballo("bucefalo");
            animal = bucefalo;
            //

            // Usos de la sustitucion, dados los siguientes objetos

            Caballo myloco = new Caballo("Catire Bello");
            Gorila myMono = new Gorila("Negro", "12");
            Humano myJuan = new Humano("Profesor");

            // almacenar estos objetos en un array

            // Mamiferos[] myzoo = new Caballo[3];   // Esta Instancia funciona
            // Mamiferos[] myzoo = new Gorila[3]; // Esta Instancia funciona.
            // Mamiferos[] myzoo = new Humano[3]; // Esta Instancia funciona.
            Mamiferos[] myzoo = new Mamiferos[3];

            myzoo[0] = myloco;
            myzoo[1] = myMono;
            myzoo[2] = myJuan;

            for (int i = 0; i < 3; i++)
            {
                myzoo[i].pensar(); // gracias al uso de las palabras reservadad "virtual" en el metodo pensar de mamiferos y "override" en las subclases
                                    // se puede tener metodos adaptados al contexto, es decir, tener objetos capaces de comportarse segun el contexto que los rodee.
                                    // se debe usar metodos con el mismo nombre y estado
                                    //Esto es POLIMORFISMO.
            }
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

        public virtual void pensar() // Virtual es una palabra reservada que permite que las clases que heredan de mamiferos tengan metodos con el mismo nombre que sean una modificacion del primero o sean una ampliación de su acción o ambas cosas.
                                       // esto permite modificar metodos de las subclases para que se adapten al contexto.
        {
            Console.WriteLine("Pensamiento Básico Instintivo");
        }

        private string nombreSerVivo;
    }




    class Caballo : Mamiferos
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) // Constructor
        {

        }

        public Caballo(string color, string edad) : base(color, edad)
        {

        }
        public void cabalgar()
        {
            Console.WriteLine("Calbalgo bajo el mando de un jinete");
        }
    }




    class Gorila : Mamiferos
    {
        public Gorila(string color, string edad) : base(color, edad)
        {

        }
        public Gorila(string nombreGorila) : base(nombreGorila) // Constructor
        {

        }
        public void comerBanano()
        {
            Console.WriteLine("A mi me gusta comer Banano");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo Avanzado");
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
        public override void pensar() // aparece una advertencia en pensar porque ha heredado un metodo de la clase mamifero, el efecto es que el metodo de mamiferos queda oculto o invalido. se coloca la palabra reservada new para eliminar la advertencia.
                                      // overrride es un palabra reservada para indicar 
        {
            Console.WriteLine("Yo soy capaz de pensar");
        }
    }
}
