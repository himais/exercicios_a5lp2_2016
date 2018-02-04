using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_01
{
    class Cliente
    {
        private int codigo;
        private string endereco;
        private string telefone;
        
        public void setCodigo(int codigo)
        {
            if(codigo < 0)
                throw new ArgumentException("Código inválido. ");
            this.codigo = codigo;
        }
        public void setEndereco(string endereco)
        {
            if (endereco.Length < 3)
                throw new ArgumentException("É necessário informar um endereço válido. ");
            this.endereco = endereco;
        }
        public void setTelefone(string telefone)
        {
            if (telefone.Length < 9)
                throw new ArgumentException("É necessário informar um telefone válido. ");
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
