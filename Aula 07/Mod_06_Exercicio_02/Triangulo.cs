using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Triangulo: Forma
    {
        private double lado;

        public Triangulo(double lado, string cor)
        {
            if (lado <= 0)
                throw new ArgumentException("É necessário informar um número positivo. ");
            this.lado = lado;

            this.calcularArea();
            base.confirgurarCor(cor);

        }

        protected override void calcularArea()
        {
            Console.WriteLine("A área do triângulo é: " + ((Math.Pow(lado, 2)) * Math.Sqrt(3.0)) / 4);
        }
    }
}
