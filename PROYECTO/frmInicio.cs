using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            CenterToScreen(); // Centra la ventana.
        }

        private void btnIniciarSesion1_Click_1(object sender, EventArgs e)
        {
            frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion();
            ventanaIniciarSesion.Show();
            this.Hide(); // Hace el cambio de Pantalla de Inicio a ventana de Iniciar Sesion.

        }

        private void btnRegistrarse1_Click_1(object sender, EventArgs e)
        {
            frmRegistrarse ventanaRegistrarse = new frmRegistrarse();
            ventanaRegistrarse.Show();
            this.Hide(); // // Hace el cambio de Pantalla de Inicio a ventana Registrarse
        }

        private void btnCerrarApp1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la Aplicacion
        }

        private void lklblAgregaEmpleo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarEmpleo ventanaAgregarEmpleo = new frmAgregarEmpleo();
            ventanaAgregarEmpleo.Show();
            this.Hide();//cambio ventana
        }

        private void lblInformacionInvitado_Click(object sender, EventArgs e)
        {

        }

        private void lklblServProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProveedores ventanaProveedores = new frmProveedores();
            ventanaProveedores.Show();
            this.Hide();//cambio ventana
        }
    }
}