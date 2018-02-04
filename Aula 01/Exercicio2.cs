using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            //Declarãção das variáveis
            double valorProduto = 0;
            double valorDesconto = 0;
            double valorFinal = 0;

            //Propósito da aplicação 
            Console.WriteLine("Cálculo de desconto");

            //Capturando valor do produto
            Console.WriteLine("Entre com o valor do produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            //Capturando valor do desconto
            Console.WriteLine("Entre com a porcentagem de desconto: ");
            valorDesconto = double.Parse(Console.ReadLine());

            //Cálculo do novo valor do produto
            valorFinal = valorProduto - (valorProduto * valorDesconto / 100);

            //Exibição dos resultados
            Console.WriteLine("O valor do produto com o desconto aplicado é: " + valorFinal);
            Console.ReadKey(); //Segura console
        }
    }
}
