using System;

namespace Video2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Combinacion de texto y numeros;

            int edad = 17;
            Console.WriteLine();
            Console.WriteLine("Tienes una edad de: " + edad + " años"); // Concatenación
            Console.WriteLine($"Tienes una edad de: {edad} años"); // Interpolación de string

            edad++;
            edad++;
            edad++;
                        
            Console.WriteLine();
            Console.WriteLine("Tienes una edad de: " + edad + " años"); // Concatenación
            Console.WriteLine($"Tienes una edad de: {edad} años"); // Interpolación de string
            
            edad--;

            Console.WriteLine();
            Console.WriteLine("Tienes una edad de: " + edad + " años"); // Concatenación
            Console.WriteLine($"Tienes una edad de: {edad} años"); // Interpolación de string

            edad = 20;
            edad--;

            Console.WriteLine();
            Console.WriteLine("Tienes una edad de: " + edad++ + " años Calendario Solar y "+ edad +" años en Calendario Lunar"); // Operador de incremento en sufijo.
            Console.WriteLine("Tienes una edad de: " + ++edad + " años Calendario Solar y " + edad + " años en Calendario Lunar"); // Operador de incremento en prefijo.
            Console.WriteLine($"Tienes una edad de: {edad} años"); // 

            edad += 10;
            Console.WriteLine($"Tienes una edad de: {edad} años"); //
            Console.WriteLine();
            Console.WriteLine();

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            Console.WriteLine(edadPersona4);

            int edadPersona5, edadPersona6 = 36, edadPersona7, edadPersona8 = 40; // define el tipo de dato de las variables pero solo edadPersona8 está iniciada. Esta linea es valida pero tendre que iniciar el resto de las varibles más abajo o en la misma linea.

            var edadPersona9 = 37; // Declaración implicita de variable, al ser 37 un valor entero el compilador asume, en tiempo de ejecución, que es una variable del tipo "int", no se puede cambiar el tipo de dato durante la ejecucion del programa.


            // Conversion explicita
            // casting

            double temperatura = 34.6;

            int temperaturaMadrid;
                        
            temperaturaMadrid = (int)temperatura;

            Console.WriteLine(temperaturaMadrid);
            Console.WriteLine(temperatura);

            // Conversión Implicita

            int habitantesCiudad = 10000000;

            long habitantesCiudad2018 = habitantesCiudad; // Conversion implicita sólo posible entre tipos de datos de diferente alcance compatibles.

            Console.WriteLine(habitantesCiudad2018);
            Console.WriteLine(habitantesCiudad);

            float pesoMaterial = 5.78F;

            double pesoMaterialPrec = pesoMaterial;

            Console.WriteLine(pesoMaterialPrec);
            Console.WriteLine(pesoMaterial);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Introduce el Primer Valor: ");
            int num1 = int.Parse(Console.ReadLine()); // Parse toma un valor de texto y lo convierte en un vcalor numerico entero "int".
            Console.WriteLine();
            Console.WriteLine("Introduce el Segundo Valor: ");
            int num2 = int.Parse(Console.ReadLine()); // Parse toma un valor de texto y lo convierte en un vcalor numerico entero "int".
            Console.WriteLine();
            Console.WriteLine("El resultado es: " + (num1 + num2));
           
            int numT = num1 + num2;

            Console.WriteLine(numT);
            Console.WriteLine($"El resultado es: {numT}");
            Console.WriteLine($"El resultado es: {num1+num2}");
            Console.WriteLine("El resultado es: {0}", numT);
            Console.WriteLine();
            string numS = "" + (num1 + num2);
            Console.WriteLine(numS);

            // Constantes

            const int VALOR = 5;
            const int VALOR2 = 7;
            Console.WriteLine("El valor de la constante es: {0} y el de la segunda es: {1}", VALOR, VALOR2);

            const double PI = 3.1416;
            Console.WriteLine("Introduzca la medida del radio:");
            double radio = double.Parse(Console.ReadLine());
            double area = radio * radio * PI;
            Console.WriteLine($"El Area del circulo es: {area}");

            // para operaciones matematicas de puede Math.

            double areao =PI* (Math.Pow(radio, 2));
            Console.WriteLine($"El Area del circulo es: {areao}");







        }
    }
}
