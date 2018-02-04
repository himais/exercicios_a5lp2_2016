using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class PesquisaFim : Pesquisa
    {
        public sealed override bool buscarString(string cadeiaCaracteres)
        {
            if (texto.EndsWith(cadeiaCaracteres, StringComparison.CurrentCultureIgnoreCase))
                return true;
            else
                return false;
        }
    }
}
