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
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
            MuestraTodos();
            
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();
                    miAdaptadorSql.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTabla.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void MuestraPedidos()
        {
            try
            {
                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente " +
                "WHERE C.ID=@clienteId"; // esto es una consulta parametrica SQL, la parte despues del + es el parametro, éste es antecedido por una @

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {
                    sqlComando.Parameters.AddWithValue("@clienteId", listaClientes.SelectedValue);
                    DataTable pedidosTabla = new DataTable();
                    miAdaptadorSql.Fill(pedidosTabla);

                    pedidosCliente.DisplayMemberPath = "fechaPedido";
                    pedidosCliente.SelectedValuePath = "Id";
                    pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void MuestraTodos()
        {
            try
            {
                string consulta = "SELECT *,  CONCAT('',cCliente,'     ',fechaPedido,'    ',formaPago) AS TODOINFOPEDIDO FROM PEDIDO";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable todosPedidoTabla = new DataTable();
                    miAdaptadorSql.Fill(todosPedidoTabla);

                    todosPedidos.DisplayMemberPath = "TODOINFOPEDIDO";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = todosPedidoTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            

        }

        SqlConnection miConexionSql;

        /*private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");
            MuestraPedidos();

        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());
            string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";

            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            sqlComando.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);
            sqlComando.ExecuteNonQuery();

            miConexionSql.Close();
            MuestraTodos(); // para refrescar el listbox
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM CLIENTE WHERE ID=@CLIENTEID";

            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            sqlComando.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);
            sqlComando.ExecuteNonQuery();

            miConexionSql.Close();
            MuestraClientes(); // para refrescar el listbox
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            sqlComando.Parameters.AddWithValue("@nombre", InsertarClientes.Text);
            sqlComando.ExecuteNonQuery();

            miConexionSql.Close();
            MuestraClientes(); // para refrescar el listbox
            InsertarClientes.Text = "";
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza VentanaActualizar = new Actualiza((int)listaClientes.SelectedValue);
            

            try
            {
                string consulta = "SELECT nombre FROM CLIENTE WHERE Id=@ClId";

                SqlCommand misqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(misqlComando);

                using (miAdaptadorSql)
                {
                    misqlComando.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);
                                       
                    DataTable clientesTabla = new DataTable();
                    miAdaptadorSql.Fill(clientesTabla);

                    VentanaActualizar.cuadroActualiza.Text = clientesTabla.Rows[0]["nombre"].ToString();

                    
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }

            VentanaActualizar.ShowDialog();
           
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
}
