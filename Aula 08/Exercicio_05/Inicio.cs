using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Adicionar elementos em conjuntos (solicitar os elementos de dois conjuntos)
2) Remover elemento de conjunto
3) Mostrar elementos em comum nos conjuntos
4) Juntar elementos dos conjuntos
5) Subtrair conjuntos
6) Verificar se um conjunto está contido em outro
7) Verificar se um conjunto contém outro
8) Imprimir conjuntos
     */

namespace Exercicio_05
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0, valorOpcao;
            string valorElemento1, valorElemento2;
            Conjunto conjuntos = new Conjunto();

            do
            {
                Console.Write("Selecione a opção que deseja realizar:\n 1 - Adicionar elementos em conjuntos \n 2 - Remover elemento de conjunto\n 3 - Mostrar elementos em comum nos conjuntos \n 4 - Juntar elementos dos conjuntos \n 5 - Subtrair conjuntos \n 6 - Verificar se um conjunto está contido em outro \n 7 - Verificar se um conjunto contém outro \n 8 - Imprimir conjuntos\n 0 - Sair \nDigite: ");
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
                        Console.WriteLine("Adicionar elementos em conjuntos ");

                        Console.Write("Digite o elemento que deseja adicionar ao conjunto 1: ");
                        valorElemento1 = Console.ReadLine();

                        Console.Write("Digite o elemento que deseja adicionar ao conjunto 2: ");
                        valorElemento2 = Console.ReadLine();

                        conjuntos.addElementoConjunto1(valorElemento1);
                        conjuntos.addElementoConjunto2(valorElemento2);
                        Console.WriteLine("Os elementos foram adicionados ao conjunto. ");
                        break;
                    case 2:
                        Console.WriteLine("Remover elemento de conjunto");
                        Console.Write("Digite 1 para remover do conjunto 1 ou 2 para remover do conjunto 2: ");
                        try
                        {
                            valorOpcao = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            valorOpcao = -1; //mensagem de opcao inválida
                        }

                        if (valorOpcao == 1)
                        {
                            Console.Write("Informe o elemento que deseja remover do conjunto 1: ");
                            valorElemento1 = Console.ReadLine();
                            conjuntos.removerElementoConjunto1(valorElemento1);
                        }
                        else if (valorOpcao == 2)
                        {
                            Console.Write("Informe o elemento que deseja remover do conjunto 2: ");
                            valorElemento2 = Console.ReadLine();
                            conjuntos.removerElementoConjunto2(valorElemento2);
                        }
                        else
                        {
                            Console.Write("Conjunto inválido.");
                        }

                        Console.Write("");

                        break;
                    case 3:
                        Console.WriteLine("Mostrar elementos em comum nos conjuntos");
                        conjuntos.elementosEmComum();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Juntar elementos dos conjuntos");
                        conjuntos.juntarElementos();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Subtrair conjuntos");
                        Console.Write("Digite 1 para subtrair do conjunto 1 ou 2 para subtrair do conjunto 2: ");
                        try
                        {
                            valorOpcao = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            valorOpcao = -1; //mensagem de opcao inválida
                        }

                        if (valorOpcao == 1)
                        {
                            conjuntos.subtrairElementosConjunto1();
                        }
                        else if (valorOpcao == 2)
                        {
                            conjuntos.subtrairElementosConjunto2();
                        }
                        else
                        {
                            Console.Write("Conjunto inválido.");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Verificar se um conjunto está contido em outro");
                        Console.Write("Digite 1 para verificar o conjunto 1 ou 2para verificar o conjunto 2: ");
                        try
                        {
                            valorOpcao = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            valorOpcao = -1; //mensagem de opcao inválida
                        }

                        if (valorOpcao == 1)
                        {
                            conjuntos.verificarConjunto1Contido();
                        }
                        else if (valorOpcao == 2)
                        {
                            conjuntos.verificarConjunto2Contido();
                        }
                        else
                        {
                            Console.Write("Conjunto inválido.");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Verificar se um conjunto contém outro");
                        Console.Write("Digite 1 para verificar o conjunto 1 ou 2para verificar o conjunto 2: ");
                        try
                        {
                            valorOpcao = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            valorOpcao = -1; //mensagem de opcao inválida
                        }

                        if (valorOpcao == 1)
                        {
                            conjuntos.verificarSeConjunto1Contem();
                        }
                        else if (valorOpcao == 2)
                        {
                            conjuntos.verificarSeConjunto1Contem();
                        }
                        else
                        {
                            Console.Write("Conjunto inválido.");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Imprimir conjuntos");
                        conjuntos.imprimirConjuntos();
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
