namespace PROYECTO
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            btnSalir = new Button();
            BtnPublicar = new Button();
            label1 = new Label();
            txtDescripProducto = new TextBox();
            numupdwnDispProducto = new NumericUpDown();
            lblDispProducto = new Label();
            lblServicioDomicilio = new Label();
            lblDescripProducto = new Label();
            lblTipoProducto = new Label();
            lblHorarioTrabajo = new Label();
            txtHorarioTrabajo = new TextBox();
            label2 = new Label();
            lblNumTelefono = new Label();
            label3 = new Label();
            cbbTipoProducto = new ComboBox();
            cbServicioDomicilio = new ComboBox();
            btnRegresar37 = new Button();
            txtNombreApellido12 = new TextBox();
            txtNumeroTelefono12 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numupdwnDispProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(1323, 1305);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 75);
            btnSalir.TabIndex = 47;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnPublicar
            // 
            BtnPublicar.BackColor = Color.DarkSlateGray;
            BtnPublicar.BackgroundImageLayout = ImageLayout.None;
            BtnPublicar.FlatAppearance.BorderSize = 0;
            BtnPublicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPublicar.ForeColor = SystemColors.Control;
            BtnPublicar.Location = new Point(676, 1305);
            BtnPublicar.Margin = new Padding(4, 3, 4, 3);
            BtnPublicar.Name = "BtnPublicar";
            BtnPublicar.Size = new Size(169, 75);
            BtnPublicar.TabIndex = 46;
            BtnPublicar.Text = "Publicar";
            BtnPublicar.UseVisualStyleBackColor = false;
            BtnPublicar.Click += BtnPublicar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(524, 247);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 45);
            label1.TabIndex = 45;
            label1.Text = "Sección de Proveedores";
            // 
            // txtDescripProducto
            // 
            txtDescripProducto.Location = new Point(366, 653);
            txtDescripProducto.Margin = new Padding(4, 3, 4, 3);
            txtDescripProducto.Multiline = true;
            txtDescripProducto.Name = "txtDescripProducto";
            txtDescripProducto.Size = new Size(631, 96);
            txtDescripProducto.TabIndex = 43;
            // 
            // numupdwnDispProducto
            // 
            numupdwnDispProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numupdwnDispProducto.Location = new Point(366, 1157);
            numupdwnDispProducto.Margin = new Padding(4, 3, 4, 3);
            numupdwnDispProducto.Name = "numupdwnDispProducto";
            numupdwnDispProducto.Size = new Size(154, 39);
            numupdwnDispProducto.TabIndex = 1;
            // 
            // lblDispProducto
            // 
            lblDispProducto.AutoSize = true;
            lblDispProducto.BackColor = Color.Transparent;
            lblDispProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDispProducto.ForeColor = SystemColors.ButtonFace;
            lblDispProducto.Location = new Point(13, 1159);
            lblDispProducto.Margin = new Padding(4, 0, 4, 0);
            lblDispProducto.Name = "lblDispProducto";
            lblDispProducto.Size = new Size(343, 32);
            lblDispProducto.TabIndex = 0;
            lblDispProducto.Text = "Disponibilidad del producto:";
            // 
            // lblServicioDomicilio
            // 
            lblServicioDomicilio.AutoSize = true;
            lblServicioDomicilio.BackColor = Color.Transparent;
            lblServicioDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicioDomicilio.ForeColor = SystemColors.ButtonFace;
            lblServicioDomicilio.Location = new Point(16, 1030);
            lblServicioDomicilio.Margin = new Padding(4, 0, 4, 0);
            lblServicioDomicilio.Name = "lblServicioDomicilio";
            lblServicioDomicilio.Size = new Size(246, 32);
            lblServicioDomicilio.TabIndex = 39;
            lblServicioDomicilio.Text = "Servicio a domicilio:";
            // 
            // lblDescripProducto
            // 
            lblDescripProducto.AutoSize = true;
            lblDescripProducto.BackColor = Color.Transparent;
            lblDescripProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripProducto.ForeColor = SystemColors.ButtonFace;
            lblDescripProducto.Location = new Point(17, 653);
            lblDescripProducto.Margin = new Padding(4, 0, 4, 0);
            lblDescripProducto.Name = "lblDescripProducto";
            lblDescripProducto.Size = new Size(311, 32);
            lblDescripProducto.TabIndex = 38;
            lblDescripProducto.Text = "Descripcion del producto:";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.BackColor = Color.Transparent;
            lblTipoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoProducto.ForeColor = SystemColors.ButtonFace;
            lblTipoProducto.Location = new Point(17, 538);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(220, 32);
            lblTipoProducto.TabIndex = 37;
            lblTipoProducto.Text = "Tipo de producto:";
            // 
            // lblHorarioTrabajo
            // 
            lblHorarioTrabajo.AutoSize = true;
            lblHorarioTrabajo.BackColor = Color.Transparent;
            lblHorarioTrabajo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarioTrabajo.ForeColor = SystemColors.ButtonFace;
            lblHorarioTrabajo.Location = new Point(19, 825);
            lblHorarioTrabajo.Margin = new Padding(4, 0, 4, 0);
            lblHorarioTrabajo.Name = "lblHorarioTrabajo";
            lblHorarioTrabajo.Size = new Size(233, 32);
            lblHorarioTrabajo.TabIndex = 0;
            lblHorarioTrabajo.Text = "Horario de trabajo:";
            // 
            // txtHorarioTrabajo
            // 
            txtHorarioTrabajo.Location = new Point(366, 825);
            txtHorarioTrabajo.Margin = new Padding(4, 3, 4, 3);
            txtHorarioTrabajo.Multiline = true;
            txtHorarioTrabajo.Name = "txtHorarioTrabajo";
            txtHorarioTrabajo.Size = new Size(631, 96);
            txtHorarioTrabajo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 895);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(256, 25);
            label2.TabIndex = 2;
            label2.Text = "(ej:Lun-Vi--8:00 a.m.-1:00 p.m.)";
            // 
            // lblNumTelefono
            // 
            lblNumTelefono.AutoSize = true;
            lblNumTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumTelefono.ForeColor = Color.White;
            lblNumTelefono.Location = new Point(17, 441);
            lblNumTelefono.Margin = new Padding(4, 0, 4, 0);
            lblNumTelefono.Name = "lblNumTelefono";
            lblNumTelefono.Size = new Size(256, 32);
            lblNumTelefono.TabIndex = 48;
            lblNumTelefono.Text = "Numero de Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 352);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 32);
            label3.TabIndex = 49;
            label3.Text = "Nombre y Apellido: ";
            // 
            // cbbTipoProducto
            // 
            cbbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTipoProducto.FormattingEnabled = true;
            cbbTipoProducto.Items.AddRange(new object[] { "Alimentos", "Productos Varios", "Servicios Profesionales", "  " });
            cbbTipoProducto.Location = new Point(366, 535);
            cbbTipoProducto.Margin = new Padding(4, 5, 4, 5);
            cbbTipoProducto.Name = "cbbTipoProducto";
            cbbTipoProducto.Size = new Size(450, 40);
            cbbTipoProducto.TabIndex = 50;
            // 
            // cbServicioDomicilio
            // 
            cbServicioDomicilio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServicioDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbServicioDomicilio.FormattingEnabled = true;
            cbServicioDomicilio.Items.AddRange(new object[] { "Si", "No" });
            cbServicioDomicilio.Location = new Point(366, 1027);
            cbServicioDomicilio.Margin = new Padding(4, 5, 4, 5);
            cbServicioDomicilio.Name = "cbServicioDomicilio";
            cbServicioDomicilio.Size = new Size(153, 40);
            cbServicioDomicilio.TabIndex = 51;
            // 
            // btnRegresar37
            // 
            btnRegresar37.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar37.Location = new Point(13, 1307);
            btnRegresar37.Margin = new Padding(4, 5, 4, 5);
            btnRegresar37.Name = "btnRegresar37";
            btnRegresar37.Size = new Size(150, 75);
            btnRegresar37.TabIndex = 52;
            btnRegresar37.Text = "Regresar";
            btnRegresar37.UseVisualStyleBackColor = true;
            btnRegresar37.Click += btnRegresar37_Click;
            // 
            // txtNombreApellido12
            // 
            txtNombreApellido12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreApellido12.Location = new Point(366, 355);
            txtNombreApellido12.Margin = new Padding(4, 5, 4, 5);
            txtNombreApellido12.Name = "txtNombreApellido12";
            txtNombreApellido12.Size = new Size(450, 39);
            txtNombreApellido12.TabIndex = 53;
            // 
            // txtNumeroTelefono12
            // 
            txtNumeroTelefono12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroTelefono12.Location = new Point(366, 438);
            txtNumeroTelefono12.Margin = new Padding(4, 5, 4, 5);
            txtNumeroTelefono12.Name = "txtNumeroTelefono12";
            txtNumeroTelefono12.Size = new Size(450, 39);
            txtNumeroTelefono12.TabIndex = 54;
            txtNumeroTelefono12.KeyPress += txtNumeroTelefono12_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1493, 1392);
            Controls.Add(pictureBox1);
            Controls.Add(txtNumeroTelefono12);
            Controls.Add(txtNombreApellido12);
            Controls.Add(btnRegresar37);
            Controls.Add(cbServicioDomicilio);
            Controls.Add(cbbTipoProducto);
            Controls.Add(label3);
            Controls.Add(lblNumTelefono);
            Controls.Add(lblHorarioTrabajo);
            Controls.Add(label2);
            Controls.Add(numupdwnDispProducto);
            Controls.Add(txtHorarioTrabajo);
            Controls.Add(btnSalir);
            Controls.Add(lblDispProducto);
            Controls.Add(BtnPublicar);
            Controls.Add(label1);
            Controls.Add(txtDescripProducto);
            Controls.Add(lblServicioDomicilio);
            Controls.Add(lblDescripProducto);
            Controls.Add(lblTipoProducto);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmProveedores";
            Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)numupdwnDispProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button BtnPublicar;
        private Label label1;
        private TextBox txtDescripProducto;
        private NumericUpDown numupdwnDispProducto;
        private Label lblDispProducto;
        private Label lblServicioDomicilio;
        private Label lblDescripProducto;
        private Label lblTipoProducto;
        private Label lblHorarioTrabajo;
        private TextBox txtHorarioTrabajo;
        private Label label2;
        private Label lblNumTelefono;
        private Label label3;
        private ComboBox cbbTipoProducto;
        private ComboBox cbServicioDomicilio;
        private Button btnRegresar37;
        private TextBox txtNombreApellido12;
        private TextBox txtNumeroTelefono12;
        private PictureBox pictureBox1;
    }
}