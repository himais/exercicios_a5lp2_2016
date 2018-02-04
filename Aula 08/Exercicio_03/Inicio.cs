using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valorElemento;
            Fila fila = new Fila();            

            do
            {
                Console.Write("Selecione a opção que deseja realizar:\n 1 - Adicionar elemento à fila\n 2 - Remover elemento da fila\n 3 - Imprimir fila \n 0 - Sair \nDigite: ");
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
                        Console.WriteLine("Adicionar elemento à fila");
                        Console.Write("Digite o elemento que deseja adicionar ao final da fila: ");
                        valorElemento = Console.ReadLine();
                        fila.enfileirar(valorElemento);
                        Console.WriteLine("O elemento foi adicionado à fila. ");
                        break;
                    case 2:
                        Console.WriteLine("Remover elemento da fila");
                        fila.desenfileirar();
                        break;
                    case 3:
                        Console.WriteLine("Imprimir fila");
                        fila.imprimirFila();
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu sair. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }

                Console.WriteLine("");
            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
