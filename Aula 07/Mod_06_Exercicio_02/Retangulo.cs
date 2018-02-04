﻿using System;
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

        public Retangulo(double bs, double altura, string cor)
        {
            if (bs <= 0)
                throw new ArgumentException("É necessário informar um número positivo. ");

            if (altura <= 0)
                throw new ArgumentException("É necessário informar um número positivo. ");

            this.bs = bs;
            this.altura = altura;

            this.calcularArea();
            base.confirgurarCor(cor);
        }

        protected override void calcularArea()
        {
            Console.WriteLine("A área do Retângulo é: " + (bs * altura));
        }
    }
}
