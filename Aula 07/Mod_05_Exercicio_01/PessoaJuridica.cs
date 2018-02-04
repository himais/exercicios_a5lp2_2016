using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_01
{
    class PessoaJuridica : Cliente
    {
        private string razaoSocial;
        private string cnpj;
        
        public void setRazaoSocial(string razaoSocial)
        {
            if (razaoSocial.Length < 3)
                throw new ArgumentException("É necessário informar a razão social. ");
            this.razaoSocial = razaoSocial;
        }
        public void setCnpj(string cnpj)
        {
            if (cnpj.Length != 11)
                throw new ArgumentException("É necessário informar o CNPJ. ");
            this.cnpj = cnpj;
        }

        public string getRazaoSocial()
        {
            return this.razaoSocial;
        }
        public string getCnpj()
        {
            return this.cnpj;
        }
    }
}
