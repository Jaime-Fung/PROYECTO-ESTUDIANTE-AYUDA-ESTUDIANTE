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

namespace PROYECTO
{
    public partial class frmBolsaEmpleo : Form
    {
        private string connectionString = "Data Source=JAIME\\SQLEXPRESS;Initial Catalog=BDSisEstudiantil;Integrated Security=True";
        public frmBolsaEmpleo()
        {
            InitializeComponent();
            CenterToScreen();
        }



        private void LoadData()
        {
            // Crea una nueva instancia de DataTable para los datos
            DataTable dataTable = new DataTable();

            // Crea una nueva connection SqlConnection usando el "connectionString"
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta para seleccionar los datos
                string query = "SELECT * FROM Empleo";

                // Crea un nuevo SqlCommand con la consulta y la conexion
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre la conexion
                    connection.Open();

                    // Crea un SqlDataReader para leer los datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Carga los datos en DataTable
                        dataTable.Load(reader);
                    }
                }
            }

            // Enlaza la tabla de datos con el datagridview
            dgvBolsaEmpleo.DataSource = dataTable;
        }

        private void frmBolsaEmpleo_Load_1(object sender, EventArgs e)
        {
            LoadData(); // Carga los datos en el DataGridView cuando el form se abra
        }

        private void btnSalir12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar12_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ventanaPrincipal = new frmVentanaPrincipal();
            ventanaPrincipal.Show();
            this.Hide();
        }

        private void lklblAgregaEmpleo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarEmpleo ventanaAgregarEmpleo = new frmAgregarEmpleo();
            ventanaAgregarEmpleo.Show();
            this.Hide();
        }
    }
}

