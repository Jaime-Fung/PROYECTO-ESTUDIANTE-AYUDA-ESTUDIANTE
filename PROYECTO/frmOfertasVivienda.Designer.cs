namespace PROYECTO
{
    partial class frmOfertasVivienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfertasVivienda));
            dgvOfertasVivienda = new DataGridView();
            btnVerOfertas = new Button();
            btnRegresar900 = new Button();
            btnVerFotos = new Button();
            btnSalir800 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOfertasVivienda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvOfertasVivienda
            // 
            dgvOfertasVivienda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOfertasVivienda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOfertasVivienda.Location = new Point(16, 227);
            dgvOfertasVivienda.Name = "dgvOfertasVivienda";
            dgvOfertasVivienda.RowHeadersWidth = 62;
            dgvOfertasVivienda.RowTemplate.Height = 33;
            dgvOfertasVivienda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOfertasVivienda.Size = new Size(1331, 623);
            dgvOfertasVivienda.TabIndex = 5;
            // 
            // btnVerOfertas
            // 
            btnVerOfertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerOfertas.Location = new Point(475, 857);
            btnVerOfertas.Name = "btnVerOfertas";
            btnVerOfertas.Size = new Size(163, 76);
            btnVerOfertas.TabIndex = 4;
            btnVerOfertas.Text = "Ver ofertas";
            btnVerOfertas.UseVisualStyleBackColor = true;
            btnVerOfertas.Click += btnVerOfertas_Click;
            // 
            // btnRegresar900
            // 
            btnRegresar900.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar900.Location = new Point(16, 983);
            btnRegresar900.Name = "btnRegresar900";
            btnRegresar900.Size = new Size(154, 62);
            btnRegresar900.TabIndex = 3;
            btnRegresar900.Text = "Regresar";
            btnRegresar900.UseVisualStyleBackColor = true;
            btnRegresar900.Click += btnRegresar_Click;
            // 
            // btnVerFotos
            // 
            btnVerFotos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerFotos.Location = new Point(716, 857);
            btnVerFotos.Name = "btnVerFotos";
            btnVerFotos.Size = new Size(153, 77);
            btnVerFotos.TabIndex = 8;
            btnVerFotos.Text = "Ver fotos";
            btnVerFotos.UseVisualStyleBackColor = true;
            btnVerFotos.Click += btnVerFotos_Click;
            // 
            // btnSalir800
            // 
            btnSalir800.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir800.FlatStyle = FlatStyle.Flat;
            btnSalir800.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir800.ForeColor = Color.White;
            btnSalir800.Location = new Point(1191, 983);
            btnSalir800.Margin = new Padding(4, 5, 4, 5);
            btnSalir800.Name = "btnSalir800";
            btnSalir800.Size = new Size(154, 62);
            btnSalir800.TabIndex = 9;
            btnSalir800.Text = "Salir";
            btnSalir800.UseVisualStyleBackColor = false;
            btnSalir800.Click += btnSalir800_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // frmOfertasVivienda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1363, 1063);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir800);
            Controls.Add(btnVerFotos);
            Controls.Add(dgvOfertasVivienda);
            Controls.Add(btnVerOfertas);
            Controls.Add(btnRegresar900);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmOfertasVivienda";
            Text = "frmOfertasVivienda";
            ((System.ComponentModel.ISupportInitialize)dgvOfertasVivienda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOfertasVivienda;
        private Button btnVerOfertas;
        private Button btnRegresar900;
        private Button btnVerFotos;
        private Button btnSalir800;
        private PictureBox pictureBox1;
    }
}