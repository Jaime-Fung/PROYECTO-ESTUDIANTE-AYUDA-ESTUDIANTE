namespace PROYECTO
{
    partial class frmRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarse));
            btnRegresar1 = new Button();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtcontrasenna = new TextBox();
            lblContrasenna = new Label();
            txtPaisNacimiento = new TextBox();
            pictureBox1 = new PictureBox();
            txtNumeroTelefonico = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new RichTextBox();
            gBoxRol = new GroupBox();
            RbtnEstudiante = new RadioButton();
            btnCerrarApp4 = new Button();
            btnRegistrarse2 = new Button();
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            lblPaisNacimiento = new Label();
            txtSegundoApellido = new TextBox();
            lblNumeroTelefonico = new Label();
            txtPrimerApellido = new TextBox();
            txtNombre = new TextBox();
            gBoxGenero = new GroupBox();
            RbtnFemenino = new RadioButton();
            RbtnOtro = new RadioButton();
            RbtnMasculino = new RadioButton();
            lblSegundoApellido = new Label();
            lblPrimerApellido = new Label();
            lblNombre = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            label1 = new Label();
            txtPIN2 = new TextBox();
            chkMostrarContrasenna = new CheckBox();
            chkMostrarPIN = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gBoxRol.SuspendLayout();
            gBoxGenero.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar1
            // 
            btnRegresar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar1.Location = new Point(13, 1175);
            btnRegresar1.Margin = new Padding(5);
            btnRegresar1.Name = "btnRegresar1";
            btnRegresar1.Size = new Size(141, 53);
            btnRegresar1.TabIndex = 163;
            btnRegresar1.Text = "Regresar";
            btnRegresar1.UseVisualStyleBackColor = true;
            btnRegresar1.Click += btnRegresar1_Click_1;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(24, 1102);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(259, 32);
            lblFechaNacimiento.TabIndex = 162;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFechaNacimiento.Location = new Point(360, 1097);
            dtpFechaNacimiento.MaxDate = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.MinimumSize = new Size(4, 39);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(570, 39);
            dtpFechaNacimiento.TabIndex = 161;
            dtpFechaNacimiento.Value = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // txtcontrasenna
            // 
            txtcontrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontrasenna.Location = new Point(360, 940);
            txtcontrasenna.Name = "txtcontrasenna";
            txtcontrasenna.Size = new Size(570, 39);
            txtcontrasenna.TabIndex = 160;
            txtcontrasenna.UseSystemPasswordChar = true;
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenna.ForeColor = Color.White;
            lblContrasenna.Location = new Point(25, 940);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(157, 32);
            lblContrasenna.TabIndex = 159;
            lblContrasenna.Text = "Contraseña: ";
            // 
            // txtPaisNacimiento
            // 
            txtPaisNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaisNacimiento.Location = new Point(360, 556);
            txtPaisNacimiento.Margin = new Padding(5);
            txtPaisNacimiento.Name = "txtPaisNacimiento";
            txtPaisNacimiento.Size = new Size(570, 39);
            txtPaisNacimiento.TabIndex = 156;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(443, 20);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(945, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 155;
            pictureBox1.TabStop = false;
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroTelefonico.Location = new Point(360, 478);
            txtNumeroTelefonico.Margin = new Padding(5);
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.Size = new Size(570, 39);
            txtNumeroTelefonico.TabIndex = 154;
            txtNumeroTelefonico.KeyPress += txtNumeroTelefonico_KeyPress;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(25, 751);
            lblDireccion.Margin = new Padding(5, 0, 5, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(210, 32);
            lblDireccion.TabIndex = 153;
            lblDireccion.Text = "Direccion Exacta:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(360, 721);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(570, 94);
            txtDireccion.TabIndex = 137;
            txtDireccion.Text = "";
            // 
            // gBoxRol
            // 
            gBoxRol.Controls.Add(RbtnEstudiante);
            gBoxRol.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gBoxRol.ForeColor = Color.White;
            gBoxRol.Location = new Point(1231, 478);
            gBoxRol.Name = "gBoxRol";
            gBoxRol.Size = new Size(548, 109);
            gBoxRol.TabIndex = 152;
            gBoxRol.TabStop = false;
            gBoxRol.Text = "Consentimiento";
            // 
            // RbtnEstudiante
            // 
            RbtnEstudiante.AutoSize = true;
            RbtnEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RbtnEstudiante.Location = new Point(101, 60);
            RbtnEstudiante.Name = "RbtnEstudiante";
            RbtnEstudiante.Size = new Size(350, 36);
            RbtnEstudiante.TabIndex = 0;
            RbtnEstudiante.TabStop = true;
            RbtnEstudiante.Text = "Declaro que soy estudiante";
            RbtnEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnCerrarApp4
            // 
            btnCerrarApp4.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarApp4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarApp4.Location = new Point(1742, 1184);
            btnCerrarApp4.Name = "btnCerrarApp4";
            btnCerrarApp4.Size = new Size(110, 53);
            btnCerrarApp4.TabIndex = 151;
            btnCerrarApp4.Text = "Salir";
            btnCerrarApp4.UseVisualStyleBackColor = false;
            btnCerrarApp4.Click += btnCerrarApp4_Click_1;
            // 
            // btnRegistrarse2
            // 
            btnRegistrarse2.BackColor = Color.Lime;
            btnRegistrarse2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse2.ForeColor = Color.Black;
            btnRegistrarse2.Location = new Point(1513, 1087);
            btnRegistrarse2.Name = "btnRegistrarse2";
            btnRegistrarse2.Size = new Size(163, 53);
            btnRegistrarse2.TabIndex = 150;
            btnRegistrarse2.Text = "Registrarse";
            btnRegistrarse2.UseVisualStyleBackColor = false;
            btnRegistrarse2.Click += btnRegistrarse2_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacion.Location = new Point(360, 631);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(570, 39);
            txtIdentificacion.TabIndex = 149;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdentificacion.ForeColor = Color.White;
            lblIdentificacion.Location = new Point(25, 631);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(321, 32);
            lblIdentificacion.TabIndex = 148;
            lblIdentificacion.Text = "Número de Identificación: ";
            // 
            // lblPaisNacimiento
            // 
            lblPaisNacimiento.AutoSize = true;
            lblPaisNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaisNacimiento.ForeColor = Color.White;
            lblPaisNacimiento.Location = new Point(25, 556);
            lblPaisNacimiento.Name = "lblPaisNacimiento";
            lblPaisNacimiento.Size = new Size(247, 32);
            lblPaisNacimiento.TabIndex = 147;
            lblPaisNacimiento.Text = "País de Nacimiento: ";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(360, 404);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(570, 39);
            txtSegundoApellido.TabIndex = 146;
            // 
            // lblNumeroTelefonico
            // 
            lblNumeroTelefonico.AutoSize = true;
            lblNumeroTelefonico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroTelefonico.ForeColor = Color.White;
            lblNumeroTelefonico.Location = new Point(24, 485);
            lblNumeroTelefonico.Name = "lblNumeroTelefonico";
            lblNumeroTelefonico.Size = new Size(247, 32);
            lblNumeroTelefonico.TabIndex = 145;
            lblNumeroTelefonico.Text = "Número Telefónico: ";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(360, 327);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(570, 39);
            txtPrimerApellido.TabIndex = 144;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(360, 250);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(570, 39);
            txtNombre.TabIndex = 143;
            // 
            // gBoxGenero
            // 
            gBoxGenero.Controls.Add(RbtnFemenino);
            gBoxGenero.Controls.Add(RbtnOtro);
            gBoxGenero.Controls.Add(RbtnMasculino);
            gBoxGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gBoxGenero.ForeColor = Color.White;
            gBoxGenero.Location = new Point(1231, 361);
            gBoxGenero.Name = "gBoxGenero";
            gBoxGenero.Size = new Size(548, 82);
            gBoxGenero.TabIndex = 142;
            gBoxGenero.TabStop = false;
            gBoxGenero.Text = "Genero";
            // 
            // RbtnFemenino
            // 
            RbtnFemenino.AutoSize = true;
            RbtnFemenino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RbtnFemenino.Location = new Point(14, 25);
            RbtnFemenino.Name = "RbtnFemenino";
            RbtnFemenino.Size = new Size(151, 36);
            RbtnFemenino.TabIndex = 5;
            RbtnFemenino.TabStop = true;
            RbtnFemenino.Text = "Femenino";
            RbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // RbtnOtro
            // 
            RbtnOtro.AutoSize = true;
            RbtnOtro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RbtnOtro.Location = new Point(371, 25);
            RbtnOtro.Name = "RbtnOtro";
            RbtnOtro.Size = new Size(91, 36);
            RbtnOtro.TabIndex = 7;
            RbtnOtro.TabStop = true;
            RbtnOtro.Text = "Otro";
            RbtnOtro.UseVisualStyleBackColor = true;
            // 
            // RbtnMasculino
            // 
            RbtnMasculino.AutoSize = true;
            RbtnMasculino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RbtnMasculino.Location = new Point(181, 25);
            RbtnMasculino.Name = "RbtnMasculino";
            RbtnMasculino.Size = new Size(157, 36);
            RbtnMasculino.TabIndex = 6;
            RbtnMasculino.TabStop = true;
            RbtnMasculino.Text = "Masculino";
            RbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoApellido.ForeColor = Color.White;
            lblSegundoApellido.Location = new Point(25, 407);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(232, 32);
            lblSegundoApellido.TabIndex = 141;
            lblSegundoApellido.Text = "Segundo Apellido: ";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerApellido.ForeColor = Color.White;
            lblPrimerApellido.Location = new Point(25, 327);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(201, 32);
            lblPrimerApellido.TabIndex = 140;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(35, 250);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(151, 32);
            lblNombre.TabIndex = 139;
            lblNombre.Text = "Nombre(s): ";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(360, 858);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(570, 39);
            txtCorreo.TabIndex = 138;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(25, 858);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(241, 32);
            lblCorreo.TabIndex = 136;
            lblCorreo.Text = "Correo Electrónico: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 1023);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 164;
            label1.Text = "PIN de seguridad";
            // 
            // txtPIN2
            // 
            txtPIN2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIN2.Location = new Point(360, 1020);
            txtPIN2.Name = "txtPIN2";
            txtPIN2.Size = new Size(570, 39);
            txtPIN2.TabIndex = 165;
            txtPIN2.UseSystemPasswordChar = true;
            // 
            // chkMostrarContrasenna
            // 
            chkMostrarContrasenna.AutoSize = true;
            chkMostrarContrasenna.ForeColor = SystemColors.Control;
            chkMostrarContrasenna.Location = new Point(942, 942);
            chkMostrarContrasenna.Margin = new Padding(2);
            chkMostrarContrasenna.Name = "chkMostrarContrasenna";
            chkMostrarContrasenna.Size = new Size(105, 29);
            chkMostrarContrasenna.TabIndex = 166;
            chkMostrarContrasenna.Text = "Mostrar";
            chkMostrarContrasenna.UseVisualStyleBackColor = true;
            chkMostrarContrasenna.CheckedChanged += MostrarContrasenna_CheckedChanged;
            // 
            // chkMostrarPIN
            // 
            chkMostrarPIN.AutoSize = true;
            chkMostrarPIN.ForeColor = SystemColors.Control;
            chkMostrarPIN.Location = new Point(942, 1022);
            chkMostrarPIN.Margin = new Padding(2);
            chkMostrarPIN.Name = "chkMostrarPIN";
            chkMostrarPIN.Size = new Size(105, 29);
            chkMostrarPIN.TabIndex = 167;
            chkMostrarPIN.Text = "Mostrar";
            chkMostrarPIN.UseVisualStyleBackColor = true;
            chkMostrarPIN.CheckedChanged += chkMostrarPIN_CheckedChanged;
            // 
            // frmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1862, 1251);
            Controls.Add(chkMostrarPIN);
            Controls.Add(chkMostrarContrasenna);
            Controls.Add(txtPIN2);
            Controls.Add(label1);
            Controls.Add(btnRegresar1);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtcontrasenna);
            Controls.Add(lblContrasenna);
            Controls.Add(txtPaisNacimiento);
            Controls.Add(pictureBox1);
            Controls.Add(txtNumeroTelefonico);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(gBoxRol);
            Controls.Add(btnCerrarApp4);
            Controls.Add(btnRegistrarse2);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblPaisNacimiento);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblNumeroTelefonico);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(gBoxGenero);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmRegistrarse";
            Text = "frmRegistrarse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gBoxRol.ResumeLayout(false);
            gBoxRol.PerformLayout();
            gBoxGenero.ResumeLayout(false);
            gBoxGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar1;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtcontrasenna;
        private Label lblContrasenna;
        private TextBox txtPaisNacimiento;
        private PictureBox pictureBox1;
        private TextBox txtNumeroTelefonico;
        private Label lblDireccion;
        private RichTextBox txtDireccion;
        private GroupBox gBoxRol;
        private RadioButton RbtnEstudiante;
        private Button btnCerrarApp4;
        private Button btnRegistrarse2;
        private TextBox txtIdentificacion;
        private Label lblIdentificacion;
        private Label lblPaisNacimiento;
        private TextBox txtSegundoApellido;
        private Label lblNumeroTelefonico;
        private TextBox txtPrimerApellido;
        private TextBox txtNombre;
        private GroupBox gBoxGenero;
        private RadioButton RbtnFemenino;
        private RadioButton RbtnOtro;
        private RadioButton RbtnMasculino;
        private Label lblSegundoApellido;
        private Label lblPrimerApellido;
        private Label lblNombre;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label label1;
        private TextBox txtPIN2;
        private PictureBox pictureBox2;
        private CheckBox chkMostrarContrasenna;
        private CheckBox chkMostrarPIN;
    }
}