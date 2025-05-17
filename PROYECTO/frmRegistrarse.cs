using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO
{
    public partial class frmRegistrarse : Form
    {
        UsuarioCapaDatos cdUsuario = new UsuarioCapaDatos(); // Instancia que utiliza la clase de usuario capa de datos
        public frmRegistrarse()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
        }

        private void btnRegistrarse2_Click(object sender, EventArgs e) // Evento creado al darle click a registrarse
        {

            if (string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text)
                || string.IsNullOrEmpty(txtSegundoApellido.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) || string.IsNullOrEmpty(txtCorreo.Text)
                || string.IsNullOrEmpty(txtNumeroTelefonico.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPaisNacimiento.Text)
                || string.IsNullOrEmpty(txtPaisNacimiento.Text) || string.IsNullOrEmpty(txtcontrasenna.Text) || string.IsNullOrEmpty(txtPIN2.Text)) // Valida que todo este completo
            {
                MessageBox.Show("Debe completar todos los datos"); // Muestra mensaje para completar todos los datos

            }
            else if (RbtnMasculino.Checked == false && RbtnFemenino.Checked == false && RbtnOtro.Checked == false) // Si no se selecciono un genero
            {
                MessageBox.Show("Debe selecionar un genero"); // Muestra mensaje

            }
            else if (RbtnEstudiante.Checked == false) // Si no se selecciono rol de estudiante
            {
                MessageBox.Show("Debe seleccionar el rol de estudiante"); // Muestra este mensaje
            }
            else
            {
                string correoElectronico = txtCorreo.Text;

                if (CorreoElectronicoValido(correoElectronico)) // Si el correo electronico es valido 
                {


                    AgregarUsuario(); // Metodo creado que agrega el usuario a base de datos
                    frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion(); // Instancia para ir a ventana iniciar sesion
                    ventanaIniciarSesion.Show(); // Muestra ventana iniciar sesion
                    this.Hide(); // Esconde ventana actual

                }
                else // si el correo electronico no es valido
                {

                    MessageBox.Show("El correo electronico no es valido"); // Muestra este mensaje

                }//verificar que es un correo electronico valido de registrar

            }//validaciones paravque ningun campo quede incompleto





        }

        private static bool CorreoElectronicoValido(string correoElectronico) // Metodo que confirma que este debe ser el patron para que un correo sea valido
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(correoElectronico, patron);
        }


        public void AgregarUsuario() // Agrega los siguientes datos
        {


            Usuario nuevoUsuario = new Usuario() // Instancia que llama a clase usuario agregando esto
            {
                Id = cdUsuario.ConsultarIdNuevoUsuario(),
                Identificacion = txtIdentificacion.Text,
                Nombre = txtNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text),
                CorreoElectronico = txtCorreo.Text,
                NumeroTelefonico = txtNumeroTelefonico.Text,
                Direccion = txtDireccion.Text,
                PaisNacimiento = txtPaisNacimiento.Text,
                RolEstudiante = RbtnEstudiante.Checked,
                GeneroMasculino = RbtnMasculino.Checked,
                GeneroFemenino = RbtnFemenino.Checked,
                GeneroOtro = RbtnOtro.Checked,
                Contrasenna = txtcontrasenna.Text,
                PIN = txtPIN2.Text,






            };

            
            cdUsuario.RegistrarseUsuario(nuevoUsuario); // Invoca el metodo RegistrarseUsuario del objeto cdUsuario, pasando el objeto nuevoUsuario como parámetro.


        }//agregar usuario a la base de datos

        private void btnRegresar1_Click_1(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio(); // Instancia que llama a ventana Inicio
            ventanaInicio.Show(); // Muestra ventana inicio
            this.Hide(); // Esconde ventana actual
        }

        private void btnCerrarApp4_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void txtNumeroTelefonico_KeyPress(object sender, KeyPressEventArgs e) // Evento que asegura que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }//no admitir letras
        }

        private void MostrarContrasenna_CheckedChanged(object sender, EventArgs e) // Evento que permite al usuario ver la contraseña que ingresa
        {
            if (chkMostrarContrasenna.Checked == true) 
            {

                txtcontrasenna.UseSystemPasswordChar = false;

            }
            else
            {
                txtcontrasenna.UseSystemPasswordChar = true;

            }//si se activa el checked, mostrar contraseña
        }

        private void chkMostrarPIN_CheckedChanged(object sender, EventArgs e) // Evento que permite al usuario ver el pin que ingresa
        {
            if (chkMostrarPIN.Checked == true)
            {

                txtPIN2.UseSystemPasswordChar = false;

            }
            else
            {
                txtPIN2.UseSystemPasswordChar = true;

            }//si el checked se activa, mostrar Pin
        }
    }
}