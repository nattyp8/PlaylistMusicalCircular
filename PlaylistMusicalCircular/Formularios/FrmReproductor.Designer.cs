namespace PlaylistMusicalCircular.Formularios
{
    partial class FrmReproductor
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
            components = new System.ComponentModel.Container();
            lblTituloCancion = new Label();
            lbl = new Label();
            btnAnterior = new Button();
            btnReproducir = new Button();
            btnSiguiente = new Button();
            lblArtista = new Label();
            pbPortada = new PictureBox();
            trackBarProgreso = new TrackBar();
            lblTiempo = new Label();
            timerProgreso = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProgreso).BeginInit();
            SuspendLayout();
            // 
            // lblTituloCancion
            // 
            lblTituloCancion.AutoSize = true;
            lblTituloCancion.Location = new Point(220, 180);
            lblTituloCancion.Name = "lblTituloCancion";
            lblTituloCancion.Size = new Size(150, 19);
            lblTituloCancion.TabIndex = 0;
            lblTituloCancion.Text = "no hay cancion todavia";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(255, 171);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 19);
            lbl.TabIndex = 2;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(82, 398);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(76, 37);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "⏮";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.Location = new Point(255, 398);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(79, 37);
            btnReproducir.TabIndex = 4;
            btnReproducir.Text = "▶";
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(414, 398);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 37);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "⏭";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.Location = new Point(239, 223);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(117, 19);
            lblArtista.TabIndex = 1;
            lblArtista.Text = "tdv no hay artista";
            // 
            // pbPortada
            // 
            pbPortada.Location = new Point(204, 21);
            pbPortada.Name = "pbPortada";
            pbPortada.Size = new Size(188, 137);
            pbPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pbPortada.TabIndex = 6;
            pbPortada.TabStop = false;
            // 
            // trackBarProgreso
            // 
            trackBarProgreso.Location = new Point(204, 268);
            trackBarProgreso.Maximum = 100;
            trackBarProgreso.Name = "trackBarProgreso";
            trackBarProgreso.Size = new Size(188, 45);
            trackBarProgreso.TabIndex = 7;
            trackBarProgreso.TickStyle = TickStyle.None;
            trackBarProgreso.Scroll += trackBarProgreso_Scroll;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(255, 331);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(92, 19);
            lblTiempo.TabIndex = 8;
            lblTiempo.Text = "00:00 / 00:00";
            // 
            // timerProgreso
            // 
            timerProgreso.Interval = 500;
            timerProgreso.Tick += timerProgreso_Tick;
            // 
            // FrmReproductor
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 463);
            Controls.Add(lblTiempo);
            Controls.Add(trackBarProgreso);
            Controls.Add(pbPortada);
            Controls.Add(btnSiguiente);
            Controls.Add(btnReproducir);
            Controls.Add(btnAnterior);
            Controls.Add(lbl);
            Controls.Add(lblArtista);
            Controls.Add(lblTituloCancion);
            Name = "FrmReproductor";
            Text = "FrmReproductor";
            FormClosing += FrmReproductor_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProgreso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloCancion;
        private Label lbl;
        private Button btnAnterior;
        private Button btnReproducir;
        private Button button2;
        private Button btnSiguiente;
        private Label lblArtista;
        private PictureBox pbPortada;
        private TrackBar trackBarProgreso;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timerProgreso;
    }
}