using System;
using System.Collections.Generic;
using System.Text;

namespace grafos
{
    public class ListaLigada
    {
        private Nodo nodoInicial;
        private Nodo nodoActual;

        public ListaLigada(string dato = null)
        {
            nodoInicial = new Nodo(dato);
            //por definicion al no dar el enlace, la clase nodo lo hace null por ello la siguiente linea no es necesaria
            //nodoInicial.Enlace = null;
        }

        public void Relacionar(ListaLigada listaLigada) 
        {
            AgregarNodo(listaLigada.nodoInicial.Dato);
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;

            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;
            nodoNuevo.Enlace = null;

            nodoActual.Enlace = nodoNuevo;
        }
    }
}
