using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Video103_CRUD_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
       
    public partial class MainWindow : Window
    {

        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["Video103_CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext();

            // InsertarEmpresas();

            // InsertarEmpleados();

            // InsertaCargos();

            InsertaCargoEmpleados();
        }

        public void InsertarEmpresas()
        {
            Empresa objetoEmpresa = new Empresa();

            objetoEmpresa.Nombre = "Pildoras Informaticas";

            dataContext.Empresa.InsertOnSubmit(objetoEmpresa);


            Empresa objetoEmpresa2 = new Empresa();

            objetoEmpresa2.Nombre = "Eyemar Express";

            dataContext.Empresa.InsertOnSubmit(objetoEmpresa2);



            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertarEmpleados()
        {
            Empresa objetoEmpresa1 = dataContext.Empresa.First(emp => emp.Nombre.Equals("Pildoras Informaticas"));
            Empresa objetoEmpresa2 = dataContext.Empresa.First(emp => emp.Nombre.Equals("Eyemar Express"));

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Diaz", EmpresaId = objetoEmpresa1.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Angel", Apellido = "Estaback", EmpresaId = objetoEmpresa2.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Anibal", Apellido = "Regnault", EmpresaId = objetoEmpresa2.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Oscar", Apellido = "Perez", EmpresaId = objetoEmpresa1.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "Fernandez", EmpresaId = objetoEmpresa1.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Hugo", Apellido = "paz", EmpresaId = objetoEmpresa1.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Fredy", Apellido = "Paz Matos", EmpresaId = objetoEmpresa2.Id });

            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;

        }

        public void InsertaCargos()
        {
            
            
            List<cargo> listaObjetosCargo = new List<cargo>();

            listaObjetosCargo.Add(new cargo { NombreCargo = "Presidente"});
            listaObjetosCargo.Add(new cargo { NombreCargo = "Vice Presidente" });
            listaObjetosCargo.Add(new cargo { NombreCargo = "Director" });
            listaObjetosCargo.Add(new cargo { NombreCargo = "Gerente" });
            listaObjetosCargo.Add(new cargo { NombreCargo = "Jefe" });
            listaObjetosCargo.Add(new cargo { NombreCargo = "Empleado" });
            listaObjetosCargo.Add(new cargo { NombreCargo = "Obrero" });

            dataContext.cargo.InsertAllOnSubmit(listaObjetosCargo);
            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.cargo;



        }

        public void InsertaCargoEmpleados()
        {
            // forma 1

            // Empleado objetoEmpleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Oscar"));

            // cargo objetoCargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Gerente"));

            // cargoEmpleado objetoCargoEmpleado1 = new cargoEmpleado() { cargoId = objetoCargo.Id, empleadoId = objetoEmpleado.Id };

            // dataContext.cargoEmpleado.InsertOnSubmit(objetoCargoEmpleado1);
            // dataContext.SubmitChanges();
            // Principal.ItemsSource = dataContext.cargoEmpleado;

            //forma 2

            // cargoEmpleado objetoCargoAngel = new cargoEmpleado();
            // objetoCargoAngel.empleadoId = 2;
            // objetoCargoAngel.cargoId = 2;


            // dataContext.cargoEmpleado.InsertOnSubmit(objetoCargoAngel);
            // dataContext.SubmitChanges();
            // Principal.ItemsSource = dataContext.cargoEmpleado;


            // modo 3

            //Empleado Juan = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Juan"));
            //Empleado Angel = dataContext.Empleado.First(empleado1 => empleado1.Nombre.Equals("Angel"));
            //Empleado Anibal = dataContext.Empleado.First(empleado2 => empleado2.Nombre.Equals("Anibal"));
            // Empleado Oscar = dataContext.Empleado.First(empleado3 => empleado3.Nombre.Equals("Oscar"));
            //Empleado Ana = dataContext.Empleado.First(empleado4 => empleado4.Nombre.Equals("Ana"));
            //Empleado Hugo = dataContext.Empleado.First(empleado5 => empleado5.Nombre.Equals("Hugo"));
            //Empleado Fredy = dataContext.Empleado.First(empleado6 => empleado6.Nombre.Equals("Fredy"));

            //cargo Presidente = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Presidente"));
            //cargo VicePresidente = dataContext.cargo.First(cargo1 => cargo1.NombreCargo.Equals("Vice Presidente"));
            //cargo Director = dataContext.cargo.First(cargo2 => cargo2.NombreCargo.Equals("Director"));
            //cargo Gerente = dataContext.cargo.First(cargo3 => cargo3.NombreCargo.Equals("Gerente"));
            //cargo Jefe = dataContext.cargo.First(cargo4 => cargo4.NombreCargo.Equals("Jefe"));
            //cargo Empleado = dataContext.cargo.First(cargo5 => cargo5.NombreCargo.Equals("Empleado"));
            //cargo Obrero = dataContext.cargo.First(cargo6 => cargo6.NombreCargo.Equals("Obrero"));


            //cargoEmpleado JuanPresidente = new cargoEmpleado();
            //JuanPresidente.cargoId = Presidente.Id;
            //JuanPresidente.empleadoId = Juan.Id;

            //cargoEmpleado AngelVicePresidente = new cargoEmpleado();
            //AngelVicePresidente.cargoId = VicePresidente.Id;
            //AngelVicePresidente.empleadoId = Angel.Id;

            //cargoEmpleado FredyDirector = new cargoEmpleado();
            //FredyDirector.cargoId = Director.Id;
            //FredyDirector.empleadoId = Fredy.Id;

            //List<cargoEmpleado> CargosEmpleados = new List<cargoEmpleado>();

            //CargosEmpleados.Add(JuanPresidente);
            //CargosEmpleados.Add(AngelVicePresidente);
            //CargosEmpleados.Add(FredyDirector);

            //dataContext.cargoEmpleado.InsertAllOnSubmit(CargosEmpleados);
            //dataContext.SubmitChanges();


            //dataContext.cargoEmpleado.InsertOnSubmit(JuanPresidente);
            //dataContext.SubmitChanges();

            //dataContext.cargoEmpleado.InsertOnSubmit(AngelVicePresidente);
            //dataContext.SubmitChanges();

            //Principal.ItemsSource = dataContext.cargoEmpleado;


            // modo 4
            //cargoEmpleado AsingnacionCargo1 = new cargoEmpleado() { Empleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Juan")), cargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Presidente"))};
            //dataContext.cargoEmpleado.InsertOnSubmit(AsingnacionCargo1);
            //dataContext.SubmitChanges();
            //Principal.ItemsSource = dataContext.cargoEmpleado;

            // modo5

            List<cargoEmpleado> EmpleadoCargo = new List<cargoEmpleado>();

            EmpleadoCargo.Add(new cargoEmpleado()
            {
                Empleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Juan")),
                cargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Presidente"))
            });

            EmpleadoCargo.Add(new cargoEmpleado()
            {
                Empleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Fredy")),
                cargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Vice Presidente"))
            });

            EmpleadoCargo.Add(new cargoEmpleado()
            {
                Empleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Hugo")),
                cargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Director"))
            });

            EmpleadoCargo.Add(new cargoEmpleado()
            {
                Empleado = dataContext.Empleado.First(empleado => empleado.Nombre.Equals("Oscar")),
                cargo = dataContext.cargo.First(cargo => cargo.NombreCargo.Equals("Gerente"))
            });

            dataContext.cargoEmpleado.InsertAllOnSubmit(EmpleadoCargo);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.cargoEmpleado;

        }

        public void ActualizaEmpleado()
        {

        }
    }
}
