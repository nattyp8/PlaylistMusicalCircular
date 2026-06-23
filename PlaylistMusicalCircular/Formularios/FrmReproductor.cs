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

        private void AplicarTema()
        {
            // Fondo principal
            this.BackColor = ColorTranslator.FromHtml("#4F2B1F");

            // Titulo canción
            lblTituloCancion.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            lblTituloCancion.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            // Artista
            lblArtista.ForeColor = ColorTranslator.FromHtml("#EFCEDB");
            lblArtista.Font = new Font("Segoe UI", 11);

            // Tiempo
            lblTiempo.ForeColor = ColorTranslator.FromHtml("#EFCEDB");

            // Botón reproducir
            btnReproducir.BackColor = ColorTranslator.FromHtml("#EFCEDB");
            btnReproducir.ForeColor = ColorTranslator.FromHtml("#4F2B1F");
            btnReproducir.FlatStyle = FlatStyle.Flat;

            // Botón siguiente
            btnSiguiente.BackColor = ColorTranslator.FromHtml("#EFCEDB");
            btnSiguiente.ForeColor = ColorTranslator.FromHtml("#4F2B1F");
            btnSiguiente.FlatStyle = FlatStyle.Flat;

            // Botón anterior
            btnAnterior.BackColor = ColorTranslator.FromHtml("#EFCEDB");
            btnAnterior.ForeColor = ColorTranslator.FromHtml("#4F2B1F");
            btnAnterior.FlatStyle = FlatStyle.Flat;

            // Barra de progreso
            trackBarProgreso.BackColor = ColorTranslator.FromHtml("#4F2B1F");

            // Portada
            pbPortada.BorderStyle = BorderStyle.FixedSingle;
        }
        public FrmReproductor()
        {
            InitializeComponent();
            AplicarTema();
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
                timerProgreso.Start();
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
                    btnReproducir.Text = "▶";

                    reproduciendo = false;

                    timerProgreso.Stop();
                }
            }
        }

        private void trackBarProgreso_Scroll(object sender, EventArgs e)
        {

        }

        private void timerProgreso_Tick(object sender, EventArgs e)
        {
            //verificar que exista cancion cargada 
            if (reproductor.currentMedia != null)
            {
                //duracion actual
                double posicionActual = reproductor.controls.currentPosition;

                //duraciona total de la cancion
                double duracionTotal = reproductor.currentMedia.duration;

                if (duracionTotal > 0)
                {
                    //calcular porcentaje reproducido
                    trackBarProgreso.Value = (int)(posicionActual * 100 / duracionTotal);

                    //actualiza el tiempo mostrado 
                    lblTiempo.Text = TimeSpan.FromSeconds(posicionActual).ToString(@"mm\:ss") + "/" +
                        TimeSpan.FromSeconds(duracionTotal).ToString(@"mm\:ss");

                    // Si la canción está por terminar
                    if (duracionTotal - posicionActual < 1)
                    {
                        GestorPlaylist.Playlist.Siguiente();

                        MostrarCancionActual();

                        ReproducirCancionActual();
                    }
                }
            }
        }

        private void FrmReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            reproductor.controls.stop();
        }

        private void pbPortada_Click(object sender, EventArgs e)
        {

        }
    }
}
