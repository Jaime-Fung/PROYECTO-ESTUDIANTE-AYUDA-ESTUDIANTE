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
    public partial class frmMenuMaterialDeApoyo : Form
    {
        public frmMenuMaterialDeApoyo()
        {
            InitializeComponent();
        }

        private void btnSalir602_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar602_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal();
            ventanaPrincipal.Show();
        }

        private void btnSubirMaterial_Click(object sender, EventArgs e)
        {
            frmSubirMaterialApoyo ventana = new frmSubirMaterialApoyo();
            ventana.Show();
            this.Close();
        }

        private void btnVerMaterial_Click(object sender, EventArgs e)
        {
            frmBuscarMaterialApoyo ventana = new frmBuscarMaterialApoyo();
            ventana.Show();
            this.Close();   
        }
    }
}
