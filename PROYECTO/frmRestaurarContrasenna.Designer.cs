namespace PROYECTO
{
    partial class frmRestaurarContrasenna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestaurarContrasenna));
            btnConfirmarContrasenna = new Button();
            btnRegresar3 = new Button();
            btnCerrarApp2 = new Button();
            pictureBox1 = new PictureBox();
            txtConfirmarContrasenna = new TextBox();
            txtNuevaContrasenna = new TextBox();
            lblConfContrasenna = new Label();
            lblNuevaContrasenna = new Label();
            btnOlvidarContra2 = new Button();
            lblCambieSuContra = new Label();
            txtContraActual = new TextBox();
            lblContraActual = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarContrasenna
            // 
            btnConfirmarContrasenna.BackColor = Color.Lime;
            btnConfirmarContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarContrasenna.Location = new Point(747, 848);
            btnConfirmarContrasenna.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarContrasenna.Name = "btnConfirmarContrasenna";
            btnConfirmarContrasenna.Size = new Size(186, 62);
            btnConfirmarContrasenna.TabIndex = 22;
            btnConfirmarContrasenna.Text = "Confirmar";
            btnConfirmarContrasenna.UseVisualStyleBackColor = false;
            btnConfirmarContrasenna.Click += btnConfirmarContrasenna_Click;
            // 
            // btnRegresar3
            // 
            btnRegresar3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar3.Location = new Point(13, 1042);
            btnRegresar3.Margin = new Padding(4, 5, 4, 5);
            btnRegresar3.Name = "btnRegresar3";
            btnRegresar3.Size = new Size(154, 62);
            btnRegresar3.TabIndex = 21;
            btnRegresar3.Text = "Regresar";
            btnRegresar3.UseVisualStyleBackColor = true;
            btnRegresar3.Click += btnRegresar3_Click;
            // 
            // btnCerrarApp2
            // 
            btnCerrarApp2.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrarApp2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarApp2.Location = new Point(880, 1042);
            btnCerrarApp2.Margin = new Padding(4, 5, 4, 5);
            btnCerrarApp2.Name = "btnCerrarApp2";
            btnCerrarApp2.Size = new Size(174, 62);
            btnCerrarApp2.TabIndex = 20;
            btnCerrarApp2.Text = "Salir";
            btnCerrarApp2.UseVisualStyleBackColor = false;
            btnCerrarApp2.Click += btnCerrarApp2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarContrasenna
            // 
            txtConfirmarContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarContrasenna.Location = new Point(308, 738);
            txtConfirmarContrasenna.Margin = new Padding(4, 5, 4, 5);
            txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            txtConfirmarContrasenna.Size = new Size(381, 39);
            txtConfirmarContrasenna.TabIndex = 18;
            txtConfirmarContrasenna.UseSystemPasswordChar = true;
            // 
            // txtNuevaContrasenna
            // 
            txtNuevaContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuevaContrasenna.Location = new Point(308, 594);
            txtNuevaContrasenna.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContrasenna.Name = "txtNuevaContrasenna";
            txtNuevaContrasenna.Size = new Size(381, 39);
            txtNuevaContrasenna.TabIndex = 17;
            txtNuevaContrasenna.UseSystemPasswordChar = true;
            // 
            // lblConfContrasenna
            // 
            lblConfContrasenna.AutoSize = true;
            lblConfContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfContrasenna.ForeColor = Color.White;
            lblConfContrasenna.Location = new Point(17, 738);
            lblConfContrasenna.Margin = new Padding(4, 0, 4, 0);
            lblConfContrasenna.Name = "lblConfContrasenna";
            lblConfContrasenna.Size = new Size(280, 32);
            lblConfContrasenna.TabIndex = 16;
            lblConfContrasenna.Text = "Confirmar Contraseña: ";
            // 
            // lblNuevaContrasenna
            // 
            lblNuevaContrasenna.AutoSize = true;
            lblNuevaContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaContrasenna.ForeColor = Color.White;
            lblNuevaContrasenna.Location = new Point(17, 594);
            lblNuevaContrasenna.Margin = new Padding(4, 0, 4, 0);
            lblNuevaContrasenna.Name = "lblNuevaContrasenna";
            lblNuevaContrasenna.Size = new Size(237, 32);
            lblNuevaContrasenna.TabIndex = 15;
            lblNuevaContrasenna.Text = "Nueva Contraseña: ";
            // 
            // btnOlvidarContra2
            // 
            btnOlvidarContra2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOlvidarContra2.Location = new Point(357, 483);
            btnOlvidarContra2.Margin = new Padding(4, 5, 4, 5);
            btnOlvidarContra2.Name = "btnOlvidarContra2";
            btnOlvidarContra2.Size = new Size(295, 38);
            btnOlvidarContra2.TabIndex = 29;
            btnOlvidarContra2.Text = "Olvide mi contraseña";
            btnOlvidarContra2.UseVisualStyleBackColor = true;
            btnOlvidarContra2.Click += btnOlvidarContra2_Click;
            // 
            // lblCambieSuContra
            // 
            lblCambieSuContra.AutoSize = true;
            lblCambieSuContra.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCambieSuContra.ForeColor = Color.White;
            lblCambieSuContra.Location = new Point(246, 232);
            lblCambieSuContra.Margin = new Padding(4, 0, 4, 0);
            lblCambieSuContra.Name = "lblCambieSuContra";
            lblCambieSuContra.Size = new Size(538, 65);
            lblCambieSuContra.TabIndex = 31;
            lblCambieSuContra.Text = "Cambie su Contraseña";
            // 
            // txtContraActual
            // 
            txtContraActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraActual.Location = new Point(308, 419);
            txtContraActual.Margin = new Padding(4, 5, 4, 5);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(381, 39);
            txtContraActual.TabIndex = 30;
            // 
            // lblContraActual
            // 
            lblContraActual.AutoSize = true;
            lblContraActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraActual.ForeColor = Color.White;
            lblContraActual.Location = new Point(17, 419);
            lblContraActual.Margin = new Padding(4, 0, 4, 0);
            lblContraActual.Name = "lblContraActual";
            lblContraActual.Size = new Size(230, 32);
            lblContraActual.TabIndex = 24;
            lblContraActual.Text = "Contraseña Actual:";
            // 
            // frmRestaurarContrasenna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1067, 1118);
            Controls.Add(lblCambieSuContra);
            Controls.Add(txtContraActual);
            Controls.Add(btnOlvidarContra2);
            Controls.Add(lblContraActual);
            Controls.Add(btnConfirmarContrasenna);
            Controls.Add(btnRegresar3);
            Controls.Add(btnCerrarApp2);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmarContrasenna);
            Controls.Add(txtNuevaContrasenna);
            Controls.Add(lblConfContrasenna);
            Controls.Add(lblNuevaContrasenna);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRestaurarContrasenna";
            Text = "frmRestaurarContrasenna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfirmarContrasenna;
        private Button btnRegresar3;
        private Button btnCerrarApp2;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarContrasenna;
        private TextBox txtNuevaContrasenna;
        private Label lblConfContrasenna;
        private Label lblNuevaContrasenna;
        private Button btnOlvidarContra2;
        private Label lblCambieSuContra;
        private TextBox txtContraActual;
        private Label lblContraActual;
    }
}