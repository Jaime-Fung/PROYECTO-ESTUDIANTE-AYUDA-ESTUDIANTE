namespace PROYECTO
{
    partial class frmForo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForo));
            pictureBox1 = new PictureBox();
            linklblRegresar = new LinkLabel();
            dgvPregunta = new DataGridView();
            lblCorreo = new Label();
            label2 = new Label();
            btnEnviar = new Button();
            txtComentario = new TextBox();
            dgvForo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPregunta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvForo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linklblRegresar
            // 
            linklblRegresar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            linklblRegresar.Location = new Point(13, 1070);
            linklblRegresar.Margin = new Padding(4, 0, 4, 0);
            linklblRegresar.Name = "linklblRegresar";
            linklblRegresar.Size = new Size(131, 43);
            linklblRegresar.TabIndex = 49;
            linklblRegresar.TabStop = true;
            linklblRegresar.Text = "Regresar";
            linklblRegresar.LinkClicked += linklblRegresar_LinkClicked;
            // 
            // dgvPregunta
            // 
            dgvPregunta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPregunta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPregunta.Location = new Point(46, 215);
            dgvPregunta.Name = "dgvPregunta";
            dgvPregunta.RowHeadersWidth = 62;
            dgvPregunta.RowTemplate.Height = 33;
            dgvPregunta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregunta.Size = new Size(1522, 160);
            dgvPregunta.TabIndex = 56;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(991, 980);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(85, 25);
            lblCorreo.TabIndex = 54;
            lblCorreo.Text = "lblCorreo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(904, 980);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 53;
            label2.Text = "Usuario: ";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(1375, 980);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(193, 73);
            btnEnviar.TabIndex = 52;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(46, 812);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(1522, 146);
            txtComentario.TabIndex = 51;
            // 
            // dgvForo
            // 
            dgvForo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvForo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvForo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForo.Location = new Point(46, 391);
            dgvForo.Name = "dgvForo";
            dgvForo.RowHeadersWidth = 62;
            dgvForo.RowTemplate.Height = 33;
            dgvForo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForo.Size = new Size(1522, 406);
            dgvForo.TabIndex = 50;
            // 
            // frmForo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1616, 1122);
            Controls.Add(dgvPregunta);
            Controls.Add(lblCorreo);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(txtComentario);
            Controls.Add(dgvForo);
            Controls.Add(linklblRegresar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmForo";
            Text = "Foro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPregunta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvForo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linklblRegresar;
        private DataGridView dgvPregunta;
        private Label lblCorreo;
        private Label label2;
        private Button btnEnviar;
        private TextBox txtComentario;
        private DataGridView dgvForo;
    }
}