/*
3 - Faça um programa console em C# que leia o nome de um mês do ano e apresente a
estação predominante neste mês. O programa deve informar caso o mês informado não
exista
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            string nomeMes;

            Console.Write("Entre com um mês do ano: ");
            nomeMes = Console.ReadLine();

            nomeMes = nomeMes.ToLower();

            switch (nomeMes)
            {
                case "dezembro":
                case "janeiro":
                case "fevereiro":
                    Console.WriteLine("A estação predominante no mês de " + nomeMes + " é o verão.");
                    break;

                case "março":
                case "abril":
                case "maio":
                    Console.WriteLine("A estação predominante no mês de " + nomeMes + " é o outono.");
                    break;

                case "junho":
                case "julho":
                case "agosto":
                    Console.WriteLine("A estação predominante no mês de " + nomeMes + " é o inverno.");
                    break;

                case "setembro":
                case "outubro":
                case "novembro":
                    Console.WriteLine("A estação predominante no mês de " + nomeMes + " é a primavera.");
                    break;

                default:
                    Console.WriteLine("O mês digitado não é válido.");
                    break;

            }

            Console.ReadKey(); //Segura console
        }
    }
}
