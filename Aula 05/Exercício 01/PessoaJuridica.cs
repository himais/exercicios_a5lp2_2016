using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Aula5
{
    class PessoaJuridica : Cliente
    {
        private string razaoSocial;
        private string cnpj;
        
        public void setRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }
        public void setCnpj(string cnpj)
        {
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
