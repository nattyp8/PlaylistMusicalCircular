namespace PlaylistMusicalCircular.Formularios
{
    partial class FrmPlaylist
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
            dgvPlaylist = new DataGridView();
            lblBuscaar = new Label();
            txtBuscar = new TextBox();
            bntBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylist).BeginInit();
            SuspendLayout();
            // 
            // dgvPlaylist
            // 
            dgvPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaylist.Location = new Point(199, 39);
            dgvPlaylist.Name = "dgvPlaylist";
            dgvPlaylist.Size = new Size(381, 223);
            dgvPlaylist.TabIndex = 0;
            // 
            // lblBuscaar
            // 
            lblBuscaar.AutoSize = true;
            lblBuscaar.Location = new Point(199, 287);
            lblBuscaar.Name = "lblBuscaar";
            lblBuscaar.Size = new Size(0, 19);
            lblBuscaar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(376, 287);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(144, 26);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(249, 288);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 25);
            bntBuscar.TabIndex = 3;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(199, 368);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(505, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(bntBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscaar);
            Controls.Add(dgvPlaylist);
            Name = "FrmPlaylist";
            Text = "FrmPlaylist";
            ((System.ComponentModel.ISupportInitialize)dgvPlaylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlaylist;
        private Label lblBuscaar;
        private TextBox txtBuscar;
        private Button bntBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}