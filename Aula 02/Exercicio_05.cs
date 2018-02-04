/*
5 - Escreva um programa console em C# que leia o nome e a idade de 10 pessoas. Em seguida,
o programa deve solicitar uma idade mínima e, com base nela, imprimir apenas os dados
das pessoas que tiverem esta idade ou mais. Use um vetor para cada informação (nome e
idade).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Exercicio_05
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            int[] idade = new int[10];
            int idadeMinima = 0;

            //lendo o nome das pessoas
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\nNome " + (i + 1) + ": ");
                nome[i] = Console.ReadLine();

                //lendo a idade
                Console.Write("Idade " + (i + 1) + ": ");
                idade[i] = Convert.ToInt32(Console.ReadLine());
            }

            //pegando a idade minima
            Console.Write("\nDigite a idade mínima: ");
            idadeMinima = Convert.ToInt32(Console.ReadLine());

            //exibindo dados com a idade mínima
            for (int i = 0; i < 10; i++)
            {
                if (idade[i] >= idadeMinima)
                {
                    Console.WriteLine("Nome: " + nome[i] + " idade: " + idade[i]);
                }
            }

            //Segurando o console
            Console.ReadKey();
        }
    }
}
