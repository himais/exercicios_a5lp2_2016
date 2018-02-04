/*
1 - Faça um programa em C# que apresente ao usuário as opções a seguir, enquanto ele não
digitar a opção 0 (zero). De acordo com o número da opção informado, o programa deverá
efetuar a operação, solicitando as informações necessárias ao usuário. Ao final de cada
operação, a aplicação deve apresentar o resultado ao usuário.
1) Arredondar número – Solicitar ao usuário o valor decimal e a quantidade de casas
decimais.
2) Arredondar para o próximo inteiro menor – Solicitar ao usuário o valor decimal.
3) Arredondar para o próximo inteiro maior – Solicitar ao usuário o valor decimal.
4) Calcular raiz quadrada – Solicitar ao usuário um número maior ou igual a zero.
5) Calcular a potência – Solicitar ao usuário a base e o expoente.*/
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
            int opcaoMenu = 0;
            double numero1;
            int numero2;


            do
            {
                Console.Write("\nSelecione a operação que deseja realizar: \n 1 - Arredondar número \n 2 - Arredondar para o próximo inteiro menor \n 3 - Arredondar para o próximo inteiro maior \n 4 - Calcular raiz quadrada \n 5 - Calcular potência \n 0 - Encerrar\nDigite a opção: ");
                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("\nArredondar número: ");

                        Console.Write("Digite um número decimal: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite a quantidade de casas decimais: ");
                        numero2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Número arredondado: " + System.Math.Round(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine("\nArredondar para o próximo inteiro menor: ");

                        Console.Write("Digite um número decimal: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Número arredondado para o próximo inteiro menor: " + System.Math.Floor(numero1));
                        break;
                    case 3:
                        Console.WriteLine("\nArredondar para o próximo inteiro maior: ");

                        Console.Write("Digite um número decimal: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Número arredondado para o próximo inteiro maior: " + System.Math.Ceiling(numero1));
                        break;
                    case 4:
                        Console.WriteLine("\nCálculo de raiz quadrada: ");

                        Console.Write("Digite um número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("A raiz quadrada de " + numero1 + " é " + System.Math.Sqrt(numero1));
                        break;
                    case 5:
                        Console.WriteLine("\nCálculo de potência: ");

                        Console.Write("Digite a base: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o expoente: ");
                        numero2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("A potência solicitada é " + System.Math.Pow(numero1, numero2));
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar a aplicação. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            } while (opcaoMenu != 0);

            Console.ReadKey();
        }
    }
}
