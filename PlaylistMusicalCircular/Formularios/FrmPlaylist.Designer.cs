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
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylist).BeginInit();
            SuspendLayout();
            // 
            // dgvPlaylist
            // 
            dgvPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaylist.Location = new Point(199, 92);
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
            txtBuscar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            txtBuscar.Location = new Point(199, 35);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.Text = "escriba la cancion a buscar";
            // 
            // bntBuscar
            // 
            bntBuscar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            bntBuscar.Location = new Point(463, 36);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(117, 25);
            bntBuscar.TabIndex = 3;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnActualizar.Location = new Point(199, 352);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.Location = new Point(356, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(496, 352);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 34);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
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
        private Button btnSalir;
    }
}