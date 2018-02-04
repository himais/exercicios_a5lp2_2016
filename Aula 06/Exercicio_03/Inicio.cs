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
            int opcao;
            string texto, arg1, arg2;

            do
            {
                Console.Write("Escolha uma opção: \n 1 - Informar Texto \n 2 - Extrair string \n 3 - Substituir string\n 0 - Sair\nDigite: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informar Texto: ");

                        Console.Write("Digite o texto: ");
                        texto = Console.ReadLine();

                        Texto txt = new Extracao(texto);                        
                        break;
                    case 2:
                        Console.WriteLine("Digite a posição inicial: ");
                        arg1 = Console.ReadLine();

                        Console.WriteLine("Digite o número de caracteres: ");
                        arg2 = Console.ReadLine();

                        Extracao extracao = new Extracao(arg1, arg2);
                        break;
                    case 3:
                        Console.WriteLine("Digite a string para substituir: ");
                        arg1 = Console.ReadLine();

                        Console.WriteLine("Digite a nova string: ");
                        arg2 = Console.ReadLine();

                        Substituicao substituicao = new Substituicao(arg1, arg2);
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar a aplicação. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
