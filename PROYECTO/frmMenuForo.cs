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
    public partial class frmMenuForo : Form
    {
        public frmMenuForo()
        {
            InitializeComponent(); // Inicia forms
            CenterToScreen(); // Centra la ventana
        }

        private void btnRealizarConsulta_Click(object sender, EventArgs e)
        {
            frmFormularConsulta ventana = new frmFormularConsulta(); // Instancia para ir a ventana formular consulta
            ventana.Show(); // Muestra ventana formular consulta
            this.Hide(); // Esconde ventana actual
        }

        private void btnVerForo_Click(object sender, EventArgs e)
        {
            frmBuscarConsulta ventana = new frmBuscarConsulta(); // Instancia para ir a ventana buscar consulta
            ventana.Show(); // Muestra ventana buscar consulta
            this.Hide(); // Esconde ventana actual
        }

        private void btnSalir600_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnRegresar600_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal(); // Instancia para ir a ventana principal
            principal.Show(); // Muestra ventana principal
            this.Hide(); // Esconde ventana actual
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
