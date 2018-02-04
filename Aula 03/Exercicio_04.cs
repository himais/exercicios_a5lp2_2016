/*
4 - Faça um programa em C# que altere os dados abaixo para que fiquem com a formatação
indicada:
- 257 -> 00257
- 2350000 – 2.350.000
- 5.6 -> 5,600
- 1.278 -> 127,8%
- 15/07/2016 -> sexta-feira, 15/julho/2016
 * */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Exercicio_04
    {
        static void Main(string[] args)
        {
            int dado = 0;
            double dadoDouble;
            DateTime data = new DateTime(2016, 07, 15);

            Console.WriteLine("Dados formatados:\n");

            dado = 257;
            Console.WriteLine(dado + " -> " + dado.ToString("00000"));

            dado = 2350000;
            Console.WriteLine(dado + " -> " + dado.ToString("###,###,###"));

            dadoDouble = 5.6;
            Console.WriteLine(dadoDouble + " -> " + dadoDouble.ToString("0.000"));

            dadoDouble = 1.278;
            Console.WriteLine(dadoDouble + " -> " + dadoDouble.ToString("000.0%"));

            Console.WriteLine(data.ToString("dd/MM/yyyy") + " -> " + data.ToString("dddd, dd/MMMM/yyyy"));

            Console.ReadKey();
        }
    }
}
