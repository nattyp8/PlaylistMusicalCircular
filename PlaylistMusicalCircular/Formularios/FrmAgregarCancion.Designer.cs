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
            lbltitulobienvenida.Font = new Font("Cascadia Mono SemiBold", 15F, FontStyle.Bold | FontStyle.Italic);
            lbltitulobienvenida.ForeColor = Color.DarkMagenta;
            lbltitulobienvenida.Location = new Point(179, 42);
            lbltitulobienvenida.Name = "lbltitulobienvenida";
            lbltitulobienvenida.Size = new Size(396, 27);
            lbltitulobienvenida.TabIndex = 0;
            lbltitulobienvenida.Text = "Agregue canciones a la playlist!";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(191, 121);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo :";
            // 
            // lblArtisita
            // 
            lblArtisita.AutoSize = true;
            lblArtisita.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtisita.ForeColor = Color.DimGray;
            lblArtisita.Location = new Point(191, 186);
            lblArtisita.Name = "lblArtisita";
            lblArtisita.Size = new Size(65, 20);
            lblArtisita.TabIndex = 2;
            lblArtisita.Text = "Artista : ";
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbum.ForeColor = Color.DimGray;
            lblAlbum.Location = new Point(191, 245);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(62, 20);
            lblAlbum.TabIndex = 3;
            lblAlbum.Text = "Album :";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.Window;
            txtTitulo.Location = new Point(277, 114);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(165, 26);
            txtTitulo.TabIndex = 6;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(277, 186);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(165, 26);
            txtArtista.TabIndex = 7;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(277, 242);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(165, 26);
            txtAlbum.TabIndex = 8;
            // 
            // btnSeleccionarMP3
            // 
            btnSeleccionarMP3.BackColor = Color.Thistle;
            btnSeleccionarMP3.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSeleccionarMP3.Location = new Point(179, 351);
            btnSeleccionarMP3.Name = "btnSeleccionarMP3";
            btnSeleccionarMP3.Size = new Size(204, 39);
            btnSeleccionarMP3.TabIndex = 11;
            btnSeleccionarMP3.Text = "Seleccionar MP3";
            btnSeleccionarMP3.UseVisualStyleBackColor = false;
            btnSeleccionarMP3.Click += btnSeleccionarMP3_Click;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.BackColor = Color.Thistle;
            btnSeleccionarImagen.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnSeleccionarImagen.Location = new Point(179, 304);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(204, 41);
            btnSeleccionarImagen.TabIndex = 12;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // bntGuardar
            // 
            bntGuardar.BackColor = Color.Thistle;
            bntGuardar.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold | FontStyle.Italic);
            bntGuardar.Location = new Point(179, 430);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(110, 47);
            bntGuardar.TabIndex = 13;
            bntGuardar.Text = "Guardar ";
            bntGuardar.UseVisualStyleBackColor = false;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Thistle;
            btnCancelar.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.Location = new Point(417, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 47);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarCancion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(715, 504);
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
            Text = "Agregar Cancion a la playlist";
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