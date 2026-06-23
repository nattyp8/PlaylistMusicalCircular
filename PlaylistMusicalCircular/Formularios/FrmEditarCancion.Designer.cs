namespace PlaylistMusicalCircular.Formularios
{
    partial class FrmEditarCancion
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
            txtTitulo = new TextBox();
            txtArtista = new TextBox();
            txtAlbum = new TextBox();
            btnSeleccionarMP3 = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnSeleccionarImagen = new Button();
            lblAlbum = new Label();
            lblArtisita = new Label();
            lblTitulo = new Label();
            lblbienvenida = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            txtTitulo.Location = new Point(319, 114);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(165, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(319, 182);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(165, 26);
            txtArtista.TabIndex = 1;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(328, 254);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(165, 26);
            txtAlbum.TabIndex = 2;
            txtAlbum.TextChanged += txtAlbum_TextChanged;
            // 
            // btnSeleccionarMP3
            // 
            btnSeleccionarMP3.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnSeleccionarMP3.Location = new Point(39, 368);
            btnSeleccionarMP3.Name = "btnSeleccionarMP3";
            btnSeleccionarMP3.Size = new Size(128, 49);
            btnSeleccionarMP3.TabIndex = 4;
            btnSeleccionarMP3.Text = "Seleccionar MP3";
            btnSeleccionarMP3.UseVisualStyleBackColor = true;
            btnSeleccionarMP3.Click += btnSeleccionarMP3_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnCancelar.Location = new Point(482, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.Location = new Point(357, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 49);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnSeleccionarImagen.Location = new Point(200, 368);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(121, 49);
            btnSeleccionarImagen.TabIndex = 7;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbum.ForeColor = Color.DimGray;
            lblAlbum.Location = new Point(200, 260);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(62, 20);
            lblAlbum.TabIndex = 10;
            lblAlbum.Text = "Album :";
            // 
            // lblArtisita
            // 
            lblArtisita.AutoSize = true;
            lblArtisita.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtisita.ForeColor = Color.DimGray;
            lblArtisita.Location = new Point(200, 188);
            lblArtisita.Name = "lblArtisita";
            lblArtisita.Size = new Size(65, 20);
            lblArtisita.TabIndex = 9;
            lblArtisita.Text = "Artista : ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(200, 114);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 20);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Titulo :";
            // 
            // lblbienvenida
            // 
            lblbienvenida.AutoSize = true;
            lblbienvenida.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblbienvenida.ForeColor = Color.DimGray;
            lblbienvenida.Location = new Point(238, 46);
            lblbienvenida.Name = "lblbienvenida";
            lblbienvenida.Size = new Size(226, 21);
            lblbienvenida.TabIndex = 11;
            lblbienvenida.Text = "Edite las canciones aqui";
            // 
            // FrmEditarCancion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 504);
            Controls.Add(lblbienvenida);
            Controls.Add(lblAlbum);
            Controls.Add(lblArtisita);
            Controls.Add(lblTitulo);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionarMP3);
            Controls.Add(txtAlbum);
            Controls.Add(txtArtista);
            Controls.Add(txtTitulo);
            Name = "FrmEditarCancion";
            Text = "FrmEditarCancion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtArtista;
        private TextBox txtAlbum;
        private Button btnSeleccionarMP3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnSeleccionarImagen;
        private Label lblAlbum;
        private Label lblArtisita;
        private Label lblTitulo;
        private Label lblbienvenida;
    }
}