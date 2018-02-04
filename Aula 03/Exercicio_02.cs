/*
2 - Faça um programa em C# que apresente as opções a seguir, enquanto ele não digitar a
opção 0 (zero). De acordo com o número da opção informado, o programa deverá efetuar
a operação, solicitando as informações necessárias ao usuário. Ao final de cada operação, a
aplicação deve apresentar o resultado ao usuário.
1) Alterar texto para letras maiúsculas – Solicitar o texto ao usuário.
2) Alterar texto para letras minúsculas – Solicitar o texto ao usuário.
3) Remover todos os espaços de um texto – Solicitar o texto ao usuário.
4) Obter parte de um texto – Solicitar ao usuário o texto, a posição inicial e o número de
caracteres.
5) Substituir parte de um texto – Solicitar ao usuário o texto, a parte do texto a ser
substituída e a parte de texto substituta.
6) Verificar se um texto contém uma string – Solicitar ao usuário o texto e a string a ser
procurada.
7) Verificar se um texto inicia com uma string – Solicitar ao usuário o texto e a string a ser
procurada.
8) Verificar se um texto termina com uma string – Solicitar ao usuário o texto e a string a
ser procurada.
9) Obter o comprimento de um texto – Solicitar o texto ao usuário
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 0;
            string texto;
            string textoPesquisa;

            do
            {
                Console.WriteLine("\nSelecione a operação que deseja realizar: ");
                Console.WriteLine(" 1 - Alterar texto para letras maiúsculas \n 2 - Alterar texto para letras minúsculas \n 3 - Remover todos os espaços de um texto \n 4 - Obter parte de um texto \n 5 - Substituir parte de um texto \n 6 - Verificar se um texto contém uma string \n 7 - Verificar se um texto inicia com uma string \n 8 - Verificar se um texto termina com uma string \n 9 - Obter o comprimento de um texto \n 0 - Encerrar");
                Console.Write("Digite a opção: ");
                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("\nAlterar texto para letras maiúsculas: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.WriteLine("\nTexto original: \n   " + texto);
                        Console.WriteLine("Texto com letras maiúsculas: \n   " + texto.ToUpper());

                        break;
                    case 2:
                        Console.WriteLine("\nAlterar texto para letras minúsculas: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.WriteLine("\nTexto original: \n   " + texto);
                        Console.WriteLine("Texto com letras minúsculas: \n   " + texto.ToLower());

                        break;
                    case 3:
                        Console.WriteLine("\nRemover todos os espaços de um texto: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.WriteLine("\nTexto original: \n   " + texto);
                        Console.WriteLine("Texto com todos os espaços removidos: \n   " + texto.Replace(" ", ""));

                        break;
                    case 4:
                        Console.WriteLine("\nObter parte de um texto: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.Write("Digite a posição inicial:  ");
                        int posicaoInicial = int.Parse(Console.ReadLine());

                        Console.Write("Digite o número de caracteres:  ");
                        int numCaracteres = int.Parse(Console.ReadLine());

                        Console.WriteLine("Texto gerado: \n   " + texto.Substring(posicaoInicial, numCaracteres));

                        break;
                    case 5:
                        Console.WriteLine("\nSubstituir parte de um texto: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.Write("Digite a parte que deseja substituir:  ");
                        string parteTexto = Console.ReadLine();

                        Console.Write("Digite o novo texto:  ");
                        string novoTexto = Console.ReadLine();

                        Console.WriteLine("Texto gerado: \n   " + texto.Replace(parteTexto, novoTexto));

                        break;
                    case 6:
                        Console.WriteLine("\nVerificar se um texto contém uma string: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.Write("Digite a string a ser procurada:  ");
                        textoPesquisa = Console.ReadLine();

                        if (texto.Contains(textoPesquisa))
                        {
                            Console.WriteLine("O texto indicado contém a string " + textoPesquisa);
                        }
                        else
                        {
                            Console.WriteLine("O texto indicado não contém a string " + textoPesquisa);
                        }

                        break;
                    case 7:
                        Console.WriteLine("\nVerificar se um texto inicia com uma string: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.Write("Digite a string a ser procurada:  ");
                        textoPesquisa = Console.ReadLine();

                        if (texto.StartsWith(textoPesquisa, StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("O texto indicado inicia com a string " + textoPesquisa);
                        }
                        else
                        {
                            Console.WriteLine("O texto indicado não inicia com a string " + textoPesquisa);
                        }

                        break;
                    case 8:
                        Console.WriteLine("\nVerificar se um texto termina com uma string: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.Write("Digite a string a ser procurada:  ");
                        textoPesquisa = Console.ReadLine();

                        if (texto.EndsWith(textoPesquisa, StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("O texto indicado termina com a string " + textoPesquisa);
                        }
                        else
                        {
                            Console.WriteLine("O texto indicado não termina com a string " + textoPesquisa);
                        }

                        break;
                    case 9:
                        Console.WriteLine("\nObter o comprimento de um texto: ");

                        Console.Write("Entre com o texto:  ");
                        texto = Console.ReadLine();

                        Console.WriteLine("O tamanho do texto informado é " + texto.Length);

                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar a aplicação. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            } while (opcaoMenu != 0);

            Console.ReadKey();
        }
    }
}
