using PlaylistMusicalCircular.Estructuras;
using PlaylistMusicalCircular.Modelos;
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

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            Cancion? encontrada = GestorPlaylist.Playlist.BuscarCancion(txtBuscar.Text);
                if (encontrada != null)
            {
                MessageBox.Show
                    (
                        "titulo: " + encontrada.Titulo +
                    "\n Artista: " + encontrada.Artista
                    );

            }
            else
            {
                MessageBox.Show("Cancion no encontrada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //verificar si existe fila seleccionada
            if (dgvPlaylist.CurrentRow != null)
            {
                //obtener titulo de la fila
                string titulo = dgvPlaylist.CurrentRow.Cells["Titulo"].Value.ToString();

                //eliminar
                if (GestorPlaylist.Playlist.EliminarCancion(titulo))
                {
                    MessageBox.Show("Cancion Eliminada");
                    //actualizar la tabla donde se muestr
                    CargarPlaylist();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
            }
        }
    }
}
