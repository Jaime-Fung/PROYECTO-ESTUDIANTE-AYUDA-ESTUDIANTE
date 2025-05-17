namespace PROYECTO
{
    partial class frmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesion));
            lblCorreoElectronico9 = new Label();
            btnRegistrarse8 = new LinkLabel();
            btnRegresar2 = new Button();
            btnCerrarApp3 = new Button();
            pictureBox1 = new PictureBox();
            btnIniciarSesion2 = new Button();
            txtContrasenna2 = new TextBox();
            txtCorreo1 = new TextBox();
            lblCorreoElec = new Label();
            lblContrasenna2 = new Label();
            lblUsuario2 = new Label();
            btnOlvidarContrasenna1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCorreoElectronico9
            // 
            lblCorreoElectronico9.AutoSize = true;
            lblCorreoElectronico9.BackColor = Color.Black;
            lblCorreoElectronico9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreoElectronico9.ForeColor = Color.White;
            lblCorreoElectronico9.Location = new Point(212, 305);
            lblCorreoElectronico9.Margin = new Padding(4, 0, 4, 0);
            lblCorreoElectronico9.Name = "lblCorreoElectronico9";
            lblCorreoElectronico9.Size = new Size(245, 32);
            lblCorreoElectronico9.TabIndex = 35;
            lblCorreoElectronico9.Text = "(Correo Electronico)";
            // 
            // btnRegistrarse8
            // 
            btnRegistrarse8.AutoSize = true;
            btnRegistrarse8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse8.LinkColor = Color.Lime;
            btnRegistrarse8.Location = new Point(572, 400);
            btnRegistrarse8.Margin = new Padding(4, 0, 4, 0);
            btnRegistrarse8.Name = "btnRegistrarse8";
            btnRegistrarse8.Size = new Size(141, 32);
            btnRegistrarse8.TabIndex = 34;
            btnRegistrarse8.TabStop = true;
            btnRegistrarse8.Text = "Registrarse";
            btnRegistrarse8.LinkClicked += btnRegistrarse8_LinkClicked;
            // 
            // btnRegresar2
            // 
            btnRegresar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar2.ForeColor = Color.Black;
            btnRegresar2.Location = new Point(17, 617);
            btnRegresar2.Margin = new Padding(4, 5, 4, 5);
            btnRegresar2.Name = "btnRegresar2";
            btnRegresar2.Size = new Size(154, 62);
            btnRegresar2.TabIndex = 33;
            btnRegresar2.Text = "Regresar";
            btnRegresar2.UseVisualStyleBackColor = true;
            btnRegresar2.Click += btnRegresar2_Click;
            // 
            // btnCerrarApp3
            // 
            btnCerrarApp3.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarApp3.FlatStyle = FlatStyle.Flat;
            btnCerrarApp3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarApp3.ForeColor = Color.Black;
            btnCerrarApp3.Location = new Point(597, 617);
            btnCerrarApp3.Margin = new Padding(4, 5, 4, 5);
            btnCerrarApp3.Name = "btnCerrarApp3";
            btnCerrarApp3.Size = new Size(174, 62);
            btnCerrarApp3.TabIndex = 32;
            btnCerrarApp3.Text = "Salir";
            btnCerrarApp3.UseVisualStyleBackColor = false;
            btnCerrarApp3.Click += btnCerrarApp3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(719, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion2
            // 
            btnIniciarSesion2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion2.ForeColor = Color.Black;
            btnIniciarSesion2.Location = new Point(545, 328);
            btnIniciarSesion2.Name = "btnIniciarSesion2";
            btnIniciarSesion2.Size = new Size(191, 49);
            btnIniciarSesion2.TabIndex = 30;
            btnIniciarSesion2.Text = "Iniciar Sesion";
            btnIniciarSesion2.UseVisualStyleBackColor = true;
            btnIniciarSesion2.Click += btnIniciarSesion2_Click_1;
            // 
            // txtContrasenna2
            // 
            txtContrasenna2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenna2.Location = new Point(171, 397);
            txtContrasenna2.Name = "txtContrasenna2";
            txtContrasenna2.Size = new Size(318, 39);
            txtContrasenna2.TabIndex = 29;
            txtContrasenna2.UseSystemPasswordChar = true;
            // 
            // txtCorreo1
            // 
            txtCorreo1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo1.Location = new Point(171, 263);
            txtCorreo1.Name = "txtCorreo1";
            txtCorreo1.Size = new Size(318, 39);
            txtCorreo1.TabIndex = 28;
            // 
            // lblCorreoElec
            // 
            lblCorreoElec.AutoSize = true;
            lblCorreoElec.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoElec.Location = new Point(194, 317);
            lblCorreoElec.Name = "lblCorreoElec";
            lblCorreoElec.Size = new Size(0, 23);
            lblCorreoElec.TabIndex = 27;
            // 
            // lblContrasenna2
            // 
            lblContrasenna2.AutoSize = true;
            lblContrasenna2.BackColor = Color.Black;
            lblContrasenna2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenna2.ForeColor = Color.White;
            lblContrasenna2.Location = new Point(17, 400);
            lblContrasenna2.Name = "lblContrasenna2";
            lblContrasenna2.Size = new Size(157, 32);
            lblContrasenna2.TabIndex = 26;
            lblContrasenna2.Text = "Contraseña: ";
            // 
            // lblUsuario2
            // 
            lblUsuario2.AutoSize = true;
            lblUsuario2.BackColor = Color.Black;
            lblUsuario2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario2.ForeColor = Color.White;
            lblUsuario2.Location = new Point(17, 263);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(116, 32);
            lblUsuario2.TabIndex = 25;
            lblUsuario2.Text = "Usuario: ";
            // 
            // btnOlvidarContrasenna1
            // 
            btnOlvidarContrasenna1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOlvidarContrasenna1.ForeColor = Color.Black;
            btnOlvidarContrasenna1.Location = new Point(224, 447);
            btnOlvidarContrasenna1.Name = "btnOlvidarContrasenna1";
            btnOlvidarContrasenna1.Size = new Size(224, 38);
            btnOlvidarContrasenna1.TabIndex = 24;
            btnOlvidarContrasenna1.Text = "Olvidé mi contraseña";
            btnOlvidarContrasenna1.UseVisualStyleBackColor = true;
            btnOlvidarContrasenna1.Click += btnOlvidarContrasenna1_Click;
            // 
            // frmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(789, 698);
            Controls.Add(lblCorreoElectronico9);
            Controls.Add(btnRegistrarse8);
            Controls.Add(btnRegresar2);
            Controls.Add(btnCerrarApp3);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciarSesion2);
            Controls.Add(txtContrasenna2);
            Controls.Add(txtCorreo1);
            Controls.Add(lblCorreoElec);
            Controls.Add(lblContrasenna2);
            Controls.Add(lblUsuario2);
            Controls.Add(btnOlvidarContrasenna1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmIniciarSesion";
            Text = "frmIniciarSesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreoElectronico9;
        private LinkLabel btnRegistrarse8;
        private Button btnRegresar2;
        private Button btnCerrarApp3;
        private PictureBox pictureBox1;
        private Button btnIniciarSesion2;
        private TextBox txtContrasenna2;
        private TextBox txtCorreo1;
        private Label lblCorreoElec;
        private Label lblContrasenna2;
        private Label lblUsuario2;
        private Button btnOlvidarContrasenna1;
    }
}