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
            int opcaoMenu, codigoCliente = 1, codigoPesquisa;
            Cliente cliente = new Cliente();
            string nomeTemporario, cpfTemporario;
            int[] vetorCodigo = new int[10];
            string[] vetorNome = new string[10];
            string[] vetorCpf = new string[10];

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

                        if (cliente.inserirCliente(codigoCliente, nomeTemporario, cpfTemporario))
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

                        vetorCodigo = cliente.getVetorCodigo();
                        vetorNome = cliente.getVetorNome();
                        vetorCpf = cliente.getVetorCpf();

                        if (codigoPesquisa >= 1 && codigoPesquisa < codigoCliente)
                        {
                            Console.WriteLine("Cód: " + vetorCodigo[codigoPesquisa-1] + " | Nome: " + vetorNome[codigoPesquisa - 1] + " | CPF: " + vetorCpf[codigoPesquisa - 1]);
                        }
                        else
                        {
                            Console.WriteLine("O código digitado não corresponde a um cliente cadastrado.  ");
                        }
                        break; 
                    case 3: //consultar todos
                        Console.WriteLine("Consultar clientes: ");
                        vetorCodigo = cliente.getVetorCodigo();
                        vetorNome = cliente.getVetorNome();
                        vetorCpf = cliente.getVetorCpf();

                        for(int i = 0; i < codigoCliente - 1; i++){
                            Console.WriteLine("Cód: " + vetorCodigo[i] + " | Nome: " + vetorNome[i] + " | CPF: "+ vetorCpf[i]);
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
