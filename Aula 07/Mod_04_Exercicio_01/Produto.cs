using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_04_Exercicio_01
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        private bool ativo;

        public void setCodigo(int codigo)
        {
            if(codigo < 0)
            {
                throw new ArgumentException("O código deve ser maior que 0.");
            }

            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setDescricao(string descricao)
        {
            if (descricao.Length > 25)
            {
                throw new ArgumentException("A descrição deve possuir até 25 caracteres. ");
            }

            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public void setPreco(double preco)
        {
            if (preco < 0.00)
            {
                throw new ArgumentException("O preço deve ser maior que 0,00. ");
            }

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
