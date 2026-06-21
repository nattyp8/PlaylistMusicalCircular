using PlaylistMusicalCircular.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlaylistMusicalCircular.Formularios
{
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();

            CargarPlaylist();
        }

        private void CargarPlaylist()
        {
            //mostrar todas las canciones en el datagridview
            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = GestorPlaylist.Playlist.ObtenerTodas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPlaylist();
        }

    }
}
