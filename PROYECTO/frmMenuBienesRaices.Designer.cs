namespace PROYECTO
{
    partial class frmMenuBienesRaices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuBienesRaices));
            btnRegresar601 = new Button();
            btnSalir601 = new Button();
            btnVerOfertasDisponibles = new Button();
            btnAnnadirOferta = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar601
            // 
            btnRegresar601.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar601.Location = new Point(88, 675);
            btnRegresar601.Margin = new Padding(4, 5, 4, 5);
            btnRegresar601.Name = "btnRegresar601";
            btnRegresar601.Size = new Size(154, 62);
            btnRegresar601.TabIndex = 11;
            btnRegresar601.Text = "Regresar";
            btnRegresar601.UseVisualStyleBackColor = true;
            btnRegresar601.Click += btnRegresar601_Click;
            // 
            // btnSalir601
            // 
            btnSalir601.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir601.Location = new Point(830, 675);
            btnSalir601.Name = "btnSalir601";
            btnSalir601.Size = new Size(154, 62);
            btnSalir601.TabIndex = 10;
            btnSalir601.Text = "Salir";
            btnSalir601.UseVisualStyleBackColor = true;
            btnSalir601.Click += btnSalir601_Click;
            // 
            // btnVerOfertasDisponibles
            // 
            btnVerOfertasDisponibles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerOfertasDisponibles.Location = new Point(340, 465);
            btnVerOfertasDisponibles.Name = "btnVerOfertasDisponibles";
            btnVerOfertasDisponibles.Size = new Size(384, 97);
            btnVerOfertasDisponibles.TabIndex = 9;
            btnVerOfertasDisponibles.Text = "Ver ofertas disponibles";
            btnVerOfertasDisponibles.UseVisualStyleBackColor = true;
            btnVerOfertasDisponibles.Click += btnVerOfertasDisponibles_Click;
            // 
            // btnAnnadirOferta
            // 
            btnAnnadirOferta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnadirOferta.Location = new Point(340, 347);
            btnAnnadirOferta.Name = "btnAnnadirOferta";
            btnAnnadirOferta.Size = new Size(384, 97);
            btnAnnadirOferta.TabIndex = 8;
            btnAnnadirOferta.Text = "Añadir una oferta";
            btnAnnadirOferta.UseVisualStyleBackColor = true;
            btnAnnadirOferta.Click += btnAnnadirOferta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 30);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmMenuBienesRaices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1083, 810);
            Controls.Add(btnRegresar601);
            Controls.Add(btnSalir601);
            Controls.Add(btnVerOfertasDisponibles);
            Controls.Add(btnAnnadirOferta);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuBienesRaices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuBienesRaices";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar601;
        private Button btnSalir601;
        private Button btnVerOfertasDisponibles;
        private Button btnAnnadirOferta;
        private PictureBox pictureBox1;
    }
}