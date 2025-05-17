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
    public partial class frmBuscarMaterialApoyo : Form
    {
        public frmBuscarMaterialApoyo()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se verifica si se ha seleccionado una categoría
            if (cbbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }
            // Se obtiene la categoría seleccionada
            string categoria = cbbCategoria.SelectedItem.ToString();

            // Esta es la consulta a la base de datos para obtener los documentos de la categoría seleccionada
            string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";
            string query = "SELECT IdMaterialApoyo, NombreDocumento, Autor, TipoDeDocumento FROM MaterialApoyo WHERE Categoria = @Categoria";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Categoria", categoria);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Con esto se crea un DataTable para almacenar los resultados de la consulta
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Aquí se asigna el DataTable como origen de datos del DataGridView
                        dgvBuscarPdf.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar documentos: " + ex.Message);
                    }
                }
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            // Se verifica si se ha seleccionado una fila en el DataGridView
            if (dgvBuscarPdf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un documento para descargar.");
                return;
            }

            // Se obtiene el nombre del documento seleccionado en la fila actual
            string nombreDocumento = dgvBuscarPdf.SelectedRows[0].Cells["NombreDocumento"].Value.ToString();

            // Se realiza una consulta a la base de datos para obtener el documento PDF seleccionado
            string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";
            string query = "SELECT Documento FROM MaterialApoyo WHERE NombreDocumento = @NombreDocumento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreDocumento", nombreDocumento);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        // Verificar si se obtuvo algún resultado
                        if (result != null)
                        {
                            // Se convierte el resultado a un arreglo de bytes
                            byte[] documentoBytes = (byte[])result;

                            // Guardar el archivo PDF en el disco
                            string rutaDescarga = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreDocumento + ".pdf");
                            File.WriteAllBytes(rutaDescarga, documentoBytes);

                            MessageBox.Show("El documento se ha descargado correctamente en el escritorio.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el documento en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al descargar el documento: " + ex.Message);
                    }
                }
            }
        }

        private void btnCerrar950_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal();
            ventanaPrincipal.Show();
        }
    }
}




