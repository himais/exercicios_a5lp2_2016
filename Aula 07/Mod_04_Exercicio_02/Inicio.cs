using System;

namespace Mod_04_Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu, codigoCliente = 1, codigoPesquisa;
            string nomeTemporario, cpfTemporario;

            Cliente[] cliente = new Cliente[10];

            do
            {
                Console.WriteLine("\nDigite a opção da operação que deseja realizar: ");
                Console.Write(" 1 - Inserir cliente\n 2 - Consultar cliente específico \n 3 - Consultar clientes\n 0 - Sair\nDigite: ");
                try
                {
                    opcaoMenu = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    opcaoMenu = -1;
                }
                Console.WriteLine("");

                try
                {

                    switch (opcaoMenu)
                    {
                        case 1: //inserir cliente
                            try
                            {
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
                                    throw new ArgumentException("Houve um erro na inclusão. Por favor, verifique os dados inseridos e tente novamente. ");
                                }
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim da inserção de cliente. ");
                            }

                            break;
                        case 2: //consultar cliente
                            try
                            {
                                Console.WriteLine("Consultar cliente específico: ");
                                Console.Write("Digite o código do cliente que deseja consultar: ");
                                codigoPesquisa = int.Parse(Console.ReadLine());

                                if (codigoPesquisa >= 1 && codigoPesquisa < codigoCliente)
                                {
                                    Console.WriteLine("Cód: " + cliente[codigoPesquisa - 1].getCodigo() + " | Nome: " + cliente[codigoPesquisa - 1].getNome() + " | CPF: " + cliente[codigoPesquisa - 1].getCpf());
                                }
                                else
                                {
                                    throw new IndexOutOfRangeException("O código informado é inválido. ");
                                }
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim da consulta de cliente. ");
                            }
                            break;
                        case 3: //consultar todos
                            try
                            {
                                Console.WriteLine("Consultar clientes: ");
                                for (int i = 0; i < codigoCliente - 1; i++)
                                {
                                    Console.WriteLine("Cód: " + cliente[i].getCodigo() + " | Nome: " + cliente[i].getNome() + " | CPF: " + cliente[i].getCpf());
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim da consulta de clientes. ");
                            }

                            break;
                        case 0:
                            Console.WriteLine("Você escolheu finalizar a aplicação.");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Opção do menu", "Opção inválida. ");
                    }

                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (opcaoMenu != 0);

            Console.ReadKey();
        }
    }
}
