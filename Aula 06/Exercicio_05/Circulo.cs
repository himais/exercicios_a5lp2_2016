using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Circulo: Forma
    {
        private double raio;
        private string cor;

        public Circulo(double raio, string cor)
        {
            this.raio = raio;

            this.calcularArea();
            this.confirgurarCor(cor);

        }

        public void calcularArea()
        {
            Console.WriteLine("A área do círculo é: "+ (3.14*(this.raio*this.raio)));
        }

        public void confirgurarCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("A cor é: " + this.cor);
        }
    }
}
