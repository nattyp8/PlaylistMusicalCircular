using PlaylistMusicalCircular.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace PlaylistMusicalCircular.Formularios
{
    public partial class FrmEditarCancion : Form
    {
        private Cancion cancionEditar;

        private string rutaArchivo;
        private string rutaImagen;

        public FrmEditarCancion(Cancion cancion)
        {
            InitializeComponent();

            cancionEditar = cancion;

            rutaArchivo = cancion.RutaArchivo;
            rutaImagen = cancion.RutaImagen;

            CargarDatos();
        }
        private void CargarDatos()
        {
            txtTitulo.Text = cancionEditar.Titulo;
            txtArtista.Text = cancionEditar.Artista;
            txtAlbum.Text = cancionEditar.Album;
            txtGenero.Text = cancionEditar.Genero;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cancionEditar.Titulo = txtTitulo.Text;
            cancionEditar.Album = txtAlbum.Text;
            cancionEditar.Artista = txtArtista.Text;
            cancionEditar.Genero = txtGenero.Text;

            cancionEditar.RutaImagen = rutaImagen;
            cancionEditar.RutaArchivo = rutaArchivo;

            MessageBox.Show("cancion editada correctamente");

            this.Close();

        }

        private void btnSeleccionarMP3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();

            abrirArchivo.Filter = "Archivos MP3 (*.mp3)|*.mp3";

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = abrirArchivo.FileName;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            abrirImagen.Filter = "Imágenes (*.jpg;*.png)|*.jpg;*.png";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrirImagen.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Quiere cancelar la edicion?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

