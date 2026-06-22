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
            txtGenero = new TextBox();
            btnSeleccionarMP3 = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnSeleccionarImagen = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(248, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 26);
            txtTitulo.TabIndex = 0;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(248, 123);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(100, 26);
            txtArtista.TabIndex = 1;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(248, 195);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(100, 26);
            txtAlbum.TabIndex = 2;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(248, 264);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(100, 26);
            txtGenero.TabIndex = 3;
            // 
            // btnSeleccionarMP3
            // 
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
            btnSeleccionarImagen.Location = new Point(200, 368);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(121, 49);
            btnSeleccionarImagen.TabIndex = 7;
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // FrmEditarCancion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionarMP3);
            Controls.Add(txtGenero);
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
        private TextBox txtGenero;
        private Button btnSeleccionarMP3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnSeleccionarImagen;
    }
}