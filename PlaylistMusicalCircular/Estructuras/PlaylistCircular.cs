using System;
using System.Collections.Generic;
using System.Text;
using PlaylistMusicalCircular.Modelos;

namespace PlaylistMusicalCircular.Estructuras
{
    public class PlaylistCircular
    {
        private NodoCancion cabeza { get; set; }
        private NodoCancion actual { get; set; }
        private int cantidad { get; set; }
        
        //constructor

        public PlaylistCircular ()
        {
            cabeza = null; //playlist comienza vacia entonces no hay cabeza

            actual = null; //playlist vacia no hay cancion actual

            cantidad = 0; // inicialmente hay 0 canciones 
        }
    }
}
