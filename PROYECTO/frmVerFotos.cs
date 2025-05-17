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
    public partial class frmVerFotos : Form
    {
        public frmVerFotos(byte[] imagen1, byte[] imagen2, byte[] imagen3, byte[] imagen4)

        {

            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana
            // Aquí se asignan las imágenes a los PictureBox
            if (imagen1 != null)
                ptbImagen1.Image = ByteArrayToImage(imagen1);
            if (imagen2 != null)
                ptbImagen2.Image = ByteArrayToImage(imagen2);
            if (imagen3 != null)
                ptbImagen3.Image = ByteArrayToImage(imagen3);
            if (imagen4 != null)
                ptbImagen4.Image = ByteArrayToImage(imagen4);
        }

        // Esto es un método para convertir un byte[] en un Image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void btnSalir790_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnRegresar750_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}







