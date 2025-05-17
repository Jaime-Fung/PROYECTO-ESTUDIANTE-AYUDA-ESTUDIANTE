namespace PROYECTO
{
    partial class frmAgenteBienesRaices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenteBienesRaices));
            btnActualizarListado = new Button();
            btnRegresar32 = new Button();
            btnEliminarOferta = new Button();
            btnAgregarOferta = new Button();
            lblCorreo = new Label();
            label14 = new Label();
            dgvAgenteBR = new DataGridView();
            pictureBox1 = new PictureBox();
            btnSalirABR = new Button();
            btnVerFotos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgenteBR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnActualizarListado
            // 
            btnActualizarListado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarListado.Location = new Point(598, 968);
            btnActualizarListado.Name = "btnActualizarListado";
            btnActualizarListado.Size = new Size(311, 77);
            btnActualizarListado.TabIndex = 10;
            btnActualizarListado.Text = "Actualizar listado";
            btnActualizarListado.UseVisualStyleBackColor = true;
            btnActualizarListado.Click += btnActualizarListado_Click;
            // 
            // btnRegresar32
            // 
            btnRegresar32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar32.Location = new Point(79, 968);
            btnRegresar32.Name = "btnRegresar32";
            btnRegresar32.Size = new Size(154, 77);
            btnRegresar32.TabIndex = 9;
            btnRegresar32.Text = "Regresar";
            btnRegresar32.UseVisualStyleBackColor = true;
            btnRegresar32.Click += btnRegresar_Click;
            // 
            // btnEliminarOferta
            // 
            btnEliminarOferta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarOferta.Location = new Point(307, 1016);
            btnEliminarOferta.Name = "btnEliminarOferta";
            btnEliminarOferta.Size = new Size(214, 50);
            btnEliminarOferta.TabIndex = 8;
            btnEliminarOferta.Text = "Eliminar oferta";
            btnEliminarOferta.UseVisualStyleBackColor = true;
            btnEliminarOferta.Click += btnEliminarOferta_Click;
            // 
            // btnAgregarOferta
            // 
            btnAgregarOferta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarOferta.Location = new Point(307, 941);
            btnAgregarOferta.Name = "btnAgregarOferta";
            btnAgregarOferta.Size = new Size(214, 50);
            btnAgregarOferta.TabIndex = 7;
            btnAgregarOferta.Text = "Agregar oferta";
            btnAgregarOferta.UseVisualStyleBackColor = true;
            btnAgregarOferta.Click += btnAgregarOferta_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(252, 193);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 32);
            lblCorreo.TabIndex = 31;
            lblCorreo.Text = "lblCorreo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(12, 193);
            label14.Name = "label14";
            label14.Size = new Size(234, 32);
            label14.TabIndex = 30;
            label14.Text = "Correo electrónico:";
            // 
            // dgvAgenteBR
            // 
            dgvAgenteBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenteBR.Location = new Point(40, 237);
            dgvAgenteBR.Name = "dgvAgenteBR";
            dgvAgenteBR.RowHeadersWidth = 62;
            dgvAgenteBR.RowTemplate.Height = 33;
            dgvAgenteBR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgenteBR.Size = new Size(1529, 670);
            dgvAgenteBR.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnSalirABR
            // 
            btnSalirABR.BackColor = Color.FromArgb(192, 0, 0);
            btnSalirABR.FlatStyle = FlatStyle.Flat;
            btnSalirABR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirABR.ForeColor = Color.White;
            btnSalirABR.Location = new Point(1439, 1035);
            btnSalirABR.Margin = new Padding(4, 5, 4, 5);
            btnSalirABR.Name = "btnSalirABR";
            btnSalirABR.Size = new Size(154, 62);
            btnSalirABR.TabIndex = 33;
            btnSalirABR.Text = "Salir";
            btnSalirABR.UseVisualStyleBackColor = false;
            btnSalirABR.Click += btnSalirABR_Click;
            // 
            // btnVerFotos
            // 
            btnVerFotos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerFotos.Location = new Point(951, 968);
            btnVerFotos.Name = "btnVerFotos";
            btnVerFotos.Size = new Size(123, 73);
            btnVerFotos.TabIndex = 34;
            btnVerFotos.Text = "Ver fotos";
            btnVerFotos.UseVisualStyleBackColor = true;
            btnVerFotos.Click += btnVerFotos_Click;
            // 
            // frmAgenteBienesRaices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1610, 1115);
            Controls.Add(btnVerFotos);
            Controls.Add(btnSalirABR);
            Controls.Add(pictureBox1);
            Controls.Add(lblCorreo);
            Controls.Add(label14);
            Controls.Add(btnActualizarListado);
            Controls.Add(dgvAgenteBR);
            Controls.Add(btnRegresar32);
            Controls.Add(btnEliminarOferta);
            Controls.Add(btnAgregarOferta);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAgenteBienesRaices";
            Text = "frmAgenteBienesRaices";
            ((System.ComponentModel.ISupportInitialize)dgvAgenteBR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnActualizarListado;
        private Button btnRegresar32;
        private Button btnEliminarOferta;
        private Button btnAgregarOferta;
        private Label lblCorreo;
        private Label label14;
        private DataGridView dgvAgenteBR;
        private PictureBox pictureBox1;
        private Button btnSalirABR;
        private Button btnVerFotos;
    }
}