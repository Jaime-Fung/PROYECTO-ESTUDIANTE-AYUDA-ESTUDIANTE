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
using PROYECTO.Cache;

namespace PROYECTO
{
    public partial class frmOlvidoSuContrasenna : Form
    {
        private string connectionString = "SERVER = JAIME\\SQLEXPRESS; Integrated Security = true; database = BDSisEstudiantil"; // Declara cadena de conexion a base
        public frmOlvidoSuContrasenna()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
        }

        

        private void btnOlvidarContrasenna_Click(object sender, EventArgs e) // Evento cuando se da click al boton de Olvidar Contraseña 
        {
            string CorreoElectronico = txtCorreoElectronico3.Text;
            ReconocimientoDeUsuario.PIN = txtPIN.Text;
            string nuevaContrasenna = txtNuevaContrasenna3.Text;
            

            if (VerificarCorreoYPin(CorreoElectronico, ReconocimientoDeUsuario.PIN)) // Si verifica el correo electronico y pin correcto
            {
                // Actualizar la contraseña en la base de datos
                ActualizarContraseña(CorreoElectronico, nuevaContrasenna);
                MessageBox.Show("Contraseña actualizada correctamente."); // Muestra este mensaje
                frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
                frmIniciarSesion.Show();
                this.Hide();

            }
            else // Si no 
            {
                MessageBox.Show("El correo electrónico y/o PIN son incorrectos."); // Muestra este mensaje
            }


        }
        private bool VerificarCorreoYPin(string CorreoElectronico, string PIN) // Verifica el correo y pin del usuario
        {

            using (SqlConnection connection = new SqlConnection(connectionString)) // Instancia que llama a la cadena de conexion declarada y aplica lo de abajo una vez
            {

                connection.Open(); // Abre la conexion
                string query = "SELECT COUNT(*) FROM Usuario WHERE CorreoElectronico = @CorreoElectronico AND PIN = @PIN"; // En SQL selecciona la cuenta de tabla usuario de los valores correo electronico y pin
                SqlCommand command = new SqlCommand(query, connection); // Comando que contiene 2 parametros de consulta y la conexion
                command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico); // Agrega o selecciona los valores Correo electronico y pin
                command.Parameters.AddWithValue("@PIN", PIN);

                int verificacion = (int)command.ExecuteScalar(); 
                return verificacion > 0;
            }//validar el Pin de acceso y correo



        }
        private void ActualizarContraseña(string CorreoElectronico, string nuevaContrasenna)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) // Instancia que llama a la cadena de conexion declarada y aplica lo de abajo una vez
            {

                connection.Open(); // Abre la conexion

                string query = "UPDATE Usuario SET Contrasenna = @NuevaContrasenna WHERE CorreoElectronico = @CorreoElectronico"; // Consulta en base de datos que actualiza en tabla usuario la contraseña
                SqlCommand command = new SqlCommand(query, connection); // Comando que agrega los valores.
                command.Parameters.AddWithValue("@NuevaContrasenna", nuevaContrasenna);
                command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                command.ExecuteNonQuery();
                //actualizacion de datos
            }
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e) // Solo permite numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSalirOlvidoContra_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnRegresarOlvidoContra_Click_1(object sender, EventArgs e)
        {
            frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion(); // Instancia para ir a ventana Iniciar Sesion
            ventanaIniciarSesion.Show(); // Muestra la ventana Iniciar Sesion
            this.Hide(); // Esconde la ventana actual
        }
    }
}
