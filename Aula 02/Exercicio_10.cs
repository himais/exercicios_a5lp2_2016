/*
10 - Faça um programa console em C# que leia o nome e a altura de 10 pessoas. Em seguida,
crie uma consulta onde o usuário informa um valor de altura mínima e o programa
imprime os nomes de todas as pessoas, exceto aquelas que tiverem altura menor que a
informada. Utilize os comandos WHILE, IF e CONTINUE. Use um vetor para cada
informação (nome e altura).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Exercicio_10
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            double[] altura = new double[10];
            double alturaMinima;
            int contador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nPessoa " + (i + 1) + ": ");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite a altura mínima: ");
            alturaMinima = double.Parse(Console.ReadLine());

            Console.WriteLine(alturaMinima);

            Console.WriteLine("\nPessoas com a altura igual ou maior que " + alturaMinima + ": ");
            while (contador < 10)
            {
                if (altura[contador] < alturaMinima)
                {
                    contador++;
                    continue;
                }

                Console.WriteLine("Nome: " + nome[contador]);
                contador++;
            }

            Console.ReadKey();
        }
    }
}
