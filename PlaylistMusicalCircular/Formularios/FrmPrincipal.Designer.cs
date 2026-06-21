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
            label1 = new Label();
            btnAgregarCancion = new Button();
            btnVerPlaylist = new Button();
            btnReproductor = new Button();
            btnSalir = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "MY PLAYLIST";
            // 
            // btnAgregarCancion
            // 
            btnAgregarCancion.Location = new Point(279, 87);
            btnAgregarCancion.Name = "btnAgregarCancion";
            btnAgregarCancion.Size = new Size(159, 35);
            btnAgregarCancion.TabIndex = 1;
            btnAgregarCancion.Text = "Agregar cancion";
            btnAgregarCancion.UseVisualStyleBackColor = true;
            btnAgregarCancion.Click += btnAgregarCancion_Click;
            // 
            // btnVerPlaylist
            // 
            btnVerPlaylist.Location = new Point(279, 139);
            btnVerPlaylist.Name = "btnVerPlaylist";
            btnVerPlaylist.Size = new Size(159, 31);
            btnVerPlaylist.TabIndex = 2;
            btnVerPlaylist.Text = "Ver Playlist";
            btnVerPlaylist.UseVisualStyleBackColor = true;
            btnVerPlaylist.Click += btnVerPlaylist_Click;
            // 
            // btnReproductor
            // 
            btnReproductor.Location = new Point(279, 192);
            btnReproductor.Name = "btnReproductor";
            btnReproductor.Size = new Size(159, 30);
            btnReproductor.TabIndex = 3;
            btnReproductor.Text = "Reproductor";
            btnReproductor.UseVisualStyleBackColor = true;
            btnReproductor.Click += btnReproductor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(279, 244);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 31);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button5
            // 
            button5.Location = new Point(387, 238);
            button5.Name = "button5";
            button5.Size = new Size(0, 0);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(btnSalir);
            Controls.Add(btnReproductor);
            Controls.Add(btnVerPlaylist);
            Controls.Add(btnAgregarCancion);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarCancion;
        private Button btnVerPlaylist;
        private Button btnReproductor;
        private Button btnSalir;
        private Button button5;
    }
}
