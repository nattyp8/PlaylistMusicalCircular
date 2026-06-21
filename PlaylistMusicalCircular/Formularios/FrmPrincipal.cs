using PlaylistMusicalCircular.Formularios;

namespace PlaylistMusicalCircular
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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
    }
}
