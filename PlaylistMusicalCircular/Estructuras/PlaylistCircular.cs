using System;
using System.Collections.Generic;
using System.Text;
using PlaylistMusicalCircular.Modelos;
using System.Collections.Generic;

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
    


    // METODOS

    //METODO PARA AGREGAR CANCION 
         public void AgregarCancion(Cancion nuevaCancion)
        {
            NodoCancion nuevoNodo = new NodoCancion(nuevaCancion);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;

                actual = nuevoNodo;

                nuevoNodo.Siguiente = nuevoNodo;

                nuevoNodo.Anterior = nuevoNodo;
            }
            else
            {
                NodoCancion ultimo = cabeza.Anterior;
                nuevoNodo.Siguiente = cabeza;
                nuevoNodo.Anterior = ultimo;
                ultimo.Siguiente = nuevoNodo;
                cabeza.Anterior = nuevoNodo;
            }

            cantidad++;
        }

        //METODO OBTENER CANCION ACTUAL
        public Cancion ObtenerCancionActual()
        {
            if (actual==null)
            {
                return null;
            }

            return actual.Datos;
        }

        //METODO PARA LA SIGUIENTE CANCION

        public void Siguiente()
        {
            if(actual != null)
            {
                actual = actual.Siguiente;
            }
        }

        //METODO PARA LA CANCION ACTUAL
        public void Anterior()
        {
            if (actual != null)
            {
                actual = actual.Anterior;
            }
        }

        //METODO PARA CANTIDAD DE CANCIONES
        public int CantidadCanciones()
        {
            return cantidad;
        }

        //METODO PARA BUSCAR CANCIONES
        public Cancion BuscarCancion(string titulo)
        {

            if (cabeza == null)
            {
                return null;
            }

            NodoCancion aux = cabeza;

            do
            {
                if (aux.Datos.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return aux.Datos;
                }

                aux = aux.Siguiente;
            } while (aux != cabeza);

            return null;

        }

        // METODO PARA TRAER TODAS LAS CANCIONES

        public List<Cancion> ObtenerTodas()
        {
            List<Cancion> canciones = new List<Cancion>();

            if (cabeza == null)
            {
                return canciones;
            }

            NodoCancion aux = cabeza;

            do
            {
                canciones.Add(aux.Datos);
                aux = aux.Siguiente;
            } while (aux != cabeza);
            return canciones;
            
        }

    }
}

