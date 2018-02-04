/*
4 - Escreva um programa console em C# que leia os nomes de 10 produtos. Em seguida, o
programa deve solicitar a faixa de produtos que deve ser apresentada (por exemplo: de 3 a
7) e, com base nesta faixa, deve imprimir apenas os produtos nela situados.
 */
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
            string[] nomeProdutos = new string[10];
            int faixaInicio;
            int faixaFim;

            Console.WriteLine("Digite os nomes de 10 produtos: ");

            for (int i = 0; i < 10; i++) {
                Console.Write("Produto " + (i + 1) + ": ");
                nomeProdutos[i] = Console.ReadLine();                
            }

            Console.WriteLine("Início da faixa para apresentação: ");
            faixaInicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fim da faixa para apresentação: ");
            faixaFim = Convert.ToInt32(Console.ReadLine());

            if (faixaInicio <= faixaFim) { 
                Console.WriteLine("Apresentação dos produtos por faixa: ");
                for (int i = (faixaInicio-1); i < faixaFim; i++) {
                    Console.WriteLine(nomeProdutos[i]);
                }
            }else
            {
                Console.Write("O início da faixa para apresentação deve ser menor que o fim da faixa. ");
            }


            //Segurando o console
            Console.ReadKey();
        }
    }
}
