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
        public int grauVertice(int v) // Retorna grau do vertice solicitado
        {
            int grau = 0;
            for(int i=0; i<MA.GetLength(1); i++)
            {
                if (MA[v, i] == 1)
                    grau++;
            }
            return grau;
        }
        public void inserirArestas(int x, int y) //insere aresta
        {
            MA[x, y] = 1;
            MA[y, x] = 1;
        }
        public void removerArestas(int x, int y)//remove aresta
        {
            MA[x, y] = 0;
            MA[y, x] = 0;
        }
        public bool completo() //retorna se grafo é completo
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
        public bool Isolado(int v) //verifica se vertice é isolado
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
        public bool Impar(int v) //verifica se vertice é impar
        {
            int aux = 0;
            aux = grauVertice(v);
            if (aux % 2 == 1)
                return true;
            else
                return false;
        }

        public bool Par(int v) //verifica se vertive é par
        {
            int aux = 0;
            aux = grauVertice(v);
            if (aux % 2 == 0)
                return true;
            else
                return false;
        }
        public void VerticesAdjacentes(int v) //Verifica vertices adjacentes ao vertice informado
        {
            Console.Write("Vertices Adjacentes ao vertice " + v+":  ");
            for(int i=0; i < MA.GetLength(1); i ++)
            {
                if (MA[v, i] == 1)
                    Console.Write(i +"  ");
            }
            Console.WriteLine("\n");
        }
        public bool Adjacentes(int x, int y) //verifica vertices adjacentes
        {
            if (MA[x, y] == 1)
                return true;
            else
                return false;
        }
        public bool regular() //veifica se grafo é regula
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
        public string sequenciaDeGraus() // retorna sequencia de graus
        {
            int aux;
            string x = " ";
            int[] grausVertices = new int[MA.GetLength(0)];
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                grausVertices[i] = grauVertice(i);
            }
            for (int i = 0; i < grausVertices.Length; i++)
            {
                for (int j = i + 1; j < grausVertices.Length; j++)
                {
                    if (grausVertices[i] > grausVertices[j])
                    {
                        aux = grausVertices[i];
                        grausVertices[i] = grausVertices[j];
                        grausVertices[j] = aux;
                    }
                }
            }
            for (int i = 0; i < grausVertices.Length; i++)
            {
                x += grausVertices[i] + "   ";
            }
            return x;
        }
        public void showMA() //imprime Matriz de adjacencia
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
        public void showLA() //imprime lista de adjacencia
        {
            for (int i = 0; i < MA.GetLength(0); i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < MA.GetLength(0); j++)
                {
                    if (MA[i, j] == 1)
                        Console.Write(j + "\t");
                    else
                        Console.Write("");
                }
                Console.WriteLine("\n");
            }
        }
        public void Preencher(int x) //Prencher matriz caso remova vertice
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
        public void ExcluirVertice(int x, int y) //excluir vertice
        {
            int[,] m1 = new int[x, x];
            for (int i = 0; i < MA.GetLength(0) && i != x; i++)
            {
                for (int j = 0; j < MA.GetLength(0)-1; j++)
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
