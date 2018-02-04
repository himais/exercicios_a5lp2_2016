/*
4 - Faça um programa em C# que apresente ao usuário as opções a seguir, enquanto ele não
digitar a opção 0 (zero). De acordo com o número da opção informada, o programa deverá
efetuar a operação, solicitando uma cadeia de caracteres ao usuário.
1) Informar texto – Deverá chamar o método SetTexto(string texto) da classe Pesquisa.
2) Buscar string – Deverá chamar o método virtual BuscarString(string cadeiaCaracteres)
da classe Pesquisa, que retornará se a cadeia de caracteres procurada existe ou não no
texto.
3) Buscar string no início – Deverá chamar o método sobrescrito BuscarString(string
cadeiaCaracteres) da classe PesquisaInicio, filha da classe Pesquisa, que retornará se a
cadeia de caracteres procurada existe ou não no início do texto. Configure este método
para que não possa ser sobrescrito novamente em uma eventual classe filha da classe
PesquisaInicio.
4) Buscar string no fim – Deverá chamar o método sobrescrito BuscarString(string
cadeiaCaracteres) da classe PesquisaFim, filha da classe Pesquisa, que retornará se a
cadeia de caracteres procurada existe ou não no final do texto. Configure este método
para que não possa ser sobrescrito novamente em uma eventual classe filha da classe
PesquisaFim. 
 */
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
            int opcao;
            string texto, textoPesquisa;
            Pesquisa pesquisa = new Pesquisa();
            PesquisaInicio pesquisaInicio = new PesquisaInicio();
            PesquisaFim pesquisaFim = new PesquisaFim();

            do
            {
                Console.Write("Escolha uma opção: \n 1 - Informar texto  \n 2 - Buscar string\n 3 - Buscar string no início\n 4 - Buscar string no fim \n 0 - Sair \nDigite: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite um texto: ");
                        texto = Console.ReadLine();
                        pesquisa.setTexto(texto);
                        break;
                    case 2:
                        Console.Write("Digite sua busca no texto digitado: ");
                        textoPesquisa = Console.ReadLine();

                        if (pesquisa.buscarString(textoPesquisa))
                            Console.WriteLine("O trecho digitado existe no texto. ");
                        else
                            Console.WriteLine("O trecho digitado não existe no texto.");
                        break;
                    case 3:
                        Console.Write("Digite sua busca no texto digitado: ");
                        textoPesquisa = Console.ReadLine();
                        pesquisaInicio.setTexto(pesquisa.getTexto());

                        if (pesquisaInicio.buscarString(textoPesquisa))
                            Console.WriteLine("O trecho digitado existe no início do texto. ");
                        else
                            Console.WriteLine("O trecho digitado não existe no início do texto.");
                        break;
                    case 4:
                        Console.Write("Digite sua busca no texto digitado: ");
                        textoPesquisa = Console.ReadLine();
                        pesquisaFim.setTexto(pesquisa.getTexto());

                        if (pesquisaFim.buscarString(textoPesquisa))
                            Console.WriteLine("O trecho digitado existe no fim do texto. ");
                        else
                            Console.WriteLine("O trecho digitado não existe no fim do texto.");
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar a aplicação.");
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
