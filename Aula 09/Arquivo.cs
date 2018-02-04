using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_Aula9
{
    class Arquivo
    {
        public static bool criarArquivo(string caminho, string nomeArquivo)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (!File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    FileStream fs = File.Create(caminho + '\\' + nomeArquivo);
                    fs.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool copiarArquivo(string caminho, string nomeArquivo, string caminhoCopia, string nomeArquivoCopia)
        {
            nomeArquivo = nomeArquivo + ".txt";
            nomeArquivoCopia = nomeArquivoCopia + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    File.Copy(caminho + '\\' + nomeArquivo, caminhoCopia + '\\' + nomeArquivoCopia, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool moverArquivo(string caminho, string nomeArquivo, string caminhoMove, string nomeArquivoMove)
        {
            nomeArquivo = nomeArquivo + ".txt";
            nomeArquivoMove = nomeArquivoMove + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    File.Move(caminho + '\\' + nomeArquivo, caminhoMove + '\\' + nomeArquivoMove);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool excluirArquivo(string caminho, string nomeArquivo)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    File.Delete(caminho + '\\' + nomeArquivo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool criarArquivoEEscrever(string caminho, string nomeArquivo, string texto)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (!File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    FileStream fs = new FileStream(caminho + '\\' + nomeArquivo, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(texto);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                return true;
            }
            return false;
        }

        public static void lerArquivoCompleto(string caminho, string nomeArquivo)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    FileStream fs = new FileStream(caminho + '\\' + nomeArquivo, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string conteudo = sr.ReadToEnd();
                    Console.WriteLine("Conteúdo do arquivo: \n" + conteudo);
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }

            }
            else
            {
                Console.WriteLine("O arquivo não existe");
            }
        }

        public static void lerParteDoArquivo(string caminho, string nomeArquivo, int linhaInicio, int linhaFim)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    FileStream fs = new FileStream(caminho + '\\' + nomeArquivo, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    string conteudo;
                    int contador = 0;
                    Console.WriteLine("Conteúdo do arquivo: ");

                    while ((conteudo = sr.ReadLine()) != null)
                    {
                        if(contador >= linhaInicio && contador <= linhaFim) System.Console.WriteLine(conteudo);
                        contador++;
                    }

                    sr.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O arquivo não existe");
            }
        }

        public static bool criarDiretorio(string caminho, string nomeDir)
        {
            if (!Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    Directory.CreateDirectory(caminho + '\\' + nomeDir);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool excluirDiretorio(string caminho, string nomeDir)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    Directory.Delete(caminho + '\\' + nomeDir, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

        public static void exibirInfoDeArquivo(string caminho, string nomeArquivo)
        {
            nomeArquivo = nomeArquivo + ".txt";
            if (File.Exists(caminho + '\\' + nomeArquivo))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(caminho + '\\' + nomeArquivo);
                    Console.WriteLine("Informações do arquivo: ");
                    Console.WriteLine("Data de criação: " + di.CreationTime.ToShortDateString());
                    Console.WriteLine("Extensão do arquivo: " + di.Extension);
                    Console.WriteLine("Último acesso: " + di.LastAccessTime);
                    Console.WriteLine("Última modificação: " + di.LastWriteTime);
                    Console.WriteLine("Diretório Pai: " + di.Parent);
                    Console.WriteLine("Caminho: " + di.FullName);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O arquivo não existe");
            }
        }

        public static void exibirInfoDeDiretorio(string caminho, string nomeDir)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(caminho + '\\' + nomeDir);
                    Console.WriteLine("Informações do diretório: ");
                    Console.WriteLine("Data de criação: " + di.CreationTime.ToShortDateString());
                    Console.WriteLine("Último acesso: " + di.LastAccessTime);
                    Console.WriteLine("Última modificação: " + di.LastWriteTime);
                    Console.WriteLine("Diretório Pai: " + di.Parent);
                    Console.WriteLine("Caminho: " + di.FullName);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O diretório não existe");
            }
        }

        public static void exibirArquivosDeDiretorioESub(string caminho, string nomeDir, string nomeArquivo)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    if (nomeArquivo.Equals("*"))
                    {
                        nomeArquivo = "*";
                    }
                    else
                    {
                        nomeArquivo = "*" + nomeArquivo + "*";
                    }

                    nomeArquivo = nomeArquivo + ".txt";
                    DirectoryInfo di = new DirectoryInfo(caminho + "\\" + nomeDir);
                    FileInfo[] fi = di.GetFiles(nomeArquivo, SearchOption.AllDirectories);
                    Console.WriteLine("Arquivos do diretório " + nomeDir);
                    foreach (FileInfo f in fi)
                    {
                        Console.WriteLine(f);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O diretório não existe");
            }
        }

        public static void exibirTodosOsArquivosDeDir(string caminho, string nomeDir, string nomeArquivo)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    if (nomeArquivo.Equals("*"))
                    {
                        nomeArquivo = "*";
                    }
                    else
                    {
                        nomeArquivo = "*" + nomeArquivo + "*";
                    }
                    nomeArquivo = nomeArquivo + ".txt";
                    DirectoryInfo di = new DirectoryInfo(caminho + "\\" + nomeDir);
                    FileInfo[] fi = di.GetFiles(nomeArquivo, SearchOption.TopDirectoryOnly);
                    Console.WriteLine("Arquivos do diretório " + nomeDir);
                    foreach (FileInfo f in fi)
                    {
                        Console.WriteLine(f);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O diretório não existe");
            }
        }

        public static void exibirTodosOsSubdiretorios(string caminho, string nomeDir, string nomeSub)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                if (nomeSub.Equals("*"))
                {
                    nomeSub = "*";
                }
                else
                {
                    nomeSub = "*" + nomeSub + "*";
                }
                try
                {
                    DirectoryInfo di = new DirectoryInfo(caminho + "\\" + nomeDir);
                    DirectoryInfo[] dir = di.GetDirectories(nomeSub, SearchOption.AllDirectories);
                    Console.WriteLine("Subdiretórios do diretório " + nomeDir);
                    foreach (DirectoryInfo d in dir)
                    {
                        Console.WriteLine(d);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O diretório não existe");
            }
        }

        public static void exibirTodosOsDiretoriosAbaixo(string caminho, string nomeDir, string nomeSub)
        {
            if (Directory.Exists(caminho + '\\' + nomeDir))
            {
                try
                {
                    if (nomeSub.Equals("*"))
                    {
                        nomeSub = "*";
                    }
                    else
                    {
                        nomeSub = "*" + nomeSub + "*";
                    }
                    DirectoryInfo di = new DirectoryInfo(caminho + "\\" + nomeDir);
                    DirectoryInfo[] dir = di.GetDirectories(nomeSub, SearchOption.TopDirectoryOnly);
                    Console.WriteLine("Subdiretórios imediatamente abaixo do diretório " + nomeDir);
                    foreach (DirectoryInfo d in dir)
                    {
                        Console.WriteLine(d);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e);
                }
            }
            else
            {
                Console.WriteLine("O diretório não existe");
            }
        }
    }
}
