namespace PROYECTO
{
    partial class frmFormularConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularConsulta));
            btnConsultar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtConsulta = new TextBox();
            label3 = new Label();
            lblCorreo = new Label();
            cbbCategoria = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRegresar23 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.Location = new Point(563, 615);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(234, 62);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(871, 713);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(154, 62);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(246, 615);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(234, 62);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConsulta.Location = new Point(54, 342);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(947, 181);
            txtConsulta.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 291);
            label3.Name = "label3";
            label3.Size = new Size(250, 32);
            label3.TabIndex = 13;
            label3.Text = "Formula tu consulta:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(163, 223);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 32);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "lblCorreo";
            // 
            // cbbCategoria
            // 
            cbbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Location = new Point(654, 223);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(183, 40);
            cbbCategoria.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 223);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 10;
            label2.Text = "Usuario: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(423, 223);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 9;
            label1.Text = "Elije una categoría";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnRegresar23
            // 
            btnRegresar23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar23.ForeColor = Color.Black;
            btnRegresar23.Location = new Point(13, 713);
            btnRegresar23.Margin = new Padding(4, 5, 4, 5);
            btnRegresar23.Name = "btnRegresar23";
            btnRegresar23.Size = new Size(154, 62);
            btnRegresar23.TabIndex = 34;
            btnRegresar23.Text = "Regresar";
            btnRegresar23.UseVisualStyleBackColor = true;
            btnRegresar23.Click += btnRegresar23_Click;
            // 
            // frmFormularConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1041, 793);
            Controls.Add(btnRegresar23);
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(txtConsulta);
            Controls.Add(label3);
            Controls.Add(lblCorreo);
            Controls.Add(cbbCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmFormularConsulta";
            Text = "frmFormularConsulta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtConsulta;
        private Label label3;
        private Label lblCorreo;
        private ComboBox cbbCategoria;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnRegresar23;
    }
}