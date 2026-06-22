using System;
using System.Collections.Generic;
using System.Text;

namespace PlaylistMusicalCircular.Modelos
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public TimeSpan Duracion { get; set; } = TimeSpan.Zero;
        public string RutaArchivo { get; set; }
        public string RutaImagen { get; set; }

        //constructores
        public Cancion(string titulo, string artista, string album,
                        string rutaArchivo, string rutaImagen)
        {
            Titulo = titulo;
            Artista = artista;
            Album = album;
            Duracion = TimeSpan.Zero;
            RutaArchivo = rutaArchivo;
            RutaImagen = rutaImagen;
        }
    }
}
