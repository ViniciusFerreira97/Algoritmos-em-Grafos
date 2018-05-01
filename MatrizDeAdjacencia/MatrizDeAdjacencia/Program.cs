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
            int numeroVerticeAtual =0;
            MatrizDeAdjacencia matriz1;
            ListaDeAdjacencia lista1;
            int opção;
            Console.WriteLine("\t\t Seja bem vindo \n\nDigite a opção desejada \n\n[1] Matriz de adjacencia \n[2] Lista de adjacencia");
            opção = int.Parse(Console.ReadLine());
            if (opção == 1)
            {
                int x, menu;
                Console.WriteLine("Digite a quantidade de vertices");
                x = int.Parse(Console.ReadLine());
                matriz1 = new MatrizDeAdjacencia(x);
                do
                {
                    int vertice1, vertice2;
                    bool ok;
                    Console.WriteLine("[1]  Inserir arestas \n[2]  Remover arestas \n[3]  Grau de um vertice \n[4]  Verifica se grafo é completo \n[5]  Verifica se grafo é Regular \n[6]  Imprime Matriz de Adjacencia \n[7]  Sequencia de graus \n[8]  Verifica adjacencia de vertices \n[9]  Verifica se vertice é isolado \n[10] Verifica se vertice é impar \n[11] Verifica se vertice é par \n[12] Verifica se vertices são adjacentes \n[0] Sair");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja inserir aresta- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja inserir aresta- OBS: Entre 0 - " +(x - 1));
                            vertice2 = int.Parse(Console.ReadLine());
                            if (vertice1 < x && vertice2 < x)
                                matriz1.inserirArestas(vertice1, vertice2);
                            else
                                Console.WriteLine("Vertives inválidos");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja remover aresta- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja remover aresta- OBS: Entre 0 - " + (x - 1));
                            vertice2 = int.Parse(Console.ReadLine());
                            if (vertice1 < x && vertice2 < x)
                                matriz1.removerArestas(vertice1, vertice2);
                            else
                                Console.WriteLine("Vertives inválidos");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Vertice que deseja descobrir o grau- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n O grau do vertice selecionado é:  " + matriz1.grauVertice(vertice1) + "\n ");
                            break;
                        case 4:
                            Console.Clear();
                            ok = matriz1.completo();
                            if (ok == true)
                                Console.WriteLine("\n O grafo é completo\n ");
                            else
                                Console.WriteLine("\n O grafo não é completo\n ");
                            break;
                        case 5:
                            Console.Clear();
                            ok = matriz1.regular();
                            if (ok == true)
                                Console.WriteLine("\n O grafo é regular\n ");
                            else
                                Console.WriteLine("\n O grafo não é regular\n ");
                            break;
                        case 6:
                            Console.Clear();
                            matriz1.showMA();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine(matriz1.sequenciaDeGraus() + "\n");
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Qual vertice deseja verificar os vertices adjacentes");
                            vertice1 = int.Parse(Console.ReadLine());
                            matriz1.VerticesAdjacentes(vertice1);
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é isolado- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = matriz1.Isolado(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é Isolado\n ");
                            else
                                Console.WriteLine("\n O vertice não é Isolado\n ");
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é impar- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = matriz1.Impar(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é impar\n ");
                            else
                                Console.WriteLine("\n O vertice não é impar\n ");
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é par- OBS: Entre 0 - " + (x - 1));
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = matriz1.Isolado(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é par\n ");
                            else
                                Console.WriteLine("\n O vertice não é par\n ");
                            break;
                        case 12:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja verificar adjacencia");
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja verificar adjacencia");
                            vertice2 = int.Parse(Console.ReadLine());
                            ok = matriz1.Adjacentes(vertice1, vertice2);
                            if (ok == true)
                                Console.WriteLine("\n Os vertices são adjacentes\n ");
                            else
                                Console.WriteLine("\n Os vertices não são adjacentes\n ");
                            break;
                    }
                }
                while (menu != 0);
            }
            else if (opção == 2)
            {
                int menu;
                lista1 = new ListaDeAdjacencia();
                do
                {
                    int vertice1, vertice2;
                    bool ok;
                    Console.WriteLine("[1]  Inserir Vertice \n[2]  Remover Vertice \n[3]  Inserir arestas \n[4]  Remover arestas \n[5]  Grau de um vertice \n[6]  Verifica se grafo é completo \n[7]  Verifica se grafo é Regular \n[8]  Imprime Lista de Adjacencia \n[9]  Sequencia de graus \n[10] Verifica adjacencia de vertices \n[11] Verifica se vertice é isolado \n[12] Verifica se vertice é impar \n[13] Verifica se vertice é par \n[14] Verifica se vertices são adjacentes \n[0] Sair");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            lista1.InserirVertice(numeroVerticeAtual);
                            Console.WriteLine("Vertice " + numeroVerticeAtual + " inserido com sucesso");
                            numeroVerticeAtual++;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Vertice que deseja remover");
                            vertice1 = int.Parse(Console.ReadLine());
                            if (vertice1 > 0 && vertice1 < numeroVerticeAtual)
                            {
                                lista1.RemoverVertice(vertice1);
                                Console.WriteLine("Vertice " + vertice1 + " removido com sucesso");
                                numeroVerticeAtual--;
                            }
                            else
                                Console.WriteLine("Vertice inválido");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja inserir aresta");
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja inserir aresta");
                            vertice2 = int.Parse(Console.ReadLine());
                            if (vertice1 != vertice2)
                                lista1.inserirArestas(vertice1, vertice2);
                            else
                                Console.WriteLine("Não pode haver loop");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja remover aresta");
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja remover aresta");
                            vertice2 = int.Parse(Console.ReadLine());
                            lista1.removerArestas(vertice1, vertice2);
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Vertice que deseja descobrir o grau");
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("\n O grau do vertice selecionado é:  " + lista1.grauVertice(vertice1) + "\n ");
                            break;
                        case 6:
                            Console.Clear();
                            ok = lista1.completo();
                            if (ok == true)
                                Console.WriteLine("\n O grafo é completo\n ");
                            else
                                Console.WriteLine("\n O grafo não é completo\n ");
                            break;
                        case 7:
                            Console.Clear();
                            ok = lista1.regular();
                            if (ok == true)
                                Console.WriteLine("\n O grafo é regular\n ");
                            else
                                Console.WriteLine("\n O grafo não é regular\n ");
                            break;
                        case 8:
                            Console.Clear();
                            lista1.showLA();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine(lista1.sequenciaDeGraus() + "\n");
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("Qual vertice deseja verificar os vertices adjacentes");
                            vertice1 = int.Parse(Console.ReadLine());
                            lista1.VerticesAdjacentes(vertice1);
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é isolado");
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = lista1.Isolado(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é Isolado\n ");
                            else
                                Console.WriteLine("\n O vertice não é Isolado\n ");
                            break;
                        case 12:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é impar");
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = lista1.Impar(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é impar\n ");
                            else
                                Console.WriteLine("\n O vertice não é impar\n ");
                            break;
                        case 13:
                            Console.Clear();
                            Console.WriteLine("Vertice para verificar se é par");
                            vertice1 = int.Parse(Console.ReadLine());
                            ok = lista1.Isolado(vertice1);
                            if (ok == true)
                                Console.WriteLine("\n O vertice é par\n ");
                            else
                                Console.WriteLine("\n O vertice não é par\n ");
                            break;
                        case 14:
                            Console.Clear();
                            Console.WriteLine("Primeiro vertice no qual deseja verificar adjacencia");
                            vertice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Segundo vertice no qual deseja verificar adjacencia");
                            vertice2 = int.Parse(Console.ReadLine());
                            ok = lista1.Adjacentes(vertice1, vertice2);
                            if (ok == true)
                                Console.WriteLine("\n Os vertices são adjacentes\n ");
                            else
                                Console.WriteLine("\n Os vertices não são adjacentes\n ");
                            break;
                    }
                }
                while (menu !=0);
            }
        }
    }
}
