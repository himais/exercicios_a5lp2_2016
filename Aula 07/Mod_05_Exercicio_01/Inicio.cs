using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao = 0, codigopf = 1, codigopj = 1, tipo, codigoRemover;
            string endereco, telefone, nome, cpf, cnpj;
            PessoaFisica[] pf = new PessoaFisica[10];
            PessoaJuridica[] pj = new PessoaJuridica[10];

            do
            {
                Console.Write("\nSelecione a ação que deseja realizar: \n 1 - Inserir cliente\n 2 - Remover cliente\n 3 - Consultar clientes\n 0 - Sair \nDigite: ");
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

                try
                {

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite: 1 - pessoa física ou 2 - pessoa jurídica: ");
                            try
                            {
                                tipo = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                                tipo = 1;
                            }

                            switch (tipo)
                            {
                                case 1:
                                    try
                                    {
                                        pf[codigopf - 1] = new PessoaFisica();
                                        pf[codigopf - 1].setCodigo(codigopf);

                                        Console.WriteLine("\nDigite o nome do cliente: ");
                                        nome = Console.ReadLine();
                                        pf[codigopf - 1].setNome(nome);

                                        Console.WriteLine("Digite o CPF do cliente: ");
                                        cpf = Console.ReadLine();
                                        pf[codigopf - 1].setCpf(cpf);

                                        Console.WriteLine("Digite o endereço do cliente: ");
                                        endereco = Console.ReadLine();
                                        pf[codigopf - 1].setEndereco(endereco);

                                        Console.WriteLine("Digite o telefone do cliente 9999-9999: ");
                                        telefone = Console.ReadLine();
                                        pf[codigopf - 1].setTelefone(telefone);

                                        codigopf++;
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
                                        Console.WriteLine("Fim da inserção de cliente (pessoa física). ");
                                    }
                                    break;
                                case 2:
                                    try
                                    {
                                        pj[codigopj - 1] = new PessoaJuridica();
                                        pj[codigopj - 1].setCodigo(codigopj);

                                        Console.WriteLine("\nDigite a razão social do cliente: ");
                                        nome = Console.ReadLine();
                                        pj[codigopj - 1].setRazaoSocial(nome);

                                        Console.WriteLine("Digite o CNPJ do cliente: ");
                                        cnpj = Console.ReadLine();
                                        pj[codigopj - 1].setCnpj(cnpj);

                                        Console.WriteLine("Digite o endereço do cliente: ");
                                        endereco = Console.ReadLine();
                                        pj[codigopj - 1].setEndereco(endereco);

                                        Console.WriteLine("Digite o telefone do cliente: ");
                                        telefone = Console.ReadLine();
                                        pj[codigopj - 1].setTelefone(telefone);

                                        codigopj++;
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
                                        Console.WriteLine("Fim da inserção de cliente (pessoa jurídica). ");
                                    }
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException("Opção inválida. ");
                            }

                            break;

                        case 2:
                            Console.Write("Digite: 1 - pessoa física ou 2 - pessoa jurídica: ");
                            try
                            {
                                tipo = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                                tipo = 1;
                            }

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("\nDigite o código do cliente: ");
                                    codigoRemover = int.Parse(Console.ReadLine());
                                    if (codigoRemover <= codigopf - 1 && pf[codigoRemover - 1] != null)
                                    {
                                        pf[codigoRemover - 1] = null;
                                        Console.WriteLine("O cliente foi excluído. ");
                                    }
                                    else
                                        Console.WriteLine("Código inválido.");
                                    break;
                                case 2:
                                    Console.WriteLine("\nDigite o código do cliente: ");
                                    codigoRemover = int.Parse(Console.ReadLine());
                                    if (codigoRemover <= codigopj - 1 && pj[codigoRemover - 1] != null)
                                    {
                                        pj[codigoRemover - 1] = null;
                                        Console.WriteLine("O cliente foi excluído. ");
                                    }
                                    else
                                        Console.WriteLine("Código inválido.");
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException("Opção inválida. ");
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nPessoa física: ");
                            if (codigopf >= 1)
                            {
                                Console.WriteLine("Não há clientes cadastrados.");
                            }
                            else
                            {
                                for (int i = 0; i < codigopf - 1; i++)
                                {
                                    if (pf[i] != null)
                                    {
                                        Console.WriteLine("\nCód cliente [" + (i + 1) + "] Nome: " + pf[i].getNome() + " | CPF: " + pf[i].getCpf() + " | Endereço: " + pf[i].getEndereco() + " | Telefone: " + pf[i].getTelefone());
                                    }
                                }
                            }

                            Console.WriteLine("\nPessoa jurídica: ");
                            if (pj.Length > 0)
                            {
                                for (int i = 0; i < codigopj - 1; i++)
                                {
                                    if (pj[i] != null)
                                    {
                                        Console.WriteLine("Cód cliente [" + (i + 1) + "] Razão Social: " + pj[i].getRazaoSocial() + " | CNPJ: " + pj[i].getCnpj() + " | Endereço: " + pj[i].getEndereco() + " | Telefone: " + pj[i].getTelefone());
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não há clientes cadastrados.");
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

                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
