using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0, posicao = 0;
            string valorElemento;
            Lista lista = new Lista(); 

            do
            {
                Console.Write("Selecione a opção que deseja realizar:\n 1 - Adicionar elemento\n 2 - Remover elemento (pelo valor)\n 3 - Remover elemento (pela posição) \n 4 - Inserir elemento em posição específica \n 5 - Ordenar lista \n 6 - Imprimir lista \n 0 - Sair \nDigite: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    opcao = -1; //mensagem de opcao inválida
                }

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Adicionar elemento");
                        Console.Write("Digite o elemento que deseja adicionar à lista: ");
                        valorElemento = Console.ReadLine();
                        lista.addElemento(valorElemento);
                        Console.WriteLine("Elemento adicionado.");
                        break;
                    case 2:
                        Console.WriteLine("Remover elemento (pelo valor)");
                        Console.Write("Digite o elemento que deseja remover da lista: ");
                        valorElemento = Console.ReadLine();
                        try
                        {
                            lista.removerElementoPorValor(valorElemento);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Remover elemento (pela posição)");
                        Console.Write("Digite a posição do elemento que deseja remover da lista: ");
                        try
                        {
                            posicao = int.Parse(Console.ReadLine());
                            lista.removerElementoPorPosicao(posicao);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Inserir elemento em posição específica");
                        Console.Write("Digite o elemento que deseja adicionar à lista: ");
                        valorElemento = Console.ReadLine();

                        Console.Write("Digite a posição do elemento que deseja adicionar à lista: ");
                        try
                        {
                            posicao = int.Parse(Console.ReadLine());
                            lista.addElementoEmPosicao(posicao, valorElemento);
                            Console.WriteLine("Elemento adicionado.");
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ordenar lista");
                        lista.ordenarLista();
                        break;
                    case 6:
                        Console.WriteLine("Imprimir lista");
                        lista.imprimirLista();
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu sair. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
