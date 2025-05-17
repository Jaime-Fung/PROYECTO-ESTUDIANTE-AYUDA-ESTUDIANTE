using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PROYECTO.Cache;

namespace PROYECTO
{
    public partial class frmRestaurarContrasenna : Form
    {
        private string connectionString = "SERVER = JAIME\\SQLEXPRESS; Integrated Security = true; database = BDSisEstudiantil"; // Cadena de conexion a base

        public frmRestaurarContrasenna()
        {
            InitializeComponent(); // Inicia el form
            CenterToScreen(); // Centra la ventana
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion(); // Instancia para ir a ventana iniciar sesion
            ventanaIniciarSesion.Show(); // Muestra ventana Iniciar sesion
            this.Hide(); // Esconde ventana actual
        }

        private void btnCerrarApp2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnConfirmarContrasenna_Click(object sender, EventArgs e)
        {

            ActualizarContrasenna(ReconocimientoDeUsuario.Id, txtNuevaContrasenna.Text); // Llama al metodo creado abajo para la actualizacion de contraseña
            frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion(); // Instancia para llamar a ventana iniciar sesion
            ventanaIniciarSesion.Show(); // Muestra ventana iniciar sesion
            this.Hide(); // Esconde la ventana actual

        }


        private void ActualizarContrasenna(int IdUsuario, string Contrasenna) // Metodo para la actualizacion de contraseña
        {





            




            if (ReconocimientoDeUsuario.Contrasenna == txtContraActual.Text) // Si la contraseña del usuario actual es igual al texto que ingreso en el textbox de contraseña actual.
            {
                if (txtNuevaContrasenna.Text == txtConfirmarContrasenna.Text)//si las contraseñas coinciden
                {

                    SqlConnection connection = new SqlConnection(connectionString); // Instancia para llamar a la cadena de conexion a base
                    {
                        string query = "UPDATE Usuario SET Contrasenna = @Contrasenna WHERE IdUsuario = @IdUsuario";//actualizar contraseña donde IdUsuario sea igual a @Idusuario


                        using (SqlCommand command = new SqlCommand(query, connection)) // Comando que llama la consulta y la conexion 1 vez y agrega los valores abajo a SQL
                        {


                            command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                            command.Parameters.AddWithValue("@Contrasenna", Contrasenna);


                            connection.Open(); // Abre conexion





                            int tablaAfectada = command.ExecuteNonQuery(); // Comando que ve las tablas afectadas en base

                            if (tablaAfectada > 0) // Si el numero de tablas afectas es mayor a 0 
                            {
                                MessageBox.Show("Contrasena actualizada correctamente"); // Muestra este mensaje
                            }
                            else // Si no 
                            {
                                MessageBox.Show("No se pudo actualizar la contrasena, porfavor intentelo de nuevo"); // Muestra este mensaje
                            }




                        }

                    }

                }
                else // Si no
                {
                    

                        MessageBox.Show("La nueva contrasena y la confirmacion no coinciden"); // Muestra este mensaje
                        return; //Esto sirve para que no se ejecute el resto del codigo para que no se actualice la contrasenna y salga rapido del metodo

                   

                }

            }
            


        }
        private void btnOlvidarContra2_Click(object sender, EventArgs e)
        {

        }
    }
   
}
