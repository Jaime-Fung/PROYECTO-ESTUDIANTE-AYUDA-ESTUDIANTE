namespace PROYECTO
{
    partial class frmOlvidoSuContrasenna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOlvidoSuContrasenna));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCorreoElectronico3 = new TextBox();
            txtPIN = new TextBox();
            textBox3 = new TextBox();
            txtNuevaContrasenna3 = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnSalirOlvidoContra = new Button();
            btnRegresarOlvidoContra = new Button();
            btnOlvidarContrasenna = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 369);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 488);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 1;
            label2.Text = "PIN de Seguridad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 612);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 32);
            label3.TabIndex = 2;
            label3.Text = "Nueva Contraseña: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 734);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(280, 32);
            label4.TabIndex = 3;
            label4.Text = "Confirmar Contraseña: ";
            // 
            // txtCorreoElectronico3
            // 
            txtCorreoElectronico3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico3.Location = new Point(328, 369);
            txtCorreoElectronico3.Margin = new Padding(4, 5, 4, 5);
            txtCorreoElectronico3.Name = "txtCorreoElectronico3";
            txtCorreoElectronico3.Size = new Size(398, 39);
            txtCorreoElectronico3.TabIndex = 4;
            // 
            // txtPIN
            // 
            txtPIN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIN.Location = new Point(328, 488);
            txtPIN.Margin = new Padding(4, 5, 4, 5);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(398, 39);
            txtPIN.TabIndex = 5;
            txtPIN.UseSystemPasswordChar = true;
            txtPIN.KeyPress += txtPIN_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(328, 731);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(398, 39);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // txtNuevaContrasenna3
            // 
            txtNuevaContrasenna3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuevaContrasenna3.Location = new Point(328, 612);
            txtNuevaContrasenna3.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContrasenna3.Name = "txtNuevaContrasenna3";
            txtNuevaContrasenna3.Size = new Size(398, 39);
            txtNuevaContrasenna3.TabIndex = 7;
            txtNuevaContrasenna3.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(983, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(328, 212);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(595, 65);
            label5.TabIndex = 9;
            label5.Text = "Olvidaste tu contraseña?";
            // 
            // btnSalirOlvidoContra
            // 
            btnSalirOlvidoContra.BackColor = Color.FromArgb(192, 0, 0);
            btnSalirOlvidoContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirOlvidoContra.Location = new Point(1117, 913);
            btnSalirOlvidoContra.Margin = new Padding(4, 5, 4, 5);
            btnSalirOlvidoContra.Name = "btnSalirOlvidoContra";
            btnSalirOlvidoContra.Size = new Size(106, 62);
            btnSalirOlvidoContra.TabIndex = 10;
            btnSalirOlvidoContra.Text = "Salir";
            btnSalirOlvidoContra.UseVisualStyleBackColor = false;
            btnSalirOlvidoContra.Click += btnSalirOlvidoContra_Click_1;
            // 
            // btnRegresarOlvidoContra
            // 
            btnRegresarOlvidoContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresarOlvidoContra.Location = new Point(17, 913);
            btnRegresarOlvidoContra.Margin = new Padding(4, 5, 4, 5);
            btnRegresarOlvidoContra.Name = "btnRegresarOlvidoContra";
            btnRegresarOlvidoContra.Size = new Size(154, 62);
            btnRegresarOlvidoContra.TabIndex = 11;
            btnRegresarOlvidoContra.Text = "Regresar";
            btnRegresarOlvidoContra.UseVisualStyleBackColor = true;
            btnRegresarOlvidoContra.Click += btnRegresarOlvidoContra_Click_1;
            // 
            // btnOlvidarContrasenna
            // 
            btnOlvidarContrasenna.BackColor = Color.LightBlue;
            btnOlvidarContrasenna.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOlvidarContrasenna.Location = new Point(842, 806);
            btnOlvidarContrasenna.Margin = new Padding(4, 5, 4, 5);
            btnOlvidarContrasenna.Name = "btnOlvidarContrasenna";
            btnOlvidarContrasenna.Size = new Size(256, 52);
            btnOlvidarContrasenna.TabIndex = 13;
            btnOlvidarContrasenna.Text = "Cambiar Contraseña";
            btnOlvidarContrasenna.UseVisualStyleBackColor = false;
            btnOlvidarContrasenna.Click += btnOlvidarContrasenna_Click;
            // 
            // frmOlvidoSuContrasenna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1236, 995);
            Controls.Add(btnOlvidarContrasenna);
            Controls.Add(btnRegresarOlvidoContra);
            Controls.Add(btnSalirOlvidoContra);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtNuevaContrasenna3);
            Controls.Add(textBox3);
            Controls.Add(txtPIN);
            Controls.Add(txtCorreoElectronico3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmOlvidoSuContrasenna";
            Text = "frmOlvidoSuContrasenna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCorreoElectronico3;
        private TextBox txtPIN;
        private TextBox textBox3;
        private TextBox txtNuevaContrasenna3;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnSalirOlvidoContra;
        private Button btnRegresarOlvidoContra;
        private Button btnOlvidarContrasenna;
    }
}