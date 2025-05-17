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
    public partial class frmVentanaPrincipal : Form
    {
        private string connectionString = "SERVER = JAIME\\SQLEXPRESS; Integrated Security = true; database = BDSisEstudiantil";
        public frmVentanaPrincipal()
        {
            InitializeComponent(); // Inicia el form
            PersonalizacionSubMenu(); // Metodo para los paneles de abajo
            CenterToScreen(); // Centra la ventana
        }


        private void PersonalizacionSubMenu()
        {
            panel1.Visible = false;//se declara el panel1 cono invisible
        }
        private void HideSubMenu()
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;//Metodo para esconder el panel 1
            };
        }
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;//metodo para econder el panel1
            }
            else
            {
                submenu.Visible = false;
            }
        }



        private void btnMPrincipal_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel1); // Muestra el panel 1
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) // Envia a ventana de Inicio, cerrando sesion actual
        {
            frmInicio cerrarSesion = new frmInicio(); // Instancia para llamar ventana inicio
            cerrarSesion.Show(); // Muestra ventana inicio
            this.Hide(); // Esconde la ventana actual
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            ObtenerInformacionPersona(ReconocimientoDeUsuario.Id); // Metodo para identificar el usuario actual
            frmEditarPerfil ventanaEditarPerfil = new frmEditarPerfil(); // Instancia que llama a la pantalla Editar Perfil
            ventanaEditarPerfil.Show(); // Muestra ventana editar perfil
            this.Hide(); // Esconde ventana actual
        }
        public void ObtenerInformacionPersona(int IdUsuario) // Obtiene informacion del usuario
        {
            SqlConnection connection = new SqlConnection(connectionString); // Instancia de conexion que llama la cadena de conexion declarada.

            string query = "SELECT * FROM Persona WHERE Id = @IdUsuario"; // Consulta en SQL que selecciona de la tabla Persona el ID del usuario actual

            using (SqlCommand command = new SqlCommand(query, connection)) // Crea una consulta y conexion contra base de datos que se usa solo 1 vez
            {
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario); // Escoge y agrega los valores ID del Usuario a SQL



                connection.Open(); // Abre conexion a SQL

                SqlDataReader verificarDatos = command.ExecuteReader(); // Lee datos de la base los verifica y los devuelve en este verificando los datos.

                if (verificarDatos.HasRows == true)
                {
                    while (verificarDatos.Read())
                    {

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

        private void btnBolsaEmpleo_Click(object sender, EventArgs e)
        {
            frmBolsaEmpleo ventanaBolsaEmpleo = new frmBolsaEmpleo(); // Instancia para ir a la ventana bolsa de empleo
            ventanaBolsaEmpleo.Show(); // Muestra la ventana bolsa de empleo
            this.Hide(); // Esconde la ventana actual
        }

        private void btnProductosServicios_Click(object sender, EventArgs e)
        {
            frmServiciosProductos ventanaServiciosProductos = new frmServiciosProductos(); // Instancia para ir a ventana Servicios y productos
            ventanaServiciosProductos.Show(); // Muestra ventana Servicios y productos
            this.Hide(); // Esconde ventana actual
        }

        private void btnMenuForo_Click(object sender, EventArgs e)
        {
            frmMenuForo ventanaMenuForo = new frmMenuForo(); // Instancia para ir a ventana menu foro
            ventanaMenuForo.Show(); // Muestra ventana menu foro
            this.Hide(); // Esconde ventana actual
        }

        private void btnBienesRaices_Click(object sender, EventArgs e)
        {

            frmMenuBienesRaices ventanaAgenteBR = new frmMenuBienesRaices(); // Instancia para ir a ventana agent bienes raices
            ventanaAgenteBR.Show(); // Muestra ventana agente bienes raices
            this.Hide(); // Esconde ventana actual
        }

        private void btnMateriaDeApoyo_Click(object sender, EventArgs e)
        {
            frmMenuMaterialDeApoyo ventana = new frmMenuMaterialDeApoyo();
            ventana.Show();
            this.Close();
        }
    }
}
