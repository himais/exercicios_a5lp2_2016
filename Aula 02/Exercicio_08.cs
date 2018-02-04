/*
8 - Faça um programa console em C# que leia as informações de 10 clientes de uma loja
(nome, CPF, e-mail e telefone). Em seguida, o programa deve disponibilizar 4 opções de
consulta (1-Por nome, 2-Por CPF, 3-Por e-mail e 4-Por telefone). Por exemplo, se o usuário
escolher a opção 2, a consulta deverá solicitar um CPF e, com base nele, deverá imprimir os 
dados do cliente que tenha este CPF. O programa deve informar caso não encontre
nenhum cliente com o dado informado. Use uma matriz 10 x 4 para representar os dados
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    class Exercicio_08
    {
        static void Main(string[] args)
        {
            string[,] clientes = new string[10, 4]; //matriz com os dados
            int opcaoConsulta = 0; //opcao de consulta escolhida pelo usuário -> 1 nome, 2 cpf, 3 email e 4 tel
            string termoPesquisa = ""; //termo que o usuário pesquisará 
            int indiceTermoPesquisa = 0; //indice do tipo de pesquisa correspondente nas colunas da matriz -> 0 nome, 1 cpf, 2 email e 3 tel
            bool opcaoErro = false; //caso usuário escolha uma opcao inválida nao fazer a pesquisa
            bool pesquisaEncontrada = false; //para exibir erro caso nao encontre nada
            string encerraAplicacao = ""; 

            //escita dos dados dos clientes
            Console.WriteLine("Inserção dos dados dos clientes:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nPessoa: "+(i+1));

                Console.Write("Nome: ");
                clientes[i, 0] = Console.ReadLine();
                Console.Write("CPF: ");
                clientes[i, 1] = Console.ReadLine();
                Console.Write("E-mail: ");
                clientes[i, 2] = Console.ReadLine();
                Console.Write("Telefone: ");
                clientes[i, 3] = Console.ReadLine();
            }

            do
            {
                opcaoErro = false; //renova valor das variáveis de erro 
                pesquisaEncontrada = false;
                encerraAplicacao = "";

                //Escolha de uma opção no menu
                Console.WriteLine("\n\nConsultar cliente: \n Digite: \n 1 - Consultar por nome \n 2 - Consultar por CPF \n 3 - Consultar por e-mail \n 4 - Consultar por telefone");
                opcaoConsulta = Convert.ToInt32(Console.ReadLine());

                switch (opcaoConsulta)
                {
                    case 1: //consulta por nome
                        Console.Write("\nConsulta por nome\n Entre com o nome do cliente que deseja pesquisar: ");
                        termoPesquisa = Console.ReadLine();
                        termoPesquisa = termoPesquisa.ToLower(); //deixa em minúsculo 
                        indiceTermoPesquisa = 0;
                        break;
                    case 2: //consulta por cpf
                        Console.Write("\nConsulta por CPF\n Entre com o CPF do cliente que deseja pesquisar: ");
                        termoPesquisa = Console.ReadLine();
                        indiceTermoPesquisa = 1;
                        break;
                    case 3: //consulta por email
                        Console.Write("\nConsulta por e-mail\n Entre com o e-mail do cliente que deseja pesquisar: ");
                        termoPesquisa = Console.ReadLine();
                        indiceTermoPesquisa = 2;
                        break;
                    case 4: //consulta por telefone
                        Console.Write("\nConsulta por telefone\n Entre com o telefone do cliente que deseja pesquisar: ");
                        termoPesquisa = Console.ReadLine();
                        indiceTermoPesquisa = 3;
                        break;
                    default:
                        Console.Write("Opção inválida.");
                        opcaoErro = true;
                        break;
                }

                //pesquisando o conteúdo no indice fornecido caso uma opção válida tenha sido digitada
                if (!opcaoErro)
                {
                    Console.WriteLine("\nResultado da pesquisa: ");
                    for (int i = 0; i < 10; i++)
                    {
                        //percorre os clientes comparando apenas a posição do indice de pesquisa fornecido 
                        if (clientes[i, indiceTermoPesquisa].Equals(termoPesquisa))
                        {
                            Console.WriteLine("\nNome: " + clientes[i, 0]);
                            Console.WriteLine("CPF: " + clientes[i, 1]);
                            Console.WriteLine("E-mail: " + clientes[i, 2]);
                            Console.WriteLine("Telefone: " + clientes[i, 3]);
                            pesquisaEncontrada = true; //seta para nao exibir a mensagem de erro
                        }
                    }

                    //mensagem de erro caso nao haja resultados
                    if (!pesquisaEncontrada)
                        Console.WriteLine("Não há nenhum registro para exibir. ");
                }

                //confirmação de saída
                Console.WriteLine("\nDeseja encerrar a aplicação? Digite s para finalizar ou n para continuar.");
                encerraAplicacao = Console.ReadLine();

            } while (encerraAplicacao != "s");

            Console.ReadKey(); //Segura console
        }
    }
}
