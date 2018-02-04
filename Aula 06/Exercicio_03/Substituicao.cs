using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Substituicao : Texto
    {
        public Substituicao(string strSubstituida, string strSubstituta)
        {
            this.manipularString(base.getTexto(), strSubstituida, strSubstituta);
        }

        protected override void manipularString(string texto, string strSubstituida, string strSubstituta)
        {
            Console.WriteLine("Substituir string: " + texto.Replace(strSubstituida, strSubstituta));
        }
    }
}
