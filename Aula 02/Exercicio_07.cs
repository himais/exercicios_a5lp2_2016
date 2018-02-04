/*
7 - Escreva um programa console em C# que leia o nome de 10 pessoas. Em seguida, imprima
todos os nomes utilizando o comando FOREACH.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    class Exercicio_07
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNomes cadastrados: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey(); //Segura console
        }
    }
}
