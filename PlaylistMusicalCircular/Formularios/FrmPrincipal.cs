using PlaylistMusicalCircular.Formularios;

namespace PlaylistMusicalCircular
{
    public partial class FrmPrincipal : Form
    {
        private void AplicarTema()
        {
            // Fondo principal rosa
            this.BackColor = ColorTranslator.FromHtml("#EFCEDB");

            lblNombrePlaylist.ForeColor = ColorTranslator.FromHtml("#4F2B1F");
            lblMateria.ForeColor = ColorTranslator.FromHtml("#4F2B1F");
            lblNombres.ForeColor = ColorTranslator.FromHtml("#4F2B1F");

            // Botón Agregar
            btnAgregarCancion.BackColor = ColorTranslator.FromHtml("#4F2B1F");
            btnAgregarCancion.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            btnAgregarCancion.FlatStyle = FlatStyle.Flat;

            // Botón Playlist
            btnVerPlaylist.BackColor = ColorTranslator.FromHtml("#4F2B1F");
            btnVerPlaylist.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            btnVerPlaylist.FlatStyle = FlatStyle.Flat;

            // Botón Reproductor
            btnReproductor.BackColor = ColorTranslator.FromHtml("#4F2B1F");
            btnReproductor.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            btnReproductor.FlatStyle = FlatStyle.Flat;

            // Botón Salir
            btnSalir.BackColor = ColorTranslator.FromHtml("#4F2B1F");
            btnSalir.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            btnSalir.FlatStyle = FlatStyle.Flat;
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            AplicarTema();
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            FrmAgregarCancion frm = new FrmAgregarCancion();
            frm.Show();
        }

        private void btnVerPlaylist_Click(object sender, EventArgs e)
        {
            FrmPlaylist frm = new FrmPlaylist();
            frm.Show();
        }

        private void btnReproductor_Click(object sender, EventArgs e)
        {
            FrmReproductor frm = new FrmReproductor();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
