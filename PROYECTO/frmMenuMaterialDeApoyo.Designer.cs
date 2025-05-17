namespace PROYECTO
{
    partial class frmMenuMaterialDeApoyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuMaterialDeApoyo));
            btnRegresar602 = new Button();
            btnSalir602 = new Button();
            btnVerMaterial = new Button();
            btnSubirMaterial = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar602
            // 
            btnRegresar602.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar602.Location = new Point(31, 674);
            btnRegresar602.Margin = new Padding(4, 5, 4, 5);
            btnRegresar602.Name = "btnRegresar602";
            btnRegresar602.Size = new Size(154, 62);
            btnRegresar602.TabIndex = 11;
            btnRegresar602.Text = "Regresar";
            btnRegresar602.UseVisualStyleBackColor = true;
            btnRegresar602.Click += btnRegresar602_Click;
            // 
            // btnSalir602
            // 
            btnSalir602.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir602.Location = new Point(773, 674);
            btnSalir602.Name = "btnSalir602";
            btnSalir602.Size = new Size(154, 62);
            btnSalir602.TabIndex = 10;
            btnSalir602.Text = "Salir";
            btnSalir602.UseVisualStyleBackColor = true;
            btnSalir602.Click += btnSalir602_Click;
            // 
            // btnVerMaterial
            // 
            btnVerMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerMaterial.Location = new Point(283, 464);
            btnVerMaterial.Name = "btnVerMaterial";
            btnVerMaterial.Size = new Size(384, 97);
            btnVerMaterial.TabIndex = 9;
            btnVerMaterial.Text = "Ver Material Disponible";
            btnVerMaterial.UseVisualStyleBackColor = true;
            btnVerMaterial.Click += btnVerMaterial_Click;
            // 
            // btnSubirMaterial
            // 
            btnSubirMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubirMaterial.Location = new Point(283, 346);
            btnSubirMaterial.Name = "btnSubirMaterial";
            btnSubirMaterial.Size = new Size(384, 97);
            btnSubirMaterial.TabIndex = 8;
            btnSubirMaterial.Text = "Subir Material Didáctico";
            btnSubirMaterial.UseVisualStyleBackColor = true;
            btnSubirMaterial.Click += btnSubirMaterial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 29);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmMenuMaterialDeApoyo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(959, 769);
            Controls.Add(btnRegresar602);
            Controls.Add(btnSalir602);
            Controls.Add(btnVerMaterial);
            Controls.Add(btnSubirMaterial);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuMaterialDeApoyo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuMaterialDeApoyo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar602;
        private Button btnSalir602;
        private Button btnVerMaterial;
        private Button btnSubirMaterial;
        private PictureBox pictureBox1;
    }
}