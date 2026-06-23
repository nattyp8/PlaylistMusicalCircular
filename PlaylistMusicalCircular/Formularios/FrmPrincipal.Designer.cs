namespace PlaylistMusicalCircular
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombrePlaylist = new Label();
            btnAgregarCancion = new Button();
            btnVerPlaylist = new Button();
            btnReproductor = new Button();
            btnSalir = new Button();
            button5 = new Button();
            lblMateria = new Label();
            lblNombres = new Label();
            SuspendLayout();
            // 
            // lblNombrePlaylist
            // 
            lblNombrePlaylist.AutoSize = true;
            lblNombrePlaylist.Font = new Font("Cascadia Mono SemiBold", 15F, FontStyle.Bold | FontStyle.Italic);
            lblNombrePlaylist.Location = new Point(250, 86);
            lblNombrePlaylist.Name = "lblNombrePlaylist";
            lblNombrePlaylist.Size = new Size(216, 27);
            lblNombrePlaylist.TabIndex = 0;
            lblNombrePlaylist.Text = "MY PLAYLIST LOCAL";
            // 
            // btnAgregarCancion
            // 
            btnAgregarCancion.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnAgregarCancion.Location = new Point(268, 140);
            btnAgregarCancion.Name = "btnAgregarCancion";
            btnAgregarCancion.Size = new Size(159, 35);
            btnAgregarCancion.TabIndex = 1;
            btnAgregarCancion.Text = "Agregar cancion";
            btnAgregarCancion.UseVisualStyleBackColor = true;
            btnAgregarCancion.Click += btnAgregarCancion_Click;
            // 
            // btnVerPlaylist
            // 
            btnVerPlaylist.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnVerPlaylist.Location = new Point(268, 192);
            btnVerPlaylist.Name = "btnVerPlaylist";
            btnVerPlaylist.Size = new Size(159, 31);
            btnVerPlaylist.TabIndex = 2;
            btnVerPlaylist.Text = "Ver Playlist";
            btnVerPlaylist.UseVisualStyleBackColor = true;
            btnVerPlaylist.Click += btnVerPlaylist_Click;
            // 
            // btnReproductor
            // 
            btnReproductor.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnReproductor.Location = new Point(268, 245);
            btnReproductor.Name = "btnReproductor";
            btnReproductor.Size = new Size(159, 30);
            btnReproductor.TabIndex = 3;
            btnReproductor.Text = "Reproductor";
            btnReproductor.UseVisualStyleBackColor = true;
            btnReproductor.Click += btnReproductor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(268, 297);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 31);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button5
            // 
            button5.Location = new Point(376, 291);
            button5.Name = "button5";
            button5.Size = new Size(0, 0);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblMateria.Location = new Point(206, 391);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(273, 16);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia Estructura de datos y archivos";
            lblMateria.Click += label1_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNombres.Location = new Point(188, 418);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(315, 16);
            lblNombres.TabIndex = 7;
            lblNombres.Text = "Natalia Vallejos, Ana Gayoso, Andrea Olmedo.";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 504);
            Controls.Add(lblNombres);
            Controls.Add(lblMateria);
            Controls.Add(button5);
            Controls.Add(btnSalir);
            Controls.Add(btnReproductor);
            Controls.Add(btnVerPlaylist);
            Controls.Add(btnAgregarCancion);
            Controls.Add(lblNombrePlaylist);
            Name = "FrmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePlaylist;
        private Button btnAgregarCancion;
        private Button btnVerPlaylist;
        private Button btnReproductor;
        private Button btnSalir;
        private Button button5;
        private Label lblMateria;
        private Label lblNombres;
    }
}
