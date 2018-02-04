/*
6 - Faça um programa console em C# que leia os códigos, os nomes e os preços de 10
produtos. Após a leitura, o programa deve solicitar ao usuário um determinado valor em
reais. Com base neste valor, o programa deve imprimir os dados dos produtos que tenham
o preço igual ou abaixo do valor informado. Use um vetor para cada informação (código,
nome e preço).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Exercicio_06
    {
        static void Main(string[] args)
        {
            int[] codigoProduto = new int[10];
            string[] nome = new string[10];
            double[] preco = new double[10];
            double valorBase;

            //lendo os valores
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nProduto " + (i + 1) + ": ");

                Console.Write("Código: ");
                codigoProduto[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Preço: ");
                preco[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            Console.Write("Digite um valor em reais: ");
            valorBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Produtos com o preço igual ou abaixo do valor informado: ");

            for (int i = 0; i < 10; i++)
            {
                if (preco[i] <= valorBase)
                {
                    Console.WriteLine("Código: " + codigoProduto[i] + " | nome: " + nome[i] + " | preço: " + preco[i]);
                }
            }

            Console.ReadKey(); //Segura console
        }
    }
}
