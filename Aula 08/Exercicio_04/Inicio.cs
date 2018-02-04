using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valorElemento;
            Pilha pilha = new Pilha(); 

            do
            {
                Console.Write("Selecione a opção que deseja realizar:\n 1 - Adicionar elemento à pilha\n 2 - Remover elemento da pilha\n 3 - Imprimir pilha \n 0 - Sair \nDigite: ");
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
                        Console.WriteLine("Adicionar elemento à pilha");
                        Console.Write("Digite o elemento que deseja adicionar à pilha: ");
                        valorElemento = Console.ReadLine();
                        pilha.empilhar(valorElemento);
                        Console.WriteLine("O elemento foi adicionado à pilha. ");
                        break;
                    case 2:
                        Console.WriteLine("Remover elemento da pilha");
                        pilha.desempilhar();
                        break;
                    case 3:
                        Console.WriteLine("Imprimir pilha");
                        pilha.imprimirPilha();
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
