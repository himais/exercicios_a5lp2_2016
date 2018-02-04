using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Lista: Arquivo
    {
        private static List<string> lista = new List<string>();
        public Lista(string[] nomes)
        {
            this.InserirDados(nomes);
            this.OrdenarLista();
            base.IncluirDadosArquivo(lista, "Lista.txt");
            base.ExibirDadosArquivo("Lista.txt");
        }
        public override void InserirDados(string[] nomes)
        {
            foreach (string nome in nomes)
            {
                lista.Add(nome);
            }
        }
        public void OrdenarLista()
        {
            lista.Sort(); 
        }
        public static List<string> ObterLista()
        {
            return lista; 
        }
    }
}
