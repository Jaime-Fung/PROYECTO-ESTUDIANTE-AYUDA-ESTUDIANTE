namespace PROYECTO
{
    partial class frmMenuForo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuForo));
            pictureBox1 = new PictureBox();
            btnSalir600 = new Button();
            btnVerForo = new Button();
            btnRealizarConsulta = new Button();
            btnRegresar600 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSalir600
            // 
            btnSalir600.BackColor = Color.Red;
            btnSalir600.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir600.ForeColor = SystemColors.ButtonHighlight;
            btnSalir600.Location = new Point(759, 665);
            btnSalir600.Name = "btnSalir600";
            btnSalir600.Size = new Size(154, 62);
            btnSalir600.TabIndex = 5;
            btnSalir600.Text = "Salir";
            btnSalir600.UseVisualStyleBackColor = false;
            btnSalir600.Click += btnSalir600_Click;
            // 
            // btnVerForo
            // 
            btnVerForo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerForo.Location = new Point(269, 455);
            btnVerForo.Name = "btnVerForo";
            btnVerForo.Size = new Size(384, 97);
            btnVerForo.TabIndex = 4;
            btnVerForo.Text = "Ver Temas del Foro";
            btnVerForo.UseVisualStyleBackColor = true;
            btnVerForo.Click += btnVerForo_Click;
            // 
            // btnRealizarConsulta
            // 
            btnRealizarConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarConsulta.Location = new Point(269, 337);
            btnRealizarConsulta.Name = "btnRealizarConsulta";
            btnRealizarConsulta.Size = new Size(384, 97);
            btnRealizarConsulta.TabIndex = 3;
            btnRealizarConsulta.Text = "Realizar Consulta";
            btnRealizarConsulta.UseVisualStyleBackColor = true;
            btnRealizarConsulta.Click += btnRealizarConsulta_Click;
            // 
            // btnRegresar600
            // 
            btnRegresar600.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar600.Location = new Point(17, 665);
            btnRegresar600.Margin = new Padding(4, 5, 4, 5);
            btnRegresar600.Name = "btnRegresar600";
            btnRegresar600.Size = new Size(154, 62);
            btnRegresar600.TabIndex = 6;
            btnRegresar600.Text = "Regresar";
            btnRegresar600.UseVisualStyleBackColor = true;
            btnRegresar600.Click += btnRegresar600_Click;
            // 
            // frmMenuForo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(929, 745);
            Controls.Add(btnRegresar600);
            Controls.Add(btnSalir600);
            Controls.Add(btnVerForo);
            Controls.Add(btnRealizarConsulta);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenuForo";
            Text = "frmMenuForo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSalir600;
        private Button btnVerForo;
        private Button btnRealizarConsulta;
        private Button btnRegresar600;
    }
}