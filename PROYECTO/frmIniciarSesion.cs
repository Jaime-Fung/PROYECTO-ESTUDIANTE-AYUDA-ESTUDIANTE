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
    public partial class frmIniciarSesion : Form
    {
        private string connectionString = "SERVER = JAIME\\SQLEXPRESS; Integrated Security = true; database = BDSisEstudiantil";
        public frmIniciarSesion()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void ConsultaUsuarioContrasenna()        {


            // Se establece la conexión con la base de datos usando la cadena de conexión definida anteriormente.
            SqlConnection connection = new SqlConnection(connectionString);


            // Se define la consulta SQL para seleccionar un usuario con un correo electrónico y contraseña específicos.
            string query = "SELECT * FROM Usuario WHERE CorreoElectronico = @CorreoElectronico AND Contrasenna = @Contrasenna";

            // Se crea un objeto SqlCommand para ejecutar la consulta en la conexión establecida.
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                // Se agregan parámetros a la consulta para evitar la inyección SQL.
                command.Parameters.AddWithValue("@CorreoElectronico", txtCorreo1.Text);
                command.Parameters.AddWithValue("@Contrasenna", txtContrasenna2.Text);

                // Se abre la conexión con la base de datos.
                connection.Open();

                // Se ejecuta la consulta y se obtiene un lector de datos para leer los resultados.
                SqlDataReader verificarDatos = command.ExecuteReader();

                // Se verifica si hay filas devueltas por la consulta.
                if (verificarDatos.HasRows == true)
                {
                    // Si hay filas, se recorren.
                    while (verificarDatos.Read())
                    {
                        // Se asignan los valores obtenidos a propiedades de un objeto ReconocimientoDeUsuario.
                        ReconocimientoDeUsuario.Id = verificarDatos.GetInt32(0);
                        ReconocimientoDeUsuario.CorreoElectronico = verificarDatos.GetString(1);
                        ReconocimientoDeUsuario.Contrasenna = verificarDatos.GetString(2);
                        ReconocimientoDeUsuario.PIN = verificarDatos.GetString(4);  

                        // Se llama a la función ObtenerInformacionPersona para obtener más información de la persona para extraer nombre, apellidos, etc.
                        ObtenerInformacionPersona(ReconocimientoDeUsuario.Id);



                    }
                    ObtenerInformacionUsuario(ReconocimientoDeUsuario.Id);
                    
                    MessageBox.Show("Bienvenido");
                    frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal();
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                }//esto en caso de ingresar datos incorrectos


            }


        }

        public void ObtenerInformacionUsuario(int IdUsuario)//extraer la info del usuario desde la base de datos en tabla usuario
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Persona Where Id = @IdUsuario";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);

            }
        }
        public void ObtenerInformacionPersona(int IdUsuario)//extraer la info del usuario desde la base de datos en la tabla persona
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Persona WHERE Id = @IdUsuario";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);



                connection.Open();

                // Se ejecuta la consulta y se obtiene un lector de datos para leer los resultados.
                SqlDataReader verificarDatos = command.ExecuteReader();

                if (verificarDatos.HasRows == true)
                {
                    while (verificarDatos.Read())
                    {
                        // Se asignan los valores obtenidos a propiedades de un objeto ReconocimientoDeUsuario.
                        ReconocimientoDeUsuario.Id = verificarDatos.GetInt32(0);
                        ReconocimientoDeUsuario.Nombre = verificarDatos.GetString(2);
                        ReconocimientoDeUsuario.PrimerApellido = verificarDatos.GetString(3);
                        ReconocimientoDeUsuario.SegundoApellido = verificarDatos.GetString(4);
                        ReconocimientoDeUsuario.Dirrecion = verificarDatos.GetString(6);
                        ReconocimientoDeUsuario.NumeroTelefonico = verificarDatos.GetString(5);



                    }

                }

            }

        }
        private void btnIniciarSesion2_Click_1(object sender, EventArgs e)
        {
            ConsultaUsuarioContrasenna();//llamr metodo
        }

        private void btnRegistrarse8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarse ventanaRegistrarse = new frmRegistrarse();
            ventanaRegistrarse.Show();
            this.Hide();
        }//cambio de ventana

        private void btnCerrarApp3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }//cerrar de ventana

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            ventanaInicio.Show();
            this.Hide();
        }//cambio de ventana

        private void btnOlvidarContrasenna1_Click(object sender, EventArgs e)
        {
            frmOlvidoSuContrasenna ventanaOlvidoSuContrasenna = new frmOlvidoSuContrasenna();
            ventanaOlvidoSuContrasenna.Show();
            this.Hide();
        }//cambio de ventana
    }
}





