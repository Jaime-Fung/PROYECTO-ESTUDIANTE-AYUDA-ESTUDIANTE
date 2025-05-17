namespace PROYECTO
{
    partial class frmAgenteBienesRaicesBR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAgenteBR = new DataGridView();
            btnRegresar31 = new Button();
            btnEliminarOferta = new Button();
            btnAgregarOferta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgenteBR).BeginInit();
           
            // 
            // dgvAgenteBR
            // 
            dgvAgenteBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenteBR.Location = new Point(11, 11);
            dgvAgenteBR.Margin = new Padding(2);
            dgvAgenteBR.Name = "dgvAgenteBR";
            dgvAgenteBR.RowHeadersWidth = 62;
            dgvAgenteBR.RowTemplate.Height = 33;
            dgvAgenteBR.Size = new Size(912, 430);
            dgvAgenteBR.TabIndex = 1;
            // 
            // btnRegresar31
            // 
            btnRegresar31.Location = new Point(739, 645);
            btnRegresar31.Margin = new Padding(2);
            btnRegresar31.Name = "btnRegresar31";
            btnRegresar31.Size = new Size(78, 20);
            btnRegresar31.TabIndex = 6;
            btnRegresar31.Text = "Regresar";
            btnRegresar31.UseVisualStyleBackColor = true;
            
            // 
            // btnEliminarOferta
            // 
            btnEliminarOferta.Location = new Point(202, 633);
            btnEliminarOferta.Margin = new Padding(2);
            btnEliminarOferta.Name = "btnEliminarOferta";
            btnEliminarOferta.Size = new Size(78, 44);
            btnEliminarOferta.TabIndex = 5;
            btnEliminarOferta.Text = "Eliminar oferta";
            btnEliminarOferta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarOferta
            // 
            btnAgregarOferta.Location = new Point(100, 633);
            btnAgregarOferta.Margin = new Padding(2);
            btnAgregarOferta.Name = "btnAgregarOferta";
            btnAgregarOferta.Size = new Size(78, 44);
            btnAgregarOferta.TabIndex = 4;
            btnAgregarOferta.Text = "Agregar oferta";
            btnAgregarOferta.UseVisualStyleBackColor = true;
            
            // 
            // frmAgenteBienesRaicesBR
            // 
           
        }

        #endregion

        private DataGridView dgvAgenteBR;
        private Button btnRegresar31;
        private Button btnEliminarOferta;
        private Button btnAgregarOferta;
    }
}