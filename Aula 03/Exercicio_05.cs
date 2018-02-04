/*
5. Faça um programa em C# que leia uma string e apresente ao usuário as opções a seguir,
enquanto ele não digitar a opção 0 (zero). De acordo com o número da opção informado, o
programa deverá efetuar a operação. Ao final de cada operação, a aplicação deve
apresentar o valor convertido ao usuário.
1) Converter para int
2) Converter para long
3) Converter para float
4) Converter para double
5) Converter para DateTime (data)
6) Converter para DateTime (hora)
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
            int opcaoMenu = 0;
            string dado;

            do
            {
                Console.Write("\nEntre com um dado: ");
                dado = Console.ReadLine();

                Console.Write("\nSelecione a operação que deseja realizar: \n 1 - Converter para int \n 2 - Converter para long \n 3 - Converter para float \n 4 - Converter para double \n 5 - Converter para DateTime(data)\n 6 - Converter para DateTime(hora) \n 0 - Encerrar aplicação\n Digite: ");
                opcaoMenu = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Converter para int");
                        Console.WriteLine("string -> int: " + int.Parse(dado));
                        break;
                    case 2:
                        Console.WriteLine("Converter para long");
                        Console.WriteLine("string -> long: " + long.Parse(dado));
                        break;
                    case 3:
                        Console.WriteLine("Converter para float");
                        Console.WriteLine("string -> float: " + float.Parse(dado));
                        break;
                    case 4:
                        Console.WriteLine("Converter para double");
                        Console.WriteLine("string -> double: " + double.Parse(dado));
                        break;
                    case 5:
                        Console.WriteLine("Converter para DateTime(data)");
                        Console.WriteLine("string -> DateTime(data): " + DateTime.Parse(dado));
                        break;
                    case 6:
                        Console.WriteLine("Converter para DateTime(hora)");
                        Console.WriteLine("string -> DateTime(hora): " + DateTime.Parse(dado).Hour + ":" + DateTime.Parse(dado).Minute);
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar o programa. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }
            } while (opcaoMenu != 0);
            Console.ReadKey();
        }
    }
}
