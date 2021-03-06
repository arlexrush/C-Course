using System;

namespace Video60_GENERICO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);
            /*archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra"); */


            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));


            Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());
            // string nombrePersona = (string) archivos.getElemento(2); // casting
            // Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new Object[z];
        }

        public void agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object getElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento; // clase Object

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
