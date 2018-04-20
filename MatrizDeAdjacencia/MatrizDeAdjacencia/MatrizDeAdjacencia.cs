using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDeAdjacencia
{
    class MatrizDeAdjacencia
    {
        private int[,] MA;
        public MatrizDeAdjacencia(int x)
        {
            MA = new int[x, x];
            for(int i = 0; i<x;i++)
            {
                for(int j = 0; j<x; j++)
                {
                    MA[i, j] = 0;
                }
            }
        }
        private int grauVertice(int v)
        {
            int grau = 0;
            for(int i=0; i<MA.GetLength(1); i++)
            {
                if (MA[v, i] == 1)
                    grau++;
            }
            return grau;
        }
        private void inserirArestas(int x, int y)
        {
            MA[x, y] = 1;
            MA[y, x] = 1;
        }
        private void removerArestas(int x, int y)
        {
            MA[x, y] = 0;
            MA[y, x] = 0;
        }
        private bool completo()
        {
            int aux = MA.GetLength(0);
            int qtdArestas = 0;
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                for (int j = 0; j < MA.GetLength(1); j++)
                {
                    if(i != j)
                    {
                        if (MA[i, j] == 1)
                            qtdArestas++;
                    }
                }
            }
            if (qtdArestas / 2 == aux)
                return true;
            else
                return false;
        }
    }

}
