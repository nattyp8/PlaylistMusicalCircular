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
    public partial class FrmAgregarCancion : Form
    {
        //guardar las rutas del mp3 seleccionado y de la portada (antes del constructor
        //pq tiene que ser visible para todos los metodos del formulario)

        private void AplicarTema()
        {
            Color rosa = ColorTranslator.FromHtml("#EFCEDB");
            Color marron = ColorTranslator.FromHtml("#4F2B1F");

            // Formulario
            this.BackColor = rosa;

            // Labels
            lblTitulo.ForeColor = marron;
            lblArtisita.ForeColor = marron;
            lblAlbum.ForeColor = marron;
            lbltitulobienvenida.ForeColor = marron;

            // TextBox
            txtTitulo.BackColor = Color.White;
            txtTitulo.ForeColor = marron;

            txtArtista.BackColor = Color.White;
            txtArtista.ForeColor = marron;

            txtAlbum.BackColor = Color.White;
            txtAlbum.ForeColor = marron;

            // Botón seleccionar MP3
            btnSeleccionarMP3.BackColor = marron;
            btnSeleccionarMP3.ForeColor = rosa;
            btnSeleccionarMP3.FlatStyle = FlatStyle.Flat;
            btnSeleccionarMP3.FlatAppearance.BorderSize = 0;

            // Botón seleccionar imagen
            btnSeleccionarImagen.BackColor = marron;
            btnSeleccionarImagen.ForeColor = rosa;
            btnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            btnSeleccionarImagen.FlatAppearance.BorderSize = 0;

            // Botón guardar
            bntGuardar.BackColor = marron;
            bntGuardar.ForeColor = rosa;
            bntGuardar.FlatStyle = FlatStyle.Flat;
            bntGuardar.FlatAppearance.BorderSize = 0;

            // Botón cancelar
            btnCancelar.BackColor = marron;
            btnCancelar.ForeColor = rosa;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
        }

        private string rutaArchivo = "";
        private string rutaImagen = "";
        public FrmAgregarCancion()
        {
            InitializeComponent();
            AplicarTema();
        }

        private void btnSeleccionarMP3_Click(object sender, EventArgs e)
        {
            //abrir ventana para elegir el archivo
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            //filtro para que solo se muestre archivos mp3
            abrirArchivo.Filter = "Archivo MP3 (*.mp3) | *.mp3";
            //titulo de la ventana
            abrirArchivo.Title = "Seleccionar cancion";

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                //guardar la ruta del archivo que se selecciono
                rutaArchivo = abrirArchivo.FileName;

                MessageBox.Show("Cancion seleccionada correctamente");
            }


        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Imagenes (*.jpg; *.png) | *.jpg; *.png";
            abrirImagen.Title = "Seleccionar imagen de portada";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrirImagen.FileName;

                MessageBox.Show("Imagen de portada seleccionada correctamente");
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            //crear una nueva cancion con los datos del formulario
            Cancion nuevaCancion = new Cancion
                (
                    txtTitulo.Text,
                    txtArtista.Text,
                    txtAlbum.Text,
                    rutaArchivo,
                    rutaImagen
                );

            //agregar esa cancion a la playlist
            GestorPlaylist.Playlist.AgregarCancion(nuevaCancion);

            //mensaje de que se cargo bien
            MessageBox.Show("Cancion agregada correctamente");

            //limpiar los textboxs y rutas para los sgtes
            txtTitulo.Clear();
            txtArtista.Clear();
            txtAlbum.Clear();

            rutaArchivo = "";
            rutaImagen = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Desea terminar de agregar canciones?",
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
