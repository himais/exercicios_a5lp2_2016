using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        private bool ativo;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public double getPreco()
        {
            return this.preco;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }

        public bool getAtivo()
        {
            return this.ativo;
        }
    }
}
