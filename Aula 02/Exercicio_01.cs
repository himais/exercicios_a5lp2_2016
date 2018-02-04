/*
1. Faça um programa console em C# que leia um número inteiro e verifique se ele é par ou
ímpar e apresente esta informação para o usuário. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Exercicio_01
    {
        static void Main(string[] args)
        {
            //declaração da variável
            int numero = 0;

            //propósito do programa
            Console.WriteLine("Número pares e ímpares");

            //capturando o valor
            Console.Write("Digite úm número: ");

            //exibição do resultado
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("O número " + numero + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + numero + "  é ímpar.");
            }

            //Segurando o console
            Console.ReadKey();
        }
    }
}
