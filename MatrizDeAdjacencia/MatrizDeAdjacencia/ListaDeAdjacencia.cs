using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDeAdjacencia
{
    class ListaDeAdjacencia
    {
        MatrizDeAdjacencia Atual;
        ArrayList LA;
        public ListaDeAdjacencia()
        {
            LA = new ArrayList();
            Atual = new MatrizDeAdjacencia(LA.Count);
        }
        public void InserirVertice(int vertice)
        {
            LA.Add(vertice);
            Atual.Preencher(LA.Count);
        }
        public void RemoverVertice(int vertice)
        {
            LA.Remove(vertice);
            Atual.ExcluirVertice(LA.Count, vertice);
        }
        public int grauVertice(int v)
        {
            return Atual.grauVertice(v);
        }
        public void inserirArestas(int x, int y)
        {
            Atual.inserirArestas(x, y);
        }
        public void removerArestas(int x, int y)
        {
            Atual.removerArestas(x, y);
        }
        public bool completo()
        {
            return Atual.completo();
        }
        public bool Isolado(int v)
        {
            return Atual.Isolado(v);
        }
        public bool Impar(int v)
        {
            return Atual.Impar(v);
        }
        public bool Par(int v)
        {
            return Atual.Par(v);
        }
        public bool Adjacentes(int x, int y)
        {
            return Atual.Adjacentes(x, y);
        }
        public bool regular()
        {
            return Atual.regular();
        }
    }
}
