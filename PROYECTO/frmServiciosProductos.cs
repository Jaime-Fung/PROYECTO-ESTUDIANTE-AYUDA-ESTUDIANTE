using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmServiciosProductos : Form
    {
        private string connectionString = "Data Source=JAIME\\SQLEXPRESS;Initial Catalog=BDSisEstudiantil;Integrated Security=True"; // Cadena de conexion a base
        public frmServiciosProductos()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
        }



        private void LoadData()
        {
            // Crea una nueva instancia de DataTable para los datos
            DataTable dataTable = new DataTable();

            // Crea una nueva connection SqlConnection usando el "connectionString"
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta para seleccionar los datos de tabla Proveedor
                string query = "SELECT * FROM Proveedor";

                // Crea un nuevo SqlCommand con la consulta y la conexion
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre la conexion
                    connection.Open();

                    // Crea un SqlDataReader para leer los datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Carga los datos en DataTable
                        dataTable.Load(reader);
                    }
                }
            }

            // Enlaza la tabla de datos al Data Grid View.
            dgvServiciosyProductos.DataSource = dataTable;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void ServiciosProductos_Load(object sender, EventArgs e)
        {
            LoadData(); // Carga los servicios y productos cuando el form se abra.
        }

        private void btnRegresar90_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal(); // Instancia para ir a ventana principal
            ventanaPrincipal.Show(); // Muestra ventana principal
            this.Hide(); // Esconde la ventana actual
        }
    }
}
