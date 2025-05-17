namespace PROYECTO
{
    partial class frmSubirMaterialApoyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubirMaterialApoyo));
            btnCancelar = new Button();
            btnGuardarArchivo = new Button();
            btnSubirArchivo = new Button();
            txtAutor = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbbTipoDeDocumento = new ComboBox();
            cbbCategoria = new ComboBox();
            pictureBox1 = new PictureBox();
            btnSalir269 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(16, 717);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 62);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Regresar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarArchivo.Location = new Point(743, 522);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(171, 83);
            btnGuardarArchivo.TabIndex = 20;
            btnGuardarArchivo.Text = "Guardar archivo";
            btnGuardarArchivo.UseVisualStyleBackColor = true;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnSubirArchivo
            // 
            btnSubirArchivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubirArchivo.Location = new Point(566, 522);
            btnSubirArchivo.Name = "btnSubirArchivo";
            btnSubirArchivo.Size = new Size(171, 83);
            btnSubirArchivo.TabIndex = 19;
            btnSubirArchivo.Text = "Subir archivo pdf";
            btnSubirArchivo.UseVisualStyleBackColor = true;
            btnSubirArchivo.Click += btnSubirArchivo_Click;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(323, 443);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(628, 39);
            txtAutor.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(323, 624);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(628, 39);
            txtNombre.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 443);
            label4.Name = "label4";
            label4.Size = new Size(305, 32);
            label4.TabIndex = 16;
            label4.Text = "Primer Autor en mención";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 624);
            label3.Name = "label3";
            label3.Size = new Size(288, 32);
            label3.TabIndex = 15;
            label3.Text = "Nombre del documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 350);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 14;
            label2.Text = "Tipo de documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 263);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 13;
            label1.Text = "Categoría";
            // 
            // cbbTipoDeDocumento
            // 
            cbbTipoDeDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoDeDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTipoDeDocumento.FormattingEnabled = true;
            cbbTipoDeDocumento.Items.AddRange(new object[] { "Libro", "Ensayo", "Tesis", "Artículo" });
            cbbTipoDeDocumento.Location = new Point(323, 350);
            cbbTipoDeDocumento.Name = "cbbTipoDeDocumento";
            cbbTipoDeDocumento.Size = new Size(368, 40);
            cbbTipoDeDocumento.TabIndex = 12;
            // 
            // cbbCategoria
            // 
            cbbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Items.AddRange(new object[] { "Física", "Tecnologías de la Información", "Ciencias Sociales" });
            cbbCategoria.Location = new Point(323, 263);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(368, 40);
            cbbCategoria.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 15);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSalir269
            // 
            btnSalir269.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir269.FlatStyle = FlatStyle.Flat;
            btnSalir269.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir269.ForeColor = Color.White;
            btnSalir269.Location = new Point(1034, 715);
            btnSalir269.Margin = new Padding(4, 5, 4, 5);
            btnSalir269.Name = "btnSalir269";
            btnSalir269.Size = new Size(154, 62);
            btnSalir269.TabIndex = 23;
            btnSalir269.Text = "Salir";
            btnSalir269.UseVisualStyleBackColor = false;
            btnSalir269.Click += btnSalir269_Click;
            // 
            // frmSubirMaterialApoyo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1206, 797);
            Controls.Add(btnSalir269);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarArchivo);
            Controls.Add(btnSubirArchivo);
            Controls.Add(txtAutor);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbTipoDeDocumento);
            Controls.Add(cbbCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSubirMaterialApoyo";
            Text = "frmSubirMaterialApoyo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarArchivo;
        private Button btnSubirArchivo;
        private TextBox txtAutor;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbbTipoDeDocumento;
        private ComboBox cbbCategoria;
        private PictureBox pictureBox1;
        private Button btnSalir269;
    }
}