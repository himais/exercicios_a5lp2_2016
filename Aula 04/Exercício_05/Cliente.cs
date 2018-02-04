using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
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
                setNome(codigo, nome);
                setCpf(codigo, cpf);

                return true;
            }

            return false;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo; 

        }

        public void setNome(int codigo, string nome)
        {
            this.nome = nome;
        }

        public void setCpf(int codigo, string cpf)
        {
            this.cpf = cpf;
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
