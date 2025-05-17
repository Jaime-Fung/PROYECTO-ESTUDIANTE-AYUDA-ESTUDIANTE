using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmSubirMaterialApoyo : Form
    {
        private string nombreArchivoSeleccionado;

        // Se declara la variable archivoPDF como un arreglo de bytes
        private byte[] archivoPDF;

        public frmSubirMaterialApoyo()
        {
            InitializeComponent(); // Inicia el forms
            CenterToScreen(); // Centra la ventana actual
        }

        private void btnSalir269_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            if (cbbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoria.");
                return;
            }
            if (cbbTipoDeDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de Documento.");
                return;
            }
            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Debe indicar quien es el autor o uno de los autores del documento.");
                return;
            }

            // Se aAbre el cuadro de diálogo para seleccionar el archivo PDF
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            openFileDialog.Title = "Seleccionar archivo PDF";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Con esto se obtiene el nombre del archivo seleccionado
                nombreArchivoSeleccionado = Path.GetFileName(openFileDialog.FileName);

                // Con esto se obtiene el archivo PDF y se carga en un arreglo de bytes
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        archivoPDF = ms.ToArray();
                    }
                }

                // Ásí se muestra el nombre del archivo seleccionado en el cuadro de texto
                txtNombre.Text = nombreArchivoSeleccionado;
            }

        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un archivo PDF
            if (archivoPDF == null)
            {
                MessageBox.Show("Por favor, seleccione un archivo PDF.");
                return;
            }

            // Variables definidas
            string categoria = cbbCategoria.SelectedItem.ToString();
            string tipoDeDocumento = cbbTipoDeDocumento.SelectedItem.ToString();
            string nombreDocumento = txtNombre.Text;
            string autor = txtAutor.Text;

            // Así se guarda el documento PDF en la base de datos
            string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";
            string query = "INSERT INTO MaterialApoyo (Categoria, TipoDeDocumento, NombreDocumento, Autor, Documento) VALUES (@Categoria, @TipoDeDocumento, @NombreDocumento, @Autor, @Documento)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@TipoDeDocumento", tipoDeDocumento);
                    command.Parameters.AddWithValue("@NombreDocumento", nombreDocumento);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Documento", archivoPDF);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Documento guardado correctamente en la base de datos.");
                            // Aquí se limpian los controles después de guardar el documento
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el documento en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el documento en la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private void LimpiarControles() // Deja los siguientes campos en blanco
        {
            cbbCategoria.SelectedIndex = -1;
            cbbTipoDeDocumento.SelectedIndex = -1;
            txtNombre.Clear();
            txtAutor.Clear();
            archivoPDF = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ventana = new frmVentanaPrincipal();
            ventana.Show();
            this.Close();
        }
    }
}


