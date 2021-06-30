using System;

namespace Video62_GENERICO3
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> Empleados = new AlmacenEmpleados<Director>(3);
            Empleados.agregar(new Director(4500));
            Empleados.agregar(new Director(3500));
            Empleados.agregar(new Director(2500));

            Director printEmpleado = Empleados.getEmpleado(0);
            Director printEmpleado1 = Empleados.getEmpleado(1);
            Director printEmpleado2 = Empleados.getEmpleado(2);

            Console.WriteLine(printEmpleado.getSalario());
            Console.WriteLine(printEmpleado1.getSalario());
            Console.WriteLine(printEmpleado2.getSalario());
        }
    }

    class AlmacenEmpleados<T> where T : IParaEmpleados
    {

        private int i = 0;
        private T[] datosEmpleados;

        public AlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void agregar (T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleados[i];
        }


    }

    class Director: IParaEmpleados
    {
        public Director (double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria: IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista: IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        public Estudiante (double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }

        private double edad;
    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}

