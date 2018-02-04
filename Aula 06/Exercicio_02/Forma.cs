using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    abstract class Forma
    {
        private string cor;

        protected void confirgurarCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("A cor é: " + this.cor);
        }        

        protected abstract void calcularArea();
    }
}
