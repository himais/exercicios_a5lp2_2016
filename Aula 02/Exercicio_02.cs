/*
2 - Escreva um programa console em C# que leia as informações sobre o faturamento de um
armazém em cada um dos 12 meses de um determinado ano. O programa deve imprimir se
o faturamento no ano foi baixo (menor ou igual a R$ 50.000,00), médio (entre R$
50.000,01 e R$ 100.000,00) ou alto (acima de R$ 100.000,00).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Exercicio_02
    {
        static void Main(string[] args)
        {
            double faturamentoAnual = 0;
            double faturamentoMensal = 0;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Digite o faturamento do mês " + i);
                faturamentoMensal = double.Parse(Console.ReadLine());

                //calculo do faturamento anual
                faturamentoAnual += faturamentoMensal;
            }

            if (faturamentoAnual <= 50000.00)
            {
                Console.WriteLine("O faturamento anual foi baixo ("+ faturamentoAnual + ").");
            }
            else if (faturamentoAnual > 100000.00)
            {
                Console.WriteLine("O faturamento anual foi alto (" + faturamentoAnual + ")."); ;
            }
            else
            {
                Console.WriteLine("O faturamento anual foi médio (" + faturamentoAnual + ").");
            }

            Console.ReadKey();
        }
    }
}
