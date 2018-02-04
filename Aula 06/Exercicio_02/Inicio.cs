using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao;
            double bs, altura, raio, lado;
            string cor;

            do
            {
                Console.Write("Escolha uma opção: \n 1 - Retângulo \n 2 - Círculo\n 3 - Triângulo Equilátero\n 0 - Sair\nDigite: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Retângulo: ");

                        Console.Write("Digite a base: ");
                        bs = double.Parse(Console.ReadLine());

                        Console.Write("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());

                        Console.Write("Digite a cor: ");
                        cor = Console.ReadLine();

                        Retangulo retangulo = new Retangulo(bs, altura, cor); 

                        break;
                    case 2:
                        Console.WriteLine("Círculo: ");

                        Console.Write("Digite o raio: ");
                        raio = double.Parse(Console.ReadLine());

                        Console.Write("Digite a cor: ");
                        cor = Console.ReadLine();

                        Circulo circulo = new Circulo(raio, cor);
                        break;
                    case 3:
                        Console.WriteLine("Triângulo equilátero: ");

                        Console.Write("Digite a medida do lado: ");
                        lado = double.Parse(Console.ReadLine());

                        Console.Write("Digite a cor: ");
                        cor = Console.ReadLine();

                        Triangulo triangulo = new Triangulo(lado, cor);
                        break;
                    case 0:
                        Console.WriteLine("Você escolheu encerrar a aplicação. ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}

