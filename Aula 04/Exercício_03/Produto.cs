using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        private bool ativo;

        public Produto()
        {
            this.codigo = 0;
            this.descricao = "";
            this.preco = 0.0;
            this.ativo = false;
        }

        ~Produto()
        {
            Console.WriteLine("O objeto produto foi descartado.");
        }

        public int Codigo
        {
            get { return codigo; }
            set { if (value >= 0) codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { if (value != "") descricao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { if (value >= 0.0) preco = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { if (value != null) ativo = value; }
        }
    }
}
