namespace PROYECTO
{
    partial class frmBuscarMaterialApoyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarMaterialApoyo));
            btnDescargar = new Button();
            btnBuscar = new Button();
            btnCerrar950 = new Button();
            dgvBuscarPdf = new DataGridView();
            label1 = new Label();
            cbbCategoria = new ComboBox();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarPdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDescargar
            // 
            btnDescargar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDescargar.Location = new Point(947, 260);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(143, 53);
            btnDescargar.TabIndex = 14;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(740, 260);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 48);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCerrar950
            // 
            btnCerrar950.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar950.FlatStyle = FlatStyle.Flat;
            btnCerrar950.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar950.ForeColor = Color.White;
            btnCerrar950.Location = new Point(1229, 947);
            btnCerrar950.Name = "btnCerrar950";
            btnCerrar950.Size = new Size(154, 62);
            btnCerrar950.TabIndex = 12;
            btnCerrar950.Text = "Salir";
            btnCerrar950.UseVisualStyleBackColor = false;
            btnCerrar950.Click += btnCerrar950_Click;
            // 
            // dgvBuscarPdf
            // 
            dgvBuscarPdf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarPdf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarPdf.Location = new Point(16, 337);
            dgvBuscarPdf.Name = "dgvBuscarPdf";
            dgvBuscarPdf.RowHeadersWidth = 62;
            dgvBuscarPdf.RowTemplate.Height = 33;
            dgvBuscarPdf.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarPdf.Size = new Size(1367, 565);
            dgvBuscarPdf.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 260);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 10;
            label1.Text = "Categoría";
            // 
            // cbbCategoria
            // 
            cbbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Items.AddRange(new object[] { "Física", "Tecnologías de la Información", "Ciencias Sociales" });
            cbbCategoria.Location = new Point(213, 260);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(368, 33);
            cbbCategoria.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(244, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(16, 945);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 62);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Regresar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmBuscarMaterialApoyo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1399, 1027);
            Controls.Add(btnCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(btnDescargar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCerrar950);
            Controls.Add(dgvBuscarPdf);
            Controls.Add(label1);
            Controls.Add(cbbCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBuscarMaterialApoyo";
            Text = "frmBuscarMaterialApoyo";
            ((System.ComponentModel.ISupportInitialize)dgvBuscarPdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDescargar;
        private Button btnBuscar;
        private Button btnCerrar950;
        private DataGridView dgvBuscarPdf;
        private Label label1;
        private ComboBox cbbCategoria;
        private PictureBox pictureBox1;
        private Button btnCancelar;
    }
}