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

        public Circulo(double raio, string cor)
        {
            if (raio <= 0)
                throw new ArgumentException("É necessário informar um número positivo. ");
            this.raio = raio;

            this.calcularArea();
            base.confirgurarCor(cor);

        }
        
        protected override void calcularArea()
        {
            Console.WriteLine("A área do círculo é: "+ (3.14*(this.raio*this.raio)));
        }
    }
}
