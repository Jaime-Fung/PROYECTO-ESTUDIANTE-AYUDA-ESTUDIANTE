using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.Cache;

namespace PROYECTO
{
    public partial class frmAgregarOferta : Form
    {
        // Aquí se define el diccionario de provincias y cantones
        Dictionary<string, List<string>> provinciasYCantones = new Dictionary<string, List<string>>
        {
            { "San José", new List<string> { "San José", "Escazú", "Desamparados", "Puriscal", "Tarrazú", "Aserrí", "Mora", "Goicoechea", "Santa Ana", "Alajuelita", "Vázquez de Coronado", "Acosta", "Tibás", "Moravia", "Montes de Oca", "Turrubares", "Dota", "Curridabat", "Pérez Zeledón", "León Cortés Castro" } },
            { "Alajuela", new List<string> { "Alajuela", "San Ramón", "Grecia", "San Mateo", "Atenas", "Naranjo", "Palmares", "Poás", "Orotina", "San Carlos", "Alfaro Ruiz", "Valverde Vega", "Upala", "Los Chiles", "Guatuso" } },
            { "Cartago", new List<string> { "Cartago", "Paraíso", "La Unión", "Jiménez", "Turrialba", "Alvarado", "Oreamuno", "El Guarco" } },
            { "Heredia", new List<string> { "Heredia", "Barva", "Santo Domingo", "Santa Bárbara", "San Rafael", "San Isidro", "Belén", "Flores", "San Pablo", "Sarapiquí" } },
            { "Guanacaste", new List<string> { "Liberia", "Nicoya", "Santa Cruz", "Bagaces", "Carrillo", "Cañas", "Abangares", "Tilarán", "Nandayure", "La Cruz", "Hojancha" } },
            { "Puntarenas", new List<string> { "Puntarenas", "Esparza", "Buenos Aires", "Montes de Oro", "Osa", "Quepos", "Golfito", "Coto Brus", "Parrita", "Corredores", "Garabito" } },
            { "Limón", new List<string> { "Limón", "Pococí", "Siquirres", "Talamanca", "Matina", "Guácimo" } }
        };

        //OJO
        private string[] rutasDeImagenesSeleccionadas = new string[4]; // Array para almacenar las rutas de las imágenes seleccionadas


        //Variables para la conexion de la base de datos.
        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";
        private static string usuarioBaseDatos = "";
        private static string contrasennaBaseDatos = "";
        private string connectionString = $"Data Source = {nombreServidor}; Initial Catalog = {nombreBaseDatos}; Integrated Security = true; User ID = {usuarioBaseDatos}; Password = {contrasennaBaseDatos};";

        //Variables formulario
        private string tipoAlquiler = "";
        private string tipoMoneda = "";
        private double area = 0;
        private string canton = "";
        private string descripcionInmueble = "";
        private string direccionInmueble = "";
        private string distrito = "";
        private string linkWeb = "";
        private double precioMensual = 0;
        private string provincia = "";
        private string serviciosIncluidos = "";
        private string oferente = "";
        private string correo = "";
        private string telefono = "";


        public frmAgregarOferta()
        {
            InitializeComponent(); // Inicia el form
            CenterToScreen(); // Centra la ventana
            lblCorreo.Text = ReconocimientoDeUsuario.CorreoElectronico;
            // Agregar las provincias al ComboBox1
            cbbProvincia.Items.AddRange(provinciasYCantones.Keys.ToArray());

            // Asignar el evento SelectedIndexChanged al ComboBox1
            cbbProvincia.SelectedIndexChanged += CbbProvincia_SelectedIndexChanged;

            // Se suscribe el evento Click del botón btnAgregarFoto1 a btnAgregarFoto

            btnAgregarFoto1.Click += btnAgregarFoto_Click;
            btnAgregarFoto2.Click += btnAgregarFoto_Click;
            btnAgregarFoto3.Click += btnAgregarFoto_Click;
            btnAgregarFoto4.Click += btnAgregarFoto_Click;

        }

        private void CbbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Con esto se limpian las opciones anteriores del ComboBox
            cbbCanton.Items.Clear();

            // Aquí se obtiene el nombre de la provincia seleccionada en el ComboBox
            string provinciaSeleccionada = cbbProvincia.SelectedItem.ToString();

            // Se verifica si la provincia seleccionada existe en el diccionario
            if (provinciasYCantones.ContainsKey(provinciaSeleccionada))
            {
                // Se obtiene la lista de cantones correspondiente a la provincia seleccionada
                List<string> cantones = provinciasYCantones[provinciaSeleccionada];

                // Se agregan los cantones al ComboBox
                cbbCanton.Items.AddRange(cantones.ToArray());
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmAgenteBienesRaices frmAgenteBienesRaices = new frmAgenteBienesRaices();
            frmAgenteBienesRaices.Show();
            this.Close();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbbTipoAlquiler.SelectedIndex = -1;
            cbbTipoMoneda.SelectedIndex = -1;
            txtArea.Clear();
            cbbCanton.Items.Clear();
            txtTelefono.Clear();
            txtDescripcionInmueble.Clear();
            txtDireccionInmueble.Clear();
            txtPrecioMensual.Clear();
            cbbProvincia.Items.Clear();
            txtServiciosIncluidos.Clear();
            txtDescripcionInmueble.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (!txtTelefono.MaskCompleted)
            {
                MessageBox.Show("Debe completar el número de teléfono.");
                return;
            }
            if (string.IsNullOrEmpty(txtArea.Text) || string.IsNullOrEmpty(txtDescripcionInmueble.Text)
                || string.IsNullOrEmpty(txtDireccionInmueble.Text) || string.IsNullOrEmpty(txtPrecioMensual.Text) || string.IsNullOrEmpty(txtServiciosIncluidos.Text)
                || string.IsNullOrEmpty(txtDescripcionInmueble.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }
            if (cbbTipoAlquiler.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de Alquiler.");
                return;
            }
            if (cbbTipoMoneda.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de moneda del precio de alquiler.");
                return;
            }
            if (cbbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la provincia donde se ubica el inmueble.");
                return;
            }
            if (cbbCanton.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el cantón donde se ubica el inmueble.");
                return;
            }


            tipoAlquiler = cbbTipoAlquiler.SelectedItem?.ToString();
            tipoMoneda = cbbTipoMoneda.SelectedItem?.ToString();
            area = Convert.ToDouble(txtArea.Text);
            canton = cbbCanton.SelectedItem?.ToString();
            descripcionInmueble = txtDescripcionInmueble.Text;
            direccionInmueble = txtDireccionInmueble.Text;
            telefono = txtTelefono.Text;
            precioMensual = Convert.ToDouble(txtPrecioMensual.Text);
            provincia = cbbProvincia.SelectedItem?.ToString();
            serviciosIncluidos = txtServiciosIncluidos.Text;
            descripcionInmueble = txtDescripcionInmueble.Text;
            correo = lblCorreo.Text;

            try
            {
                // Acá se leen las imágenes seleccionadas como un arreglo de bytes
                byte[][] imagenesBytesList = new byte[4][];
                for (int i = 0; i < 4; i++)
                {
                    if (!string.IsNullOrEmpty(rutasDeImagenesSeleccionadas[i]))
                    {
                        imagenesBytesList[i] = File.ReadAllBytes(rutasDeImagenesSeleccionadas[i]);
                    }
                    else
                    {
                        imagenesBytesList[i] = null;
                    }
                }

                // Conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Se realiza la consulta SQL para insertar los datos y las imágenes en la tabla AgenteBienesRaices
                    string query = "INSERT INTO AgenteBienesRaices (TipoAlquiler, TipoMoneda, Area, Canton, DescripcionInmueble, PrecioMensual, Provincia, ServiciosIncluidos, DireccionInmueble, Correo, Telefono, Imagen1, Imagen2, Imagen3, Imagen4) VALUES (@TipoAlquiler, @TipoMoneda, @Area, @Canton, @DescripcionInmueble, @PrecioMensual, @Provincia, @ServiciosIncluidos, @DireccionInmueble, @Correo, @Telefono, @Imagen1, @Imagen2, @Imagen3, @Imagen4)";

                    // Comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros para los datos y las imágenes
                        command.Parameters.AddWithValue("@TipoAlquiler", tipoAlquiler);
                        command.Parameters.AddWithValue("@TipoMoneda", tipoMoneda);
                        command.Parameters.AddWithValue("@Area", area);
                        command.Parameters.AddWithValue("@Canton", canton);
                        command.Parameters.AddWithValue("@DescripcionInmueble", descripcionInmueble);
                        command.Parameters.AddWithValue("@PrecioMensual", precioMensual);
                        command.Parameters.AddWithValue("@Provincia", provincia);
                        command.Parameters.AddWithValue("@ServiciosIncluidos", serviciosIncluidos);
                        command.Parameters.AddWithValue("@DireccionInmueble", direccionInmueble);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Telefono", telefono);

                        // Se asignan los bytes de las imágenes o nulls a los parámetros correspondientes
                        for (int i = 0; i < 4; i++)
                        {
                            if (imagenesBytesList[i] != null)
                            {
                                command.Parameters.AddWithValue($"@Imagen{i + 1}", imagenesBytesList[i]);
                            }
                            else
                            {
                                command.Parameters.Add($"@Imagen{i + 1}", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                            }
                        }


                        connection.Open();

                        // command es el objeto, executenonquery es el metodo para ejecutar una consulta sql que no devuelve datos
                        // sino un entero
                        int filasAfectadas = command.ExecuteNonQuery();

                        // Con estose muestra un mensaje según el resultado
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Los datos se registraron correctamente.");
                            frmMenuBienesRaices frmMenuBienesRaices = new frmMenuBienesRaices();
                            frmMenuBienesRaices.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron registrar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos y las imágenes: {ex.Message}");
            }
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Esto determina el índice del botón presionado
                    int indice = -1;
                    if (sender == btnAgregarFoto1)
                        indice = 0;
                    else if (sender == btnAgregarFoto2)
                        indice = 1;
                    else if (sender == btnAgregarFoto3)
                        indice = 2;
                    else if (sender == btnAgregarFoto4)
                        indice = 3;

                    if (indice != -1)
                    {
                        // Se empata la ruta de la imagen seleccionada al índice correspondiente
                        rutasDeImagenesSeleccionadas[indice] = openFileDialog.FileName;


                        MessageBox.Show("Imagen seleccionada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al determinar el botón presionado.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                }
            }




        }

             

        private void btnSalir950_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Restringir los textbox de Area y Precio a que solo acepte numeros.
        private void txtArea_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioMensual_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

    


