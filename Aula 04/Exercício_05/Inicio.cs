using System;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu, codigoCliente = 1, codigoPesquisa;
            string nomeTemporario, cpfTemporario;
            int[] vetorCodigo = new int[10];
            string[] vetorNome = new string[10];
            string[] vetorCpf = new string[10];

            Cliente[] cliente = new Cliente[10];
   
            do
            {
                Console.WriteLine("\nDigite a opção da operação que deseja realizar: ");
                Console.Write(" 1 - Inserir cliente\n 2 - Consultar cliente específico \n 3 - Consultar clientes\n 0 - Sair\nDigite: ");
                opcaoMenu = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcaoMenu)
                {
                    case 1: //inserir cliente
                        Console.WriteLine("Inserir cliente: ");
                        Console.Write("Digite o nome do cliente: ");
                        nomeTemporario = Console.ReadLine();

                        Console.Write("Digite o cpf do cliente: ");
                        cpfTemporario = Console.ReadLine();

                        Console.WriteLine();
                        cliente[codigoCliente - 1] = new Cliente();

                        if (cliente[codigoCliente - 1].inserirCliente(codigoCliente, nomeTemporario, cpfTemporario))
                        {
                            Console.WriteLine("Cliente incluído com sucesso.");
                            codigoCliente++;
                        }
                        else
                        {
                            Console.WriteLine("Houve um erro na inclusão. Por favor, verifique os dados inseridos e tente novamente. ");
                        }
                        break;
                    case 2: //consultar cliente
                        Console.WriteLine("Consultar cliente específico: ");
                        Console.Write("Digite o código do cliente que deseja consultar: ");
                        codigoPesquisa = int.Parse(Console.ReadLine());
                        
                        if (codigoPesquisa >= 1 && codigoPesquisa < codigoCliente)
                        {
                            Console.WriteLine("Cód: " + cliente[codigoPesquisa-1].getCodigo() + " | Nome: " + cliente[codigoPesquisa - 1].getNome() + " | CPF: " + cliente[codigoPesquisa - 1].getCpf());
                        }
                        else
                        {
                            Console.WriteLine("O código digitado não corresponde a um cliente cadastrado.  ");
                        }
                        break;
                    case 3: //consultar todos
                        Console.WriteLine("Consultar clientes: ");

                        for (int i = 0; i < codigoCliente-1; i++)
                        {
                            Console.WriteLine("Cód: " + cliente[i].getCodigo() + " | Nome: " + cliente[i].getNome() + " | CPF: " + cliente[i].getCpf());
                        }
                        
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu finalizar a aplicação.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }

            } while (opcaoMenu != 0);

            Console.ReadKey();
        }
    }
}
