namespace PROYECTO
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblBienvenido = new Label();
            lblInformacionInvitado = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarApp1 = new Button();
            btnRegistrarse1 = new Button();
            btnIniciarSesion1 = new Button();
            lklblAgregaEmpleo = new LinkLabel();
            lklblServProducto = new LinkLabel();
            lblServ = new Label();
            lblServicio = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Location = new Point(360, 226);
            lblBienvenido.Margin = new Padding(4, 0, 4, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(502, 48);
            lblBienvenido.TabIndex = 21;
            lblBienvenido.Text = "¡BIENVENIDO A PARADOXA!";
            // 
            // lblInformacionInvitado
            // 
            lblInformacionInvitado.AutoSize = true;
            lblInformacionInvitado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacionInvitado.ForeColor = Color.White;
            lblInformacionInvitado.Location = new Point(156, 623);
            lblInformacionInvitado.Margin = new Padding(4, 0, 4, 0);
            lblInformacionInvitado.Name = "lblInformacionInvitado";
            lblInformacionInvitado.Size = new Size(975, 40);
            lblInformacionInvitado.TabIndex = 20;
            lblInformacionInvitado.Text = "¡Encuentra potencial para tu empresa agregando un empleo sin registrarse!";
            lblInformacionInvitado.Click += lblInformacionInvitado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarApp1
            // 
            btnCerrarApp1.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarApp1.FlatStyle = FlatStyle.Flat;
            btnCerrarApp1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarApp1.Location = new Point(1070, 945);
            btnCerrarApp1.Name = "btnCerrarApp1";
            btnCerrarApp1.Size = new Size(174, 62);
            btnCerrarApp1.TabIndex = 17;
            btnCerrarApp1.Text = "Salir";
            btnCerrarApp1.UseVisualStyleBackColor = false;
            btnCerrarApp1.Click += btnCerrarApp1_Click_1;
            // 
            // btnRegistrarse1
            // 
            btnRegistrarse1.BackColor = Color.White;
            btnRegistrarse1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse1.Location = new Point(785, 372);
            btnRegistrarse1.Name = "btnRegistrarse1";
            btnRegistrarse1.Size = new Size(200, 117);
            btnRegistrarse1.TabIndex = 16;
            btnRegistrarse1.Text = "Registrarse";
            btnRegistrarse1.UseVisualStyleBackColor = false;
            btnRegistrarse1.Click += btnRegistrarse1_Click_1;
            // 
            // btnIniciarSesion1
            // 
            btnIniciarSesion1.BackColor = Color.White;
            btnIniciarSesion1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion1.Location = new Point(301, 372);
            btnIniciarSesion1.Name = "btnIniciarSesion1";
            btnIniciarSesion1.Size = new Size(200, 117);
            btnIniciarSesion1.TabIndex = 15;
            btnIniciarSesion1.Text = "Iniciar sesión";
            btnIniciarSesion1.UseVisualStyleBackColor = false;
            btnIniciarSesion1.Click += btnIniciarSesion1_Click_1;
            // 
            // lklblAgregaEmpleo
            // 
            lklblAgregaEmpleo.AutoSize = true;
            lklblAgregaEmpleo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklblAgregaEmpleo.LinkColor = Color.Yellow;
            lklblAgregaEmpleo.Location = new Point(499, 688);
            lklblAgregaEmpleo.Margin = new Padding(4, 0, 4, 0);
            lklblAgregaEmpleo.Name = "lklblAgregaEmpleo";
            lklblAgregaEmpleo.Size = new Size(254, 40);
            lklblAgregaEmpleo.TabIndex = 22;
            lklblAgregaEmpleo.TabStop = true;
            lklblAgregaEmpleo.Text = "Agrega un Empleo";
            lklblAgregaEmpleo.LinkClicked += lklblAgregaEmpleo_LinkClicked;
            // 
            // lklblServProducto
            // 
            lklblServProducto.AutoSize = true;
            lklblServProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklblServProducto.LinkColor = Color.Yellow;
            lklblServProducto.Location = new Point(404, 897);
            lklblServProducto.Margin = new Padding(4, 0, 4, 0);
            lklblServProducto.Name = "lklblServProducto";
            lklblServProducto.Size = new Size(445, 40);
            lklblServProducto.TabIndex = 23;
            lklblServProducto.TabStop = true;
            lklblServProducto.Text = "Agrega un Servicio o un Producto";
            lklblServProducto.LinkClicked += lklblServProducto_LinkClicked;
            // 
            // lblServ
            // 
            lblServ.AutoSize = true;
            lblServ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblServ.ForeColor = Color.White;
            lblServ.Location = new Point(543, 818);
            lblServ.Margin = new Padding(4, 0, 4, 0);
            lblServ.Name = "lblServ";
            lblServ.Size = new Size(0, 40);
            lblServ.TabIndex = 24;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicio.ForeColor = Color.White;
            lblServicio.Location = new Point(156, 818);
            lblServicio.Margin = new Padding(4, 0, 4, 0);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(943, 40);
            lblServicio.TabIndex = 25;
            lblServicio.Text = "¡U ofrece tus productos o servicios para hacer crecer tu emprendimiento!";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1260, 1025);
            Controls.Add(lblServicio);
            Controls.Add(lblServ);
            Controls.Add(lklblServProducto);
            Controls.Add(lklblAgregaEmpleo);
            Controls.Add(lblBienvenido);
            Controls.Add(lblInformacionInvitado);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarApp1);
            Controls.Add(btnRegistrarse1);
            Controls.Add(btnIniciarSesion1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicio";
            Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblInformacionInvitado;
        private PictureBox pictureBox1;
        private Button btnCerrarApp1;
        private Button btnRegistrarse1;
        private Button btnIniciarSesion1;
        private LinkLabel lklblAgregaEmpleo;
        private LinkLabel lklblServProducto;
        private Label lblServ;
        private Label lblServicio;
    }
}