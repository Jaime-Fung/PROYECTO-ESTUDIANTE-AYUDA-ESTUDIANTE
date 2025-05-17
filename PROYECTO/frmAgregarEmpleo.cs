using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmAgregarEmpleo : Form
    {
        private const string connectionString = "Data Source=JAIME\\SQLEXPRESS;Initial Catalog = BDSisEstudiantil;Integrated Security=True";//conexion base de datos

        public frmAgregarEmpleo()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public int ConsultarIdNuevoEmpleo()
        {
            int maxId = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(IdEmpleo) FROM Empleo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                        maxId++;
                    }
                }
            }
            return maxId;
        }
        private void btnAgregarEmpleo11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCompa11.Text) || string.IsNullOrEmpty(txtTituloPosicion11.Text) || string.IsNullOrEmpty(cbbUbiCompa11.Text)
                || string.IsNullOrEmpty(cbbModalidadEmpleo11.Text) || string.IsNullOrEmpty(cbbTipoTrabajo11.Text))
            {
                MessageBox.Show("Debe completar todos los datos");

            }
            
            
            else
            {
                string correoElectronico = txtCorreoElectronico11.Text;

                if (CorreoElectronicoValido(correoElectronico))
                {


                    AgregarEmpleo();
                    

                }
                else
                {

                    MessageBox.Show("El correo electronico no es valido");

                }

            }
        }


        private static bool CorreoElectronicoValido(string correoElectronico)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(correoElectronico, patron);
        }


        private void AgregarEmpleo() 
        {
            int IdEmpleo = ConsultarIdNuevoEmpleo();
            string correoElectronico = txtCorreoElectronico11.Text;
            string nombreCompa = txtNombreCompa11.Text;
            string tituloPosicion = txtTituloPosicion11.Text;
            string ubiCompa = cbbUbiCompa11.Text;
            string modalidadEmpleo = cbbModalidadEmpleo11.Text;
            string tipoTrabajo = cbbTipoTrabajo11.Text;

            string sqlQuery = "INSERT INTO Empleo (IdEmpleo, CorreoElectronico, NombreCompannia, TituloPosicion, UbicacionCompannia, ModalidadEmpleo, TipoTrabajo) VALUES (@IdEmpleo, @CorreoElectronico, @NombreCompannia, @TituloPosicion, @UbicacionCompannia, @ModalidadEmpleo, @TipoTrabajo)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@IdEmpleo", IdEmpleo);
                command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                command.Parameters.AddWithValue("@NombreCompannia", nombreCompa);
                command.Parameters.AddWithValue("@TituloPosicion", tituloPosicion);
                command.Parameters.AddWithValue("@UbicacionCompannia", ubiCompa);
                command.Parameters.AddWithValue("@ModalidadEmpleo", modalidadEmpleo);
                command.Parameters.AddWithValue("@TipoTrabajo", tipoTrabajo);

                try
                {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " Trabajo Posteado Correctamente");
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.Show();
                    this.Hide();    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                txtCorreoElectronico11.Text = "";
                txtNombreCompa11.Text = "";
                txtTituloPosicion11.Text = "";
                cbbUbiCompa11.Text = "  ";
                cbbModalidadEmpleo11.Text = "  ";
                cbbTipoTrabajo11.Text = "  ";

            }
        }

        private void btnRegresar11_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio(); // Instancia para cargar form inicio
            ventanaInicio.Show(); // Muestra la ventana de Inicio
            this.Hide(); // Se cierra el form actual
        }

        private void btnSalir11_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicacion
        }
    }
}

    


        
    


