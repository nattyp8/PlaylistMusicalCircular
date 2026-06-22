using PlaylistMusicalCircular.Estructuras;
using PlaylistMusicalCircular.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace PlaylistMusicalCircular.Formularios
{
    public partial class FrmReproductor : Form
    {
        private WindowsMediaPlayer reproductor = new WindowsMediaPlayer();
        private bool reproduciendo = false;
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
        
        private void ReproducirCancionActual()
        {
            Cancion? actual = GestorPlaylist.Playlist.ObtenerCancionActual();

            if (actual != null)
            {
                reproductor.controls.stop();
                reproductor.URL = actual.RutaArchivo;
                reproductor.controls.play();
                btnReproducir.Text = "⏸";
                reproduciendo = true;
            }
        }



        //boton anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            GestorPlaylist.Playlist.Anterior();

            MostrarCancionActual();

            if (reproduciendo)
            {
                ReproducirCancionActual();
            }
        }

        //boton siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            GestorPlaylist.Playlist.Siguiente();

            MostrarCancionActual();

            if (reproduciendo)
            {
                ReproducirCancionActual();
            }

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            Cancion? actual = GestorPlaylist.Playlist.ObtenerCancionActual();
             
            if (actual != null)
            {
                if (!reproduciendo)
                {
                    ReproducirCancionActual();
                }
                else
                {
                    reproductor.controls.pause();
                    btnReproducir.Text= "▶";

                    reproduciendo = false;
                }
            }
        }
    }
}
