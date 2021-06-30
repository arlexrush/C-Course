using System;

namespace Video61_GENERICO2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            /*archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra"); */


            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));


            Empleado salarioEmpleado = archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());
            // string nombrePersona = (string) archivos.getElemento(2); // casting
            // Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z]; //habia herencia
        }

        public void agregar(T obj) // habia herencia
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i) // habia herencia
        {
            return datosElemento[i];
        }

        private T[] datosElemento; // habia herencia  clase Object

        private int i = 0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
        private double salario;
    }
}
