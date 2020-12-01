using System;
using System.Collections.Generic;

namespace grafos
{
    class Program
    {
        static void Main(string[] args)
        {

            ////A,B,C,D

            ////Vertical
            List<ListaLigada> Grafo = new List<ListaLigada>();

            //Horizontal
            ListaLigada verticeA = new ListaLigada("A");
;
            ListaLigada verticeE = new ListaLigada("E");

            ListaLigada verticeI = new ListaLigada("I");

            ListaLigada verticeO = new ListaLigada("O");

            ListaLigada verticeU = new ListaLigada("U");


            //Relacionar nodos
            verticeA.Relacionar(verticeE);
            verticeA.Relacionar(verticeI);
            verticeE.Relacionar(verticeO);
            verticeI.Relacionar(verticeU);
            verticeO.Relacionar(verticeI);
            verticeO.Relacionar(verticeI);
            verticeU.Relacionar(verticeA);
            verticeU.Relacionar(verticeO);

            Grafo.Add(verticeA);
            Grafo.Add(verticeE);
            Grafo.Add(verticeI);
            Grafo.Add(verticeO);
            Grafo.Add(verticeU);

            Console.ReadKey();

        }
    }
}
