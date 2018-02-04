using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Venda v1 = new Venda();

            v1.setValor(10);
            v1.setValor(10);
            v1.setValor(10);
            v1.setValor(10);
            v1.setValor(10);
            v1.setValor(10);

            Venda v2 = new Venda();

            Console.WriteLine("Valor total: " + v2.getValor());

            Console.ReadKey();

        }
    }
}
