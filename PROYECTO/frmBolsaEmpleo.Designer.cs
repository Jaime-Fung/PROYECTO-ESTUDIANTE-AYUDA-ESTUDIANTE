namespace PROYECTO
{
    partial class frmBolsaEmpleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolsaEmpleo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvBolsaEmpleo = new DataGridView();
            label2 = new Label();
            btnRegresar12 = new Button();
            btnSalir12 = new Button();
            lklblAgregaEmpleo2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolsaEmpleo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, 40);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(581, 248);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 71);
            label1.TabIndex = 1;
            label1.Text = "Buscas Empleo?";
            // 
            // dgvBolsaEmpleo
            // 
            dgvBolsaEmpleo.AllowUserToAddRows = false;
            dgvBolsaEmpleo.AllowUserToDeleteRows = false;
            dgvBolsaEmpleo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBolsaEmpleo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolsaEmpleo.Location = new Point(17, 472);
            dgvBolsaEmpleo.Margin = new Padding(4, 5, 4, 5);
            dgvBolsaEmpleo.Name = "dgvBolsaEmpleo";
            dgvBolsaEmpleo.ReadOnly = true;
            dgvBolsaEmpleo.RowHeadersWidth = 62;
            dgvBolsaEmpleo.RowTemplate.Height = 25;
            dgvBolsaEmpleo.Size = new Size(1543, 697);
            dgvBolsaEmpleo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 378);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1204, 45);
            label2.TabIndex = 3;
            label2.Text = "¡Manda un correo electronico con tu CV a la empresa que te interese de la lista!";
            // 
            // btnRegresar12
            // 
            btnRegresar12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar12.Location = new Point(17, 1292);
            btnRegresar12.Margin = new Padding(4, 5, 4, 5);
            btnRegresar12.Name = "btnRegresar12";
            btnRegresar12.Size = new Size(186, 62);
            btnRegresar12.TabIndex = 4;
            btnRegresar12.Text = "Regresar";
            btnRegresar12.UseVisualStyleBackColor = true;
            btnRegresar12.Click += btnRegresar12_Click;
            // 
            // btnSalir12
            // 
            btnSalir12.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir12.FlatStyle = FlatStyle.Flat;
            btnSalir12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir12.Location = new Point(1406, 1295);
            btnSalir12.Margin = new Padding(4, 5, 4, 5);
            btnSalir12.Name = "btnSalir12";
            btnSalir12.Size = new Size(154, 62);
            btnSalir12.TabIndex = 5;
            btnSalir12.Text = "Salir";
            btnSalir12.UseVisualStyleBackColor = false;
            btnSalir12.Click += btnSalir12_Click;
            // 
            // lklblAgregaEmpleo2
            // 
            lklblAgregaEmpleo2.AutoSize = true;
            lklblAgregaEmpleo2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklblAgregaEmpleo2.LinkColor = Color.Yellow;
            lklblAgregaEmpleo2.Location = new Point(694, 1295);
            lklblAgregaEmpleo2.Margin = new Padding(4, 0, 4, 0);
            lklblAgregaEmpleo2.Name = "lklblAgregaEmpleo2";
            lklblAgregaEmpleo2.Size = new Size(254, 40);
            lklblAgregaEmpleo2.TabIndex = 23;
            lklblAgregaEmpleo2.TabStop = true;
            lklblAgregaEmpleo2.Text = "Agrega un Empleo";
            lklblAgregaEmpleo2.LinkClicked += lklblAgregaEmpleo2_LinkClicked;
            // 
            // frmBolsaEmpleo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1584, 1367);
            Controls.Add(lklblAgregaEmpleo2);
            Controls.Add(btnSalir12);
            Controls.Add(btnRegresar12);
            Controls.Add(label2);
            Controls.Add(dgvBolsaEmpleo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBolsaEmpleo";
            Text = "frmBolsaEmpleo";
            Load += frmBolsaEmpleo_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolsaEmpleo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvBolsaEmpleo;
        private Label label2;
        private Button btnRegresar12;
        private Button btnSalir12;
        private LinkLabel lklblAgregaEmpleo2;
    }
}