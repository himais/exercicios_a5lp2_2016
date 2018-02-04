using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Conjunto : Arquivo
    {
        private HashSet<string> conj = new HashSet<string>();

        public Conjunto(string[] nomes){
            this.InserirDados(nomes);
            this.UnirListaConjunto();
            base.IncluirDadosArquivo(conj.ToList<string>(), "Conjunto.txt");
            base.ExibirDadosArquivo("Conjunto.txt");
        }

        public override void InserirDados(string[] nomes)
        {
            foreach (string nome in nomes)
            {
                conj.Add(nome);
            }
        }

        public void UnirListaConjunto()
        {
            HashSet<string> toHashSet = new HashSet<string>();
            List<string> nomesLista = Lista.ObterLista();

            foreach (string nome in nomesLista) toHashSet.Add(nome);

            conj.UnionWith(toHashSet); 
        }
    }
}
