using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu;
            string parametro1, parametro2, parametro3, parametro4;

            do
            {
                Console.WriteLine("Selecione a opção que deseja realizar: ");
                Console.WriteLine("1 - Criar arquivo ");
                Console.WriteLine("2 - Copiar arquivo ");
                Console.WriteLine("3 - Mover arquivo ");
                Console.WriteLine("4 - Excluir arquivo ");
                Console.WriteLine("5 - Criar arquivo e escrever ");
                Console.WriteLine("6 - Ler arquivo ");
                Console.WriteLine("7 - Criar diretório ");
                Console.WriteLine("8 - Excluir diretório ");
                Console.WriteLine("9 - Exibir informações sobre um arquivo ");
                Console.WriteLine("10 - Exibir informações sobre um diretório ");
                Console.WriteLine("11 - Exibir todos os arquivos de um diretório e de seus subdiretórios ");
                Console.WriteLine("12 - Exibir todos os arquivos de um diretório ");
                Console.WriteLine("13 - Exibir todos os subdiretórios de um diretório ");
                Console.WriteLine("14 - Exibir os subdiretórios imediatamente abaixo de um diretório ");
                Console.Write("Digite: ");

                try
                {
                    opcaoMenu = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Use apenas números. ");
                    opcaoMenu = -1;
                }

                //Console.Clear();
                Console.WriteLine();

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Criar arquivo ");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja criar: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.criarArquivo(parametro1, parametro2) ? "Arquivo criado com sucesso." : "Erro ao criar o arquivo. "));
                        break;
                    case 2:
                        Console.WriteLine("Copiar arquivo ");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja copiar: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine(@"Digite o local que deseja copiar o arquivo " + parametro2 + ": ");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro3 = Console.ReadLine();

                        Console.Write("Digite o novo nome do arquivo: ");
                        parametro4 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.copiarArquivo(parametro1, parametro2, parametro3, parametro4) ? "Arquivo copiado com sucesso." : "Erro ao copiar o arquivo.  "));
                        break;
                    case 3:
                        Console.WriteLine("Mover arquivo");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja mover: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine(@"Digite o local que deseja mover o arquivo " + parametro2 + ": ");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro3 = Console.ReadLine();

                        Console.Write("Digite o novo nome do arquivo: ");
                        parametro4 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.moverArquivo(parametro1, parametro2, parametro3, parametro4) ? "Arquivo movido com sucesso." : "Erro ao mover o arquivo.  "));
                        break;
                    case 4:
                        Console.WriteLine("Excluir arquivo");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja excluir: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.excluirArquivo(parametro1, parametro2) ? "Arquivo excluido com sucesso." : "Erro ao excluir o arquivo.  "));
                        break;
                    case 5:
                        Console.WriteLine("Criar arquivo e escrever");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja criar: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine(@"Digite o texto que deseja inserir no arquivo " + parametro2 + ": ");
                        parametro3 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.criarArquivoEEscrever(parametro1, parametro2, parametro3) ? "Arquivo criado com sucesso." : "Erro ao criar o arquivo. "));
                        break;
                    case 6:
                        Console.WriteLine("Ler arquivo");
                        Console.WriteLine(@"Digite o caminho do arquivo separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja ler: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine("Digite t para ler todas as linhas do arquivo ou p para ler parte delas: ");
                        string opcaoLeitura = Console.ReadLine();

                        if (opcaoLeitura.Equals("t"))
                        {
                            Arquivo.lerArquivoCompleto(parametro1, parametro2);
                        }
                        else if (opcaoLeitura.Equals("p"))
                        {
                            try
                            {
                                Console.Write("Digite a linha de início da leitura (início em 0): ");
                                int linhaInicio = int.Parse(Console.ReadLine());

                                Console.Write("Digite a linha de fim da leitura: ");
                                int linhaFim = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Arquivo.lerParteDoArquivo(parametro1, parametro2, linhaInicio, linhaFim);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Use apenas números. ");
                            }
                        }
                        else
                        {
                            Console.Write("Opção inválida.");
                        }

                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Criar diretório ");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do diretório que deseja criar: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.criarDiretorio(parametro1, parametro2) ? "Diretório criado com sucesso." : "Erro ao criar o diretório. Verifique se o mesmo já existe ou se os nomes especificados estão corretos. "));
                        break;
                    case 8:
                        Console.WriteLine("Excluir diretório ");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do diretório que deseja excluir: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine((Arquivo.excluirDiretorio(parametro1, parametro2) ? "Diretório excluído com sucesso." : "Erro ao excluir o diretório. Verifique se o mesmo já existe ou se os nomes especificados estão corretos. "));
                        break;
                    case 9:
                        Console.WriteLine("Exibir informações sobre um arquivo ");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome do arquivo que deseja exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirInfoDeArquivo(parametro1, parametro2);
                        break;
                    case 10:
                        Console.WriteLine("Exibir informações sobre um diretório");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome diretório que deseja exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirInfoDeDiretorio(parametro1, parametro2);
                        break;
                    case 11: 
                        Console.WriteLine("Exibir todos os arquivos de um diretório e de seus subdiretórios");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome diretório que exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.Write("Digite o nome ou parte do nome do arquivo que deseja buscar (* = todos): ");
                        parametro3 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirArquivosDeDiretorioESub(parametro1, parametro2, parametro3);
                        break;
                    case 12:
                        Console.WriteLine("Exibir todos os arquivos de um diretório");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome diretório que exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.Write("Digite o nome ou parte do nome do arquivo que deseja buscar (* = todos): ");
                        parametro3 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirTodosOsArquivosDeDir(parametro1, parametro2, parametro3);
                        break;
                    case 13:
                        Console.WriteLine("Exibir todos os subdiretórios de um diretório");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome diretório que exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.Write("Digite o nome ou parte do nome do diretório que deseja buscar (* = todos): ");
                        parametro3 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirTodosOsSubdiretorios(parametro1, parametro2, parametro3);
                        break;
                    case 14:
                        Console.WriteLine("Exibir os subdiretórios imediatamente abaixo de um diretório ");
                        Console.WriteLine(@"Digite o caminho do diretório separando por \\");
                        Console.Write(@"(exemplo: c:\\pasta\\subpasta): ");
                        parametro1 = Console.ReadLine();

                        Console.Write("Digite o nome diretório que exibir as informações: ");
                        parametro2 = Console.ReadLine();

                        Console.Write("Digite o nome ou parte do nome do diretório que deseja buscar (* = todos): ");
                        parametro3 = Console.ReadLine();

                        Console.WriteLine();

                        Arquivo.exibirTodosOsDiretoriosAbaixo(parametro1, parametro2, parametro3);
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu sair. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }

                Console.WriteLine();
            } while (opcaoMenu != 0);
            Console.ReadKey();
        }
    }
}
