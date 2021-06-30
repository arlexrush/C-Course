using System;

namespace TareaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gestión de la Navegación 1.0");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione entre: coche o avión:");
            string tipoVeh=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione La Aplicación: carga o pasajeros:");
            string aplicacion = Console.ReadLine();

            switch (tipoVeh)
            {
                case "coche": Vehiculo SuperCoche = new Coche(aplicacion, 20);
                    SuperCoche.getState();
                    Console.WriteLine();
                    Console.WriteLine();
                    SuperCoche.Navegador();
                    Console.WriteLine("Ingrese el Nombre del Piloto:");
                    string pilot = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Esta Lleno el tanque de la Gasolina: true o false");
                    bool vehGas = Convert.ToBoolean(Console.ReadLine());
                    SuperCoche.OnMotor(pilot, vehGas);
                    Vehiculo[] Navegacion = new Vehiculo[2];
                    Coche cocheNavegador = new Coche(aplicacion, 20);
                    Avion avionNavegador = new Avion(aplicacion, 10);
                    Navegacion[0] = cocheNavegador;
                    Navegacion[1] = avionNavegador;
                    for(int i=0;i<=1; i++)
                    {
                        Navegacion[i].Navegador();
                    }
                    break;
                case "avion": Vehiculo SuperAvion = new Avion(aplicacion, 10);
                    SuperAvion.getState();
                    Console.WriteLine();
                    Console.WriteLine();
                    SuperAvion.Navegador();
                    Console.WriteLine("Ingrese el Nombre del Piloto:");
                    string piloto = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Esta Lleno el tanque de la Gasolina: true o false");
                    bool vehGaso = Convert.ToBoolean(Console.ReadLine());
                    SuperAvion.OnMotor(piloto, vehGaso);
                    Vehiculo[] Navegaciones = new Vehiculo[2];
                    Coche cocheNavegadores = new Coche(aplicacion, 20);
                    Avion avionNavegadores = new Avion(aplicacion, 10);
                    Navegaciones[0] = cocheNavegadores;
                    Navegaciones[1] = avionNavegadores;
                    for (int i = 0; i <= 1; i++)
                    {
                        Navegaciones[i].Navegador();
                    }
                    break;
            }
        }
    }

    class Vehiculo
    {
        private string tipoAplicacion;
        private int vidaUtil;
        private string pilot;
        private bool vehGas;

        
        public Vehiculo(string vehApli, int vehVida)
        {
            tipoAplicacion = vehApli;
            vidaUtil = vehVida;
        }

        public void getState()
        {
            Console.WriteLine($"El Vehiculo tiene Aplicación para: {tipoAplicacion} y tiene un Tiempo de vida Util de {vidaUtil} años");
        }

        public void OnMotor(string pilot, bool vehGas)
        {
            this.pilot = pilot;
            this.vehGas=vehGas;

            if (this.vehGas == true)
            {
                Console.WriteLine($"El Piloto a cargo del timon es:{pilot}, y el tanque del combustible esta LLENO");
                Console.WriteLine("Está listo para encendido de Motor");
                Console.WriteLine("MOTOR ON");
            }
            else
            {
                Console.WriteLine($"El Piloto a cargo del timon es:{pilot}, y el tanque del combustible esta VACIO, no puede Encender el Motor");
                Console.WriteLine("No puedes Arrancar");
            }
            
        }

        public void EquipaGas()
        {
            vehGas = true;
        }

        public void OffMotor()
        {
            Console.WriteLine("MOTOR OFF");
            Console.WriteLine("Motor Apagado");
        }

        public virtual void Navegador()
        {
            Console.WriteLine("Disponible Navegación Inercial, Radiolectrica y GNSS");
        }

        
    }

    class Coche:Vehiculo
    {
        public Coche(string cocheApli, int cocheVida):base (cocheApli, cocheVida)
        {
            
        }

        public override void Navegador()
        {
            Console.WriteLine("Para los Coches está disponible solamente Navegación Inercial");
        }
    }

    class Avion:Vehiculo
    {
        public Avion(string airApli, int airVida) : base(airApli, airVida)
        {

        }

        public override void Navegador()
        {
            Console.WriteLine("Para el Avión está disponible Radioayudas y Navegación Satelital");
        }
    }

}
