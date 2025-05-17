namespace PROYECTO
{
    partial class frmVerFotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerFotos));
            btnSalir790 = new Button();
            ptbImagen3 = new PictureBox();
            ptbImagen4 = new PictureBox();
            ptbImagen2 = new PictureBox();
            ptbImagen1 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnRegresar750 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbImagen3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir790
            // 
            btnSalir790.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir790.FlatStyle = FlatStyle.Flat;
            btnSalir790.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir790.ForeColor = Color.White;
            btnSalir790.Location = new Point(1254, 1025);
            btnSalir790.Name = "btnSalir790";
            btnSalir790.Size = new Size(154, 62);
            btnSalir790.TabIndex = 9;
            btnSalir790.Text = "Salir";
            btnSalir790.UseVisualStyleBackColor = false;
            btnSalir790.Click += btnSalir790_Click;
            // 
            // ptbImagen3
            // 
            ptbImagen3.Location = new Point(731, 282);
            ptbImagen3.Name = "ptbImagen3";
            ptbImagen3.Size = new Size(554, 347);
            ptbImagen3.SizeMode = PictureBoxSizeMode.Zoom;
            ptbImagen3.TabIndex = 8;
            ptbImagen3.TabStop = false;
            // 
            // ptbImagen4
            // 
            ptbImagen4.Location = new Point(731, 635);
            ptbImagen4.Name = "ptbImagen4";
            ptbImagen4.Size = new Size(554, 347);
            ptbImagen4.SizeMode = PictureBoxSizeMode.Zoom;
            ptbImagen4.TabIndex = 7;
            ptbImagen4.TabStop = false;
            // 
            // ptbImagen2
            // 
            ptbImagen2.Location = new Point(170, 635);
            ptbImagen2.Name = "ptbImagen2";
            ptbImagen2.Size = new Size(554, 347);
            ptbImagen2.SizeMode = PictureBoxSizeMode.Zoom;
            ptbImagen2.TabIndex = 6;
            ptbImagen2.TabStop = false;
            // 
            // ptbImagen1
            // 
            ptbImagen1.Location = new Point(170, 282);
            ptbImagen1.Name = "ptbImagen1";
            ptbImagen1.Size = new Size(554, 347);
            ptbImagen1.SizeMode = PictureBoxSizeMode.Zoom;
            ptbImagen1.TabIndex = 5;
            ptbImagen1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(290, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnRegresar750
            // 
            btnRegresar750.Location = new Point(17, 1025);
            btnRegresar750.Margin = new Padding(4, 5, 4, 5);
            btnRegresar750.Name = "btnRegresar750";
            btnRegresar750.Size = new Size(154, 62);
            btnRegresar750.TabIndex = 11;
            btnRegresar750.Text = "Regresar";
            btnRegresar750.UseVisualStyleBackColor = true;
            btnRegresar750.Click += btnRegresar750_Click;
            // 
            // frmVerFotos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1424, 1105);
            Controls.Add(btnRegresar750);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir790);
            Controls.Add(ptbImagen3);
            Controls.Add(ptbImagen4);
            Controls.Add(ptbImagen2);
            Controls.Add(ptbImagen1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmVerFotos";
            Text = "frmVerFotos";
            ((System.ComponentModel.ISupportInitialize)ptbImagen3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbImagen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir790;
        private PictureBox ptbImagen3;
        private PictureBox ptbImagen4;
        private PictureBox ptbImagen2;
        private PictureBox ptbImagen1;
        private PictureBox pictureBox1;
        private Button btnRegresar750;
    }
}