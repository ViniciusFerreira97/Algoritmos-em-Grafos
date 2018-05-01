using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDeAdjacencia
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrizDeAdjacencia matriz1;
            int opção;
            Console.WriteLine("\t\t Seja bem vindo \n\nDigite a opção desejada \n\n[1] Matriz de adjacencia \n[2] Lista de adjacencia");
            opção = int.Parse(Console.ReadLine());
            if(opção == 1)
            {
                int x, menu;
                Console.WriteLine("Digite a quantidade de vertices");
                x = int.Parse(Console.ReadLine());
                matriz1 = new MatrizDeAdjacencia(x);
                do
                {
                    Console.WriteLine("[1]  Inserir arestas \n[2]  Remover arestas \n[3]  Grau de um vertice \n[4]  Verifica se grafo é completo \n[5]  Verifica se grafo é Regular \n[6]  Imprime Matriz de Adjacencia \n[7]  Sequencia de graus \n[8]  Verifica adjacencia de vertices \n[9]  Verifica se vertice é isolado \n[10] Verifica se vertice é impar \n[11] Verifica se vertice é par \n[12] Verifica se vertices são adjacentes");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            int vertice1, vertice2;
                            Console.WriteLine("Primeiro vertices no qual deseja inserir aresta- OBS: Entre 0 - " + x);
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Primeiro vertices no qual deseja inserir aresta- OBS: Entre 0 - " + x);
                            vertice2 = int.Parse(Console.ReadLine());
                            matriz1.inserirArestas(vertice1, vertice2);
                            break;
                    }
                }
                while (opção == 1);
            }
            Console.ReadKey();
        }
    }
}
