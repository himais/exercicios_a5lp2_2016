using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            //Declaração das var
            double nota1 = 0;
            double nota2 = 0;
            double media = 0;

            //propósito da aplicação
            Console.WriteLine("Cálculo de média");

            //Capturando valores 
            Console.WriteLine("Entre com a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            //Cálculo da média
            media = (nota1 + nota2) / 2;

            //Exibição dos resultados
            Console.WriteLine("A média do aluno é: " + media);
            Console.ReadKey(); //Mantém o console aberto 
        }
    }
}
