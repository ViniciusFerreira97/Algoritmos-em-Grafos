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
        public int GetqtdVertice()
        {
            return MA.GetLength(0);
        }
        public int grauVertice(int v)
        {
            int grau = 0;
            for(int i=0; i<MA.GetLength(1); i++)
            {
                if (MA[v, i] == 1)
                    grau++;
            }
            return grau;
        }
        public void inserirArestas(int x, int y)
        {
            MA[x, y] = 1;
            MA[y, x] = 1;
        }
        public void removerArestas(int x, int y)
        {
            MA[x, y] = 0;
            MA[y, x] = 0;
        }
        public bool completo()
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
        public bool Isolado(int v)
        {
            int cont = 0;
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                if (MA[v, i] == 0)
                    cont++;
            }
            if (cont == 0)
                return true;
            else return false;
        }
        public bool Impar(int v)
        {
            int aux = 0;
            for (int i = 0; i < MA.GetLength(1); i++)
            {
                if (MA[v, i] == 1)
                    aux++;
            }
            if (aux % 2 == 1)
                return true;
            else
                return false;
        }

        public bool Par(int v)
        {
            int aux = 0;
            for (int i = 0; i < MA.GetLength(1); i++)
            {
                if (MA[v, i] == 1)
                    aux++;
            }
            if (aux % 2 == 0)
                return true;
            else
                return false;
        }
        public bool Adjacentes(int x, int y)
        {
            if (MA[x, y] == 1)
                return true;
            else
                return false;
        }
        public bool regular()
        {
            bool verificação = true;
            int aux = 0;
            int[] grausVertices = new int[MA.GetLength(0)];
            for(int i=0; i < MA.GetLength(0); i++)
            {
                grausVertices[i] = grauVertice(i);
            }
            for (int i = 1; i < grausVertices.Length && verificação == true; i++)
            {
                if (grausVertices[aux] == grausVertices[i])
                    verificação = true;
                else
                    verificação = false;
            }
            return verificação;
        }
        public void showMA()
        {
            for(int i=0; i<MA.GetLength(0); i++)
            {
                for(int j=0;j<MA.GetLength(1);j++)
                {
                    Console.Write(MA[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public void Preencher(int x)
        {
            int [,] m1 = new int[x,x];
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                for (int j = 0; j < MA.GetLength(0); j++)
                {
                    m1[i, j] = MA[i, j];
                }
            }
            MA = new int[m1.GetLength(0), m1.GetLength(0)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    MA[i, j] = m1[i, j];
                }
            }
        }
        public void ExcluirVertice(int x, int y)
        {
            int[,] m1 = new int[x, x];
            for (int i = 0; i < MA.GetLength(0) && i != x; i++)
            {
                for (int j = 0; j < MA.GetLength(0); j++)
                {
                    m1[i, j] = MA[i, j];
                }
            }
            MA = new int[m1.GetLength(0), m1.GetLength(0)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    MA[i, j] = m1[i, j];
                }
            }
        }
    }

}
