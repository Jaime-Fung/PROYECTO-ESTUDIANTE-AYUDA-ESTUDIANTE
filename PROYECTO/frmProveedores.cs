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
    public partial class frmProveedores : Form
    {
        private const string connectionString =
            "Data Source=JAIME\\SQLEXPRESS;Initial Catalog=BDSisEstudiantil;Integrated Security=True"; // Cadena de conexion a base de datos

        public frmProveedores()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion

        }

        private void btnRegresar37_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio(); // Instancia para llamar ventana inicio
            ventanaInicio.Show(); // Muestra ventana inicio
            this.Hide(); // Esconde la ventana actual
        }
        public int ConsultarIdNuevoProveedor() // Método que consulta y devuelve el ID más alto de los proveedores existentes en la base de datos.
        {
            int maxId = 1; // Se establece valor predeterminado para el ID maximo como 1

            using (SqlConnection connection = new SqlConnection(connectionString)) // Se establece la conexión a la base de datos utilizando la cadena de conexion especificada arriba
            {
                string query = "SELECT MAX(IdProveedor) FROM Proveedor"; // Se define la consulta SQL para obtener el valor maximo del ID de la tabla Proveedor.

                using (SqlCommand command = new SqlCommand(query, connection)) // Se crea un comando 1 vez para ejecutar la consulta SQL en la conexión establecida.
                {
                    connection.Open(); // Abre la conexion
                    var result = command.ExecuteScalar(); // Ejecuta consulta
                    if (result != DBNull.Value) // Si el resultado no es nulo
                    {
                        maxId = Convert.ToInt32(result);
                        maxId++;
                    }
                }
            }
            return maxId; // Se devuelve un nuevo ID unico
        }
        private void BtnPublicar_Click(object sender, EventArgs e) // Cuando se da al boton click agrega a base 
        {
            int IdProveedor = ConsultarIdNuevoProveedor();
            string nombreApellido = txtNombreApellido12.Text;
            string numeroTelefono = txtNumeroTelefono12.Text;
            string tipoProducto = cbbTipoProducto.Text;
            string descripcionProducto = txtDescripProducto.Text;
            string horarioTrabajo = txtHorarioTrabajo.Text;
            string servicioDomicilio = cbServicioDomicilio.Text;
            int dispProducto = Convert.ToInt32(numupdwnDispProducto.Text);

            string sqlQuery = "INSERT INTO Proveedor (IdProveedor, NombreApellido, NumeroTelefonico, TipoProducto, DescripcionProducto, HorarioTrabajo, ServicioDomicilio, DisponibilidadProducto) VALUES (@IdProveedor, @NombreApellido, @NumeroTelefonico, @TipoProducto, @DescripcionProducto, @HorarioTrabajo, @ServicioDomicilio, @DisponibilidadProducto)";
            // Consulta que inserta en la tabla proveedor los valores definidos
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, con); // Comando a SQL que agrega los valores
                command.Parameters.AddWithValue("@IdProveedor", IdProveedor); 
                command.Parameters.AddWithValue("@NombreApellido", nombreApellido);
                command.Parameters.AddWithValue("@NumeroTelefonico", numeroTelefono);
                command.Parameters.AddWithValue("@TipoProducto", tipoProducto);
                command.Parameters.AddWithValue("@DescripcionProducto", descripcionProducto);
                command.Parameters.AddWithValue("@HorarioTrabajo", horarioTrabajo);
                command.Parameters.AddWithValue("@ServicioDomicilio", servicioDomicilio);
                command.Parameters.AddWithValue("@DisponibilidadProducto", dispProducto);

                try
                {
                    con.Open(); // Abre conexion
                    int rowsAffected = command.ExecuteNonQuery(); // Si hay columnas afectadas
                    MessageBox.Show(rowsAffected + " Servicio o Producto Posteado Correctamente"); // Muestra que se posteo correctamente
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                txtNombreApellido12.Text = "";
                txtNumeroTelefono12.Text = "";
                cbbTipoProducto.Text = "  ";
                txtDescripProducto.Text = "";
                txtHorarioTrabajo.Text = "";
                cbServicioDomicilio.Text = "  ";
                numupdwnDispProducto.Text = "0";//limpiar campos
            }
        }//publicar un nuevo producto o servicio

        private void txtNumeroTelefono12_KeyPress(object sender, KeyPressEventArgs e) // Evento que permite solo numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//solo numeros
        }
    }
}





