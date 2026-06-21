using System;
using System.Collections.Generic;
using System.Text;

namespace PlaylistMusicalCircular.Modelos
{
    public class NodoCancion
    {
        public Cancion Datos { get; set; }
        public  NodoCancion? Siguiente { set; get; }
        public NodoCancion? Anterior { get; set; }

        //constructores

        public NodoCancion(Cancion datos)
        {
            Datos = datos;
            Siguiente = null; // al principio tdv no existe siguiente nodo
            Anterior = null; // al principio tampoco no existe nodo anterior
        }
    }
}
