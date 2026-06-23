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

        private void AplicarTema()
        {
            Color rosa = ColorTranslator.FromHtml("#EFCEDB");
            Color marron = ColorTranslator.FromHtml("#4F2B1F");

            // Fondo
            this.BackColor = rosa;

            lblbienvenida.ForeColor = marron;
            lblAlbum.ForeColor = marron;
            lblArtisita.ForeColor = marron;
            lblTitulo.ForeColor = marron;


            // Labels
            txtTitulo.ForeColor = marron;
            txtArtista.ForeColor = marron;
            txtAlbum.ForeColor = marron;

            // TextBox
            txtTitulo.BackColor = Color.White;
            txtTitulo.ForeColor = marron;

            txtArtista.BackColor = Color.White;
            txtArtista.ForeColor = marron;

            txtAlbum.BackColor = Color.White;
            txtAlbum.ForeColor = marron;

            // Botón Guardar
            btnGuardar.BackColor = marron;
            btnGuardar.ForeColor = rosa;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;


            // Botón Cancelar
            btnCancelar.BackColor = marron;
            btnCancelar.ForeColor = rosa;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;

            // Botón MP3
            btnSeleccionarMP3.BackColor = marron;
            btnSeleccionarMP3.ForeColor = rosa;
            btnSeleccionarMP3.FlatStyle = FlatStyle.Flat;
            btnSeleccionarMP3.FlatAppearance.BorderSize = 0;

            // Botón Imagen
            btnSeleccionarImagen.BackColor = marron;
            btnSeleccionarImagen.ForeColor = rosa;
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
        }
        private Cancion cancionEditar;

        private string rutaArchivo;
        private string rutaImagen;

        public FrmEditarCancion(Cancion cancion)
        {
            InitializeComponent();

            AplicarTema();

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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cancionEditar.Titulo = txtTitulo.Text;
            cancionEditar.Album = txtAlbum.Text;
            cancionEditar.Artista = txtArtista.Text;

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

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

