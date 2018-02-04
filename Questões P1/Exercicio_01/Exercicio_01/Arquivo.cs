using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Exercicio_01
{
    abstract class Arquivo
    {
        public abstract void InserirDados(string[] nomes);
        public void IncluirDadosArquivo(List<string> lista_nomes, string caminho_arquivo)
        {
            if (File.Exists(caminho_arquivo))
            {
                StreamWriter sw = new StreamWriter(caminho_arquivo);
                foreach (string nome in lista_nomes)
                {
                    sw.WriteLine(nome); 
                }

                sw.Close();
            }
            
        }
        public void ExibirDadosArquivo(string caminho_arquivo)
        {
            if (File.Exists(caminho_arquivo))
            {
                FileStream fs = new FileStream(caminho_arquivo, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("\nDados do arquivo: \n"+sr.ReadToEnd());

                fs.Close();
            }
        }
    }
}
