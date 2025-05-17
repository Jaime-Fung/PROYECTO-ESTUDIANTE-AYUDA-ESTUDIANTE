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
    public partial class frmMenuBienesRaices : Form
    {
        public frmMenuBienesRaices()
        {
            InitializeComponent();
        }

        private void btnRegresar601_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal(); // Instancia para ir a ventana principal
            principal.Show(); // Muestra ventana principal
            this.Hide(); // Esconde ventana actual
        }

        private void btnSalir601_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnnadirOferta_Click(object sender, EventArgs e)
        {
            frmAgenteBienesRaices ventana = new frmAgenteBienesRaices();
            ventana.Show();
            this.Close();
        }

        private void btnVerOfertasDisponibles_Click(object sender, EventArgs e)
        {
            frmOfertasVivienda ventana = new frmOfertasVivienda();
            ventana.Show();
            this.Close();
        }
    }
}
