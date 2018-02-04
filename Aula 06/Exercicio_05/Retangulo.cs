using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Retangulo: Forma
    {
        private double bs;
        private double altura;
        private string cor;

        public Retangulo(double bs, double altura, string cor)
        {
            this.bs = bs;
            this.altura = altura;

            this.calcularArea();
            this.confirgurarCor(cor);

        }

        public void calcularArea()
        {
            Console.WriteLine("A área do Retângulo é: " + (bs * altura));
        }

        public void confirgurarCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("A cor é: " + this.cor);
        }
    }
}
