using System;

namespace Video37_UsoArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // array implicito

            // var datos = new[] { "jauna", "Diaz", "España" }; // el compilador infiere que son datos string porque los tres (3) elementos son string, no se puede colocar elementos string y numericos combinados, da un error

            var valores = new[] { 15, 28, 35, 75.5, 30.30 }; // el compilador interpreta que es double aunque haya enteros.



            // array de objetos.

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = new Empleados("Wendy", 41);


            Empleados Ana = new Empleados("Ana", 27); // Aqui defino el objeto Ana 
            arrayEmpleados[2] = Ana;


            // array de Tipos o clases anonimas

            var personas = new[]
            {new {Nombre="Juan", Edad= 19}, new {Nombre="maria", Edad= 49}, new {Nombre="Diana", Edad= 35}};

            // Console.WriteLine(personas[1]);

            for (int i=0; i<5; i++)
            {
                Console.WriteLine(valores[i]);
            }

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i]);
            }

            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }

            foreach (Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }

            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }

            foreach (var variable in personas)
            {
                Console.WriteLine(variable);
            }

        }
    }

    class Empleados
    {
        // Constructor
        
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return " Nombre del Empleado: "+ nombre + " "+ "edad: "+edad;
        }

        private string nombre;
        private int edad;

    }
}
