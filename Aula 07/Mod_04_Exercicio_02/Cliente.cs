using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_04_Exercicio_05
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string cpf; 

        public bool inserirCliente(int codigo, string nome, string cpf)
        {
            if(nome.Contains(" ") && cpf.Length == 11)
            {
                setCodigo(codigo);
                setNome(nome);
                setCpf(cpf);

                return true;
            }

            return false;
        }

        public void setCodigo(int codigo)
        {
            if (codigo < 1)
            {
                throw new ArgumentException("Código inválido. ");
            }
            this.codigo = codigo; 

        }

        public void setNome(string nome)
        {
            if (nome.Length > 45 || nome.Length < 2)
            {
                throw new ArgumentException("É necessário informar o nome completo. ");
            }

            this.nome = nome;
        }

        public void setCpf(string cpf)
        {
            if (cpf.Length != 11)
            {
                this.cpf = cpf;
            }
        }

        public int getCodigo()
        {
            return this.codigo;
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
