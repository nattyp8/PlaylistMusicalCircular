namespace PlaylistMusicalCircular.Formularios
{
    partial class FrmAgregarCancion
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
            lbltitulobienvenida = new Label();
            lblTitulo = new Label();
            lblArtisita = new Label();
            lblAlbum = new Label();
            txtTitulo = new TextBox();
            txtArtista = new TextBox();
            txtAlbum = new TextBox();
            btnSeleccionarMP3 = new Button();
            btnSeleccionarImagen = new Button();
            bntGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lbltitulobienvenida
            // 
            lbltitulobienvenida.AutoSize = true;
            lbltitulobienvenida.Location = new Point(298, 58);
            lbltitulobienvenida.Name = "lbltitulobienvenida";
            lbltitulobienvenida.Size = new Size(196, 19);
            lbltitulobienvenida.TabIndex = 0;
            lbltitulobienvenida.Text = "Agregar canciones a la playlist!";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(280, 147);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(43, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            // 
            // lblArtisita
            // 
            lblArtisita.AutoSize = true;
            lblArtisita.Location = new Point(280, 189);
            lblArtisita.Name = "lblArtisita";
            lblArtisita.Size = new Size(52, 19);
            lblArtisita.TabIndex = 2;
            lblArtisita.Text = "Artisita";
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(280, 227);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(49, 19);
            lblAlbum.TabIndex = 3;
            lblAlbum.Text = "Album";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(413, 140);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 26);
            txtTitulo.TabIndex = 6;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(413, 182);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(100, 26);
            txtArtista.TabIndex = 7;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(413, 224);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(100, 26);
            txtAlbum.TabIndex = 8;
            // 
            // btnSeleccionarMP3
            // 
            btnSeleccionarMP3.Location = new Point(76, 353);
            btnSeleccionarMP3.Name = "btnSeleccionarMP3";
            btnSeleccionarMP3.Size = new Size(135, 32);
            btnSeleccionarMP3.TabIndex = 11;
            btnSeleccionarMP3.Text = "Seleccionar MP3";
            btnSeleccionarMP3.UseVisualStyleBackColor = true;
            btnSeleccionarMP3.Click += btnSeleccionarMP3_Click;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Location = new Point(245, 352);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(163, 32);
            btnSeleccionarImagen.TabIndex = 12;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // bntGuardar
            // 
            bntGuardar.Location = new Point(460, 351);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(103, 32);
            bntGuardar.TabIndex = 13;
            bntGuardar.Text = "Guardar ";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(626, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 32);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarCancion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(bntGuardar);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(btnSeleccionarMP3);
            Controls.Add(txtAlbum);
            Controls.Add(txtArtista);
            Controls.Add(txtTitulo);
            Controls.Add(lblAlbum);
            Controls.Add(lblArtisita);
            Controls.Add(lblTitulo);
            Controls.Add(lbltitulobienvenida);
            Name = "FrmAgregarCancion";
            Text = "FrmAgregarCancion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulobienvenida;
        private Label lblTitulo;
        private Label lblArtisita;
        private Label lblAlbum;
        private TextBox txtTitulo;
        private TextBox txtArtista;
        private TextBox txtAlbum;
        private Button btnSeleccionarMP3;
        private Button btnSeleccionarImagen;
        private Button bntGuardar;
        private Button btnCancelar;
    }
}