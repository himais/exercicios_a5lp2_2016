using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Aula5
{
    class PessoaFisica : Cliente
    {
        private string nome;
        private string cpf;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
    }
}
