using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0, posicaoElemento;
            string valorElemento, elementoReferencia;
            ListaEncadeada lista = new ListaEncadeada();

            do
            {
                Console.WriteLine("Selecione a opção que deseja realizar:");
                Console.WriteLine("1 - Adicionar elemento no início da lista");
                Console.WriteLine("2 - Adicionar elemento no final da lista");
                Console.WriteLine("3 - Adicionar elemento após um nó específico");
                Console.WriteLine("4 - Adicionar elemento antes de um nó específico");
                Console.WriteLine("5 - Verificar existência de elemento");
                Console.WriteLine("6 - Remover elemento (pelo valor)");
                Console.WriteLine("7 - Remover elemento (pela posição)");
                Console.WriteLine("8 - Remover o 1º elemento da lista");
                Console.WriteLine("9 - Remover o último elemento da lista");
                Console.WriteLine("10 - Remover todos elementos da lista");
                Console.WriteLine("11 - Imprimir lista do início para o fim");
                Console.WriteLine("12 - Imprimir lista do fim para o início");
                Console.Write("Digite: ");

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
                        Console.WriteLine("Adicionar elemento no início da lista");
                        Console.Write("Digite o elemento que deseja adicionar à lista: ");
                        valorElemento = Console.ReadLine();
                        lista.addElementoInicio(valorElemento);
                        break;
                    case 2:
                        Console.WriteLine("Adicionar elemento no fim da lista");
                        Console.Write("Digite o elemento que deseja adicionar à lista: ");
                        valorElemento = Console.ReadLine();
                        lista.addElementoFim(valorElemento);
                        break;
                    case 3:
                        Console.WriteLine("Adicionar elemento após um nó específico");
                        try
                        {
                            Console.Write("Digite a posição do elemento que deseja adicionar à lista: ");
                            valorElemento = Console.ReadLine();

                            Console.Write("Digite após qual elemento deseja adicionar este valor: ");
                            elementoReferencia = Console.ReadLine();

                            lista.addElementoAposNo(elementoReferencia, valorElemento);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Adicionar elemento antes de um nó específico");
                        try
                        {
                            Console.Write("Digite a posição do elemento que deseja adicionar à lista: ");
                            valorElemento = Console.ReadLine();

                            Console.Write("Digite antes de qual elemento deseja adicionar este valor: ");
                            elementoReferencia = Console.ReadLine();

                            lista.addElementoAntesNo(elementoReferencia, valorElemento);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Verificar existência de elemento");
                        Console.Write("Digite o elemento que deseja verificar na lista: ");
                        valorElemento = Console.ReadLine();
                        lista.verificarElemento(valorElemento);
                        break;
                    case 6:
                        Console.WriteLine("Remover elemento (pelo valor)");
                        Console.Write("Digite o elemento que deseja remover na lista: ");
                        valorElemento = Console.ReadLine();
                        try
                        {
                            lista.removerElementoPeloValor(valorElemento);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Remover elemento (pela posição)");
                        Console.Write("Digite a posição do elemento que deseja remover na lista: ");

                        try
                        {
                            posicaoElemento = int.Parse(Console.ReadLine());
                            lista.removerElementoPelaPosicao(posicaoElemento);
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
                    case 8:
                        Console.WriteLine("Remover o 1º elemento da lista");
                        try
                        {
                            lista.removerPrimeiroElemento();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 9:
                        Console.WriteLine("Remover o último elemento da lista");
                        try
                        {
                            lista.removerUltimoElemento();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 10:
                        Console.WriteLine("Remover todos os elementos da lista");
                        try
                        {
                            lista.removerTodosElementos();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 11:
                        Console.WriteLine("Imprimir lista do início para o fim");
                        lista.imprimirInicioParaFim();
                        Console.WriteLine("");
                        break;
                    case 12:
                        Console.WriteLine("Imprimir lista do fim para o início");
                        lista.imprimirFimParaInicio();
                        Console.WriteLine("");
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
