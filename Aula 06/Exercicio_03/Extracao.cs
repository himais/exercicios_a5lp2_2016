using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Extracao : Texto
    {
        public Extracao(string posInicial, string numCaracteres)
        {
            this.manipularString(base.getTexto(), posInicial, numCaracteres);
        }

        public Extracao(string texto)
        {
            base.setTexto(texto);
        }

        protected override void manipularString(string texto, string posInicial, string numCaracteres) {
            int inicio = int.Parse(posInicial);
            int total = int.Parse(numCaracteres);
            string textp = texto.Substring(inicio, total);
            Console.WriteLine("Extrair string: "+ textp);
        }
    }
}
