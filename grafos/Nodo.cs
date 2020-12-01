using System;
using System.Collections.Generic;
using System.Text;

namespace grafos
{
    public class Nodo
    {
        private string dato;

        private Nodo enlace;

        public string Dato { get => dato; set => dato = value; }
        public Nodo Enlace { get => enlace; set => enlace = value; }

        public Nodo(string dato = null, Nodo enlace = null)
        {
            this.dato = dato;
            this.enlace = enlace;
        }

    }
}
