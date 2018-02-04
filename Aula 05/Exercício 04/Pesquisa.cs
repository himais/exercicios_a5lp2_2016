using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Pesquisa
    {
        protected string texto;

        public void setTexto(string texto)
        {
            this.texto = texto;
        }
        public string getTexto()
        {
            return this.texto;
        }

        public virtual bool buscarString(string cadeiaCaracteres)
        {
            if (texto.Contains(cadeiaCaracteres))
                return true;
            else
                return false;
        }
    }
    
}
