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
    public partial class FrmReproductor : Form
    {
        public FrmReproductor()
        {
            InitializeComponent();
            MostrarCancionActual();
        }

        private void MostrarCancionActual()
        {
            Cancion? actual = GestorPlaylist.Playlist.ObtenerCancionActual();

            if (actual != null)
            {

                lblTituloCancion.Text = actual.Titulo;
                lblArtista.Text = actual.Artista;

                if (!string.IsNullOrEmpty(actual.RutaImagen))
                {
                    pbPortada.Image = Image.FromFile(actual.RutaImagen);
                }
                else
                {
                    pbPortada.Image = null;
                }
            }
            else
            {
                lblTituloCancion.Text = "No hay Canciones, agrege canciones para escuchar";
                lblArtista.Text = " ";
                pbPortada.Image = null;
            }
        }

        //boton anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            GestorPlaylist.Playlist.Anterior();
            MostrarCancionActual();
        }

        //boton siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            GestorPlaylist.Playlist.Siguiente();
            MostrarCancionActual();
        }

        

    }
}
