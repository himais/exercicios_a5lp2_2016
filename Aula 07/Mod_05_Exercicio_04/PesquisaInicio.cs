using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_04
{
    class PesquisaInicio : Pesquisa
    {
        public sealed override bool buscarString(string cadeiaCaracteres)
        {
            if (texto.StartsWith(cadeiaCaracteres, StringComparison.CurrentCultureIgnoreCase))
                return true;
            else
                return false;
        }
    }
}
