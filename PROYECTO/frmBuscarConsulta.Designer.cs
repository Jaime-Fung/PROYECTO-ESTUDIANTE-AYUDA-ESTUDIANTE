namespace PROYECTO
{
    partial class frmBuscarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarConsulta));
            btnIrAForo = new Button();
            btnSalirBC = new Button();
            dgvBuscar = new DataGridView();
            cbbCategoria = new ComboBox();
            label3 = new Label();
            lblCorreo = new Label();
            label4 = new Label();
            btnRegresar90 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).BeginInit();
            SuspendLayout();
            // 
            // btnIrAForo
            // 
            btnIrAForo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIrAForo.Location = new Point(730, 733);
            btnIrAForo.Name = "btnIrAForo";
            btnIrAForo.Size = new Size(169, 58);
            btnIrAForo.TabIndex = 21;
            btnIrAForo.Text = "Ir a Foro";
            btnIrAForo.UseVisualStyleBackColor = true;
            btnIrAForo.Click += btnIrAForo_Click;
            // 
            // btnSalirBC
            // 
            btnSalirBC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirBC.Location = new Point(445, 733);
            btnSalirBC.Name = "btnSalirBC";
            btnSalirBC.Size = new Size(169, 58);
            btnSalirBC.TabIndex = 20;
            btnSalirBC.Text = "Salir";
            btnSalirBC.UseVisualStyleBackColor = true;
            btnSalirBC.Click += btnSalirBC_Click;
            // 
            // dgvBuscar
            // 
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscar.Location = new Point(13, 68);
            dgvBuscar.Name = "dgvBuscar";
            dgvBuscar.RowHeadersWidth = 62;
            dgvBuscar.RowTemplate.Height = 33;
            dgvBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscar.Size = new Size(1361, 647);
            dgvBuscar.TabIndex = 19;
            // 
            // cbbCategoria
            // 
            cbbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Location = new Point(774, 15);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(183, 40);
            cbbCategoria.TabIndex = 18;
            cbbCategoria.SelectedIndexChanged += cbbCategoria_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(522, 18);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 22;
            label3.Text = "Elije una categoría";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(124, 18);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(83, 32);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 18);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 23;
            label4.Text = "Usuario: ";
            // 
            // btnRegresar90
            // 
            btnRegresar90.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar90.ForeColor = Color.Black;
            btnRegresar90.Location = new Point(13, 734);
            btnRegresar90.Margin = new Padding(4, 5, 4, 5);
            btnRegresar90.Name = "btnRegresar90";
            btnRegresar90.Size = new Size(154, 62);
            btnRegresar90.TabIndex = 34;
            btnRegresar90.Text = "Regresar";
            btnRegresar90.UseVisualStyleBackColor = true;
            btnRegresar90.Click += btnRegresar90_Click;
            // 
            // frmBuscarConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1386, 810);
            Controls.Add(btnRegresar90);
            Controls.Add(lblCorreo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnIrAForo);
            Controls.Add(btnSalirBC);
            Controls.Add(dgvBuscar);
            Controls.Add(cbbCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBuscarConsulta";
            Text = "frmBuscarConsulta";
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIrAForo;
        private Button btnSalirBC;
        private DataGridView dgvBuscar;
        private ComboBox cbbCategoria;
        private Label label3;
        private Label lblCorreo;
        private Label label4;
        private Button btnRegresar90;
    }
}