using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PROYECTO.Cache;

namespace PROYECTO
{
    public partial class frmEditarPerfil : Form
    {
        private string connectionString =
            "Data Source=JAIME\\SQLEXPRESS;Initial Catalog=BDSisEstudiantil;Integrated Security=True"; // Cadena de conexion a base de datos

        public frmEditarPerfil()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
            txtNombreE.Text = ReconocimientoDeUsuario.Nombre; // Reconoce y agrega los datos del usuario actual
            txtPrimerApellidoE.Text = ReconocimientoDeUsuario.PrimerApellido;
            txtCorreoElectronicoE.Text = ReconocimientoDeUsuario.CorreoElectronico;
            txtSegundoApellido.Text = ReconocimientoDeUsuario.SegundoApellido;
            txtDireccionExactaE.Text = ReconocimientoDeUsuario.Dirrecion;
            txtNumeroTelefonicoE.Text = ReconocimientoDeUsuario.NumeroTelefonico;

        }





        private void btnCerrarApp10_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal(); // Instancia para ir a ventana principal
            ventanaPrincipal.Show(); // Muestra ventana principal
            this.Hide(); // Esconde ventana actual
        }

        private void btnCambiarContra6_Click(object sender, EventArgs e)
        {
            frmRestaurarContrasenna ventanaRestaurarContrasenna = new frmRestaurarContrasenna(); // Instancia para ir a ventana restaurar contraseña
            ventanaRestaurarContrasenna.Show(); // Muestra ventana restaurar contraseña
            this.Hide(); // Esconde ventana actual
        }



        

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            GuardarInformacionModificada(ReconocimientoDeUsuario.Id); // Llama al metodo creado abajo
        }

        private void GuardarInformacionModificada(int IdUsuario) // Metodo que guarda en base info modificada
        { // Declara estas 3 variables para modificar
            string nombre = txtNombreE.Text;
            string primerApellido = txtPrimerApellidoE.Text;
            string segundoApellido = txtSegundoApellido.Text;
            
            string NumeroTelefonico = txtNumeroTelefonicoE.Text;
            string Direccion = txtDireccionExactaE.Text;
            

            SqlConnection connection = new SqlConnection(connectionString); // Instancia para conexion a base con cadena especificada
            {
                string query = "UPDATE Persona SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, NumeroTelefonico = @NumeroTelefonico, Direccion = @Direccion WHERE Id = @IdUsuario"; // Consulta en SQL que actualiza la tabla persona


                using (SqlCommand command = new SqlCommand(query, connection)) // Comando que se utiliza una vez modificando los valores abajo
                {


                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    command.Parameters.AddWithValue("@Nombre" , nombre);
                    command.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                    
                    command.Parameters.AddWithValue("@NumeroTelefonico", NumeroTelefonico);
                    command.Parameters.AddWithValue("@Direccion", Direccion);


                    connection.Open(); // Abre la conexion





                    int tablaAfectada = command.ExecuteNonQuery(); // Comando que lee y devuelve

                    if (tablaAfectada > 0) // Si el numero de tablas afectadas es mayor a 0
                    {
                        MessageBox.Show("Datos guardados correctamente"); // Muestra este mensaje
                    }
                    else // Si no 
                    {
                        MessageBox.Show("No se pudo actualizar los datos porfavor intentelo de nuevo"); // Muestra este mensaje
                    }




                }

            }

        }
    }
}
