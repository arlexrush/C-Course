using System;

namespace Video29_Encapsulamiento1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();
            // obj.euro = 1.5; // Como esta declarada public en la clase ConversorEuroDolar puedo cambiar su valor de forma directa, pero para evitar la introduccion de parametros incorrectos en el objeto instanciado pues conviene mejor hacer el cambio a trvés de un metodo de acceso.
            obj.cambiaValorEuro(1.31);
            Console.WriteLine(obj.convierte(50) + " USD");

        }
    }
    class ConversorEuroDolar
    {
        private double euro = 1.253; // antes era public, ahora lo cambiamos a private para que no sea accesible desde una instancia fueara del ambito de esta clase.
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public void cambiaValorEuro(double nuevoValor)
        {
            
            if (nuevoValor < 0) // es para evitar el efecto de introducir un parametro negativo
            {
                euro = 1.253;
            }
            else
            {
                euro = nuevoValor;
            }

            
        }
    }
}
