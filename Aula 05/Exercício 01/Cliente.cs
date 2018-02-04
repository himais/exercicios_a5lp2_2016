using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Aula5
{
    class Cliente
    {
        private int codigo;
        private string endereco;
        private string telefone;
        
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public int getCodigo()
        {
            return this.codigo;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
    }
}
