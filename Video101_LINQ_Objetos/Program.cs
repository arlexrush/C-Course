using System;
using System.Collections.Generic;
using System.Linq;

namespace Video101_LINQ_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce=new ControlEmpresasEmpleados();
            ce.getCeo();
            Console.WriteLine();
            Console.WriteLine();
            ce.getEmpleadosOrdenado();
            Console.WriteLine();
            Console.WriteLine();
            ce.getEmpleadosOrdenadoinv();
            Console.WriteLine();
            Console.WriteLine();
            ce.getSalarioOrdenado();
            Console.WriteLine();
            Console.WriteLine();
            ce.getEmpleadosPildoras();
            Console.WriteLine();
            Console.WriteLine();
            ce.getEmpleadosGoogle();
            Console.WriteLine();
            Console.WriteLine();
            int id;      
            try
            {
                Console.WriteLine("Ingrese el Id de la Empresa: ");
                id = Int32.Parse(Console.ReadLine());
                ce.getEmpleadosEmpresa(id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Introdujo el dato en el formato incorrecto. Debe ingresar un Entero '{e}'");
            }

            Console.WriteLine("Gracias");

        }
    }




    class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            ListaEmpresas = new List<Empresa>();
            ListaEmpleados = new List<Empleado>();

            ListaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            ListaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });
            ListaEmpleados.Add(new Empleado { Id = 1, Nombre="Sergey Brin", Cargo="CEO", Salario=10000, EmpresaId=1});
            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Hugo Chavez", Cargo = "Barrendero", Salario = 1000000, EmpresaId = 2 });
            ListaEmpleados.Add(new Empleado { Id = 3, Nombre = "Juan Dias", Cargo = "CEO", Salario = 20000, EmpresaId = 2 });
            ListaEmpleados.Add(new Empleado { Id = 4, Nombre = "Larry Page", Cargo = "CTO", Salario = 5000, EmpresaId = 1 });
            ListaEmpleados.Add(new Empleado { Id = 5, Nombre = "Irina Shayk", Cargo = "CFO", Salario = 1000000, EmpresaId = 2 });
        }

        public void getCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in ListaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado  empleado1 in ceos)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenado()
        {
            IEnumerable<Empleado> empleados = from empleado in ListaEmpleados orderby empleado.Nombre ascending select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenadoinv()
        {
            IEnumerable<Empleado> empleados = from empleado in ListaEmpleados orderby empleado.Nombre descending select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getSalarioOrdenado()
        {
            IEnumerable<Empleado> empleados = from empleado in ListaEmpleados orderby empleado.Salario descending select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosPildoras()
        {
            IEnumerable<Empleado> empleadosPil = from empleado in ListaEmpleados join empresa in ListaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Nombre == "Pildoras Informaticas" select empleado;

            foreach (Empleado empleado1 in empleadosPil)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosGoogle()
        {
            IEnumerable<Empleado> empleadosGoo = from empleado in ListaEmpleados join empresa in ListaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Nombre == "Google" select empleado;

            foreach (Empleado empleado1 in empleadosGoo)
            {
                empleado1.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int id)
        {
            IEnumerable<Empleado> empleadosGoo = from empleado in ListaEmpleados join empresa in ListaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Id == id select empleado;

            foreach (Empleado empleado1 in empleadosGoo)
            {
                empleado1.getDatosEmpleado();
            }
        }


        public List<Empresa> ListaEmpresas;
        public List<Empleado> ListaEmpleados;
    }

    }

   
class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }


        public string Cargo { get; set; }


        public double Salario { get; set; }


        // Clave foranea

        public int EmpresaId { get; set; }


        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado:{0} con el Id:{1}, Cargo:{2}, Salario:{3} y perteneciente a la Empresa:{4} ", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }



