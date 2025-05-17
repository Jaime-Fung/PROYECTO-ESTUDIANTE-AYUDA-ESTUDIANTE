namespace PROYECTO
{
    partial class frmServiciosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiciosProductos));
            btnSalir = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvServiciosyProductos = new DataGridView();
            btnRegresar90 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosyProductos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(1387, 1055);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(154, 62);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(579, 230);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 48);
            label1.TabIndex = 0;
            label1.Text = "Servicios Y Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvServiciosyProductos
            // 
            dgvServiciosyProductos.AllowUserToAddRows = false;
            dgvServiciosyProductos.AllowUserToDeleteRows = false;
            dgvServiciosyProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiciosyProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosyProductos.Location = new Point(17, 330);
            dgvServiciosyProductos.Margin = new Padding(4, 5, 4, 5);
            dgvServiciosyProductos.Name = "dgvServiciosyProductos";
            dgvServiciosyProductos.ReadOnly = true;
            dgvServiciosyProductos.RowHeadersWidth = 62;
            dgvServiciosyProductos.RowTemplate.Height = 25;
            dgvServiciosyProductos.Size = new Size(1524, 702);
            dgvServiciosyProductos.TabIndex = 3;
            // 
            // btnRegresar90
            // 
            btnRegresar90.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar90.Location = new Point(17, 1068);
            btnRegresar90.Margin = new Padding(5);
            btnRegresar90.Name = "btnRegresar90";
            btnRegresar90.Size = new Size(141, 53);
            btnRegresar90.TabIndex = 164;
            btnRegresar90.Text = "Regresar";
            btnRegresar90.UseVisualStyleBackColor = true;
            btnRegresar90.Click += btnRegresar90_Click;
            // 
            // frmServiciosProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1559, 1135);
            Controls.Add(btnRegresar90);
            Controls.Add(dgvServiciosyProductos);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmServiciosProductos";
            Text = "Servicios Productos";
            Load += ServiciosProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosyProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private DataGridView dgvServiciosyProductos;
        private Button btnRegresar90;
    }
}