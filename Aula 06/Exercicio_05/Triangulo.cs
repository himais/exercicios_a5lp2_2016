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
        private double altura;
        private string cor; 

        public Triangulo(double lado, double altura, string cor)
        {
            this.lado = lado;
            this.altura = altura;

            this.calcularArea();
            this.confirgurarCor(cor);

        }

        public void calcularArea()
        {
            Console.WriteLine("A área do triângulo é: " + ((lado * altura)/2));
        }

        public void confirgurarCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("A cor é: " + this.cor);
        }
    }
}
