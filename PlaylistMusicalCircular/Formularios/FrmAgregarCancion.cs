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
        private string rutaArchivo = "";
        private string rutaImagen = "";
        public FrmAgregarCancion()
        {
            InitializeComponent();
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
            abrirImagen.Filter = "Imagenes (*.jpg; *.png) | *.jpg; .*png";
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
                    txtGenero.Text,
                    TimeSpan.Parse(txtDuracion.Text),
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
            txtGenero.Clear();
            txtDuracion.Clear();

            rutaArchivo = "";
            rutaImagen = "";

        }
    }
}
