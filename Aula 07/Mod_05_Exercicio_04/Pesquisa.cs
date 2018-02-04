using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_04
{
    class Pesquisa
    {
        protected string texto;

        public void setTexto(string texto)
        {
            if(texto.Length <= 1)
                throw new ArgumentException("É necessário informar um texto completo. ");
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
