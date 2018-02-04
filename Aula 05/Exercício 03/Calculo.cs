/*
1) Calcular raiz quadrada – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(double num) da classe Calculo.
2) Calcular potenciação – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(double base, double expoente) da classe Calculo.
3) Calcular fatorial – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(int num) da classe Calculo.  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Calculo
    {
        public void ExecutarCalculo(double num)
        {
            Console.WriteLine("Raiz quadrada = "+Math.Sqrt(num));
        }

        public void ExecutarCalculo(double valor, double expoente)
        {
            Console.WriteLine("Potência = " + Math.Pow(valor, expoente));
        }

        public void ExecutarCalculo(int num)
        {
            if (num <= 1) Console.WriteLine("Fatorial = " + num);
            else
            {
                int fatorial = num;
                for (int i = num - 1; i > 1; i--)
                {
                    fatorial *= i;
                }
                Console.WriteLine("Fatorial = " + fatorial);
            }
        }
    }
}
