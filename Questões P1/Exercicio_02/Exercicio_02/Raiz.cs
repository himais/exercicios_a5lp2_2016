using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Raiz : ICalculo
    {
        public double Calcular(double numero)
        {
            return Math.Sqrt(numero); 
        }
    }
}
