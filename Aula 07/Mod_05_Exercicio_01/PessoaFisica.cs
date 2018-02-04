using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_01
{
    class PessoaFisica : Cliente
    {
        private string nome;
        private string cpf;

        public void setNome(string nome)
        {
            if (nome.Length < 3 && !nome.Contains(" "))
                throw new ArgumentException("É necessário informar o nome completo. ");
            this.nome = nome;
        }
        public void setCpf(string cpf)
        {
            if (cpf.Length != 11)
                throw new ArgumentException("É necessário informar o CPF. ");
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
