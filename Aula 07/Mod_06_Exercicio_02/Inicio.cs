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

            try
            {
                do
                {
                    Console.Write("Escolha uma opção: \n 1 - Retângulo \n 2 - Círculo\n 3 - Triângulo Equilátero\n 0 - Sair\nDigite: ");
                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        opcao = -1;
                    }

                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Retângulo: ");

                                Console.Write("Digite a base: ");
                                bs = double.Parse(Console.ReadLine());

                                Console.Write("Digite a altura: ");
                                altura = double.Parse(Console.ReadLine());

                                Console.Write("Digite a cor: ");
                                cor = Console.ReadLine();

                                Retangulo retangulo = new Retangulo(bs, altura, cor);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArithmeticException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }

                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Círculo: ");

                                Console.Write("Digite o raio: ");
                                raio = double.Parse(Console.ReadLine());

                                Console.Write("Digite a cor: ");
                                cor = Console.ReadLine();

                                Circulo circulo = new Circulo(raio, cor);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArithmeticException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.WriteLine("Triângulo equilátero: ");

                                Console.Write("Digite a medida do lado: ");
                                lado = double.Parse(Console.ReadLine());

                                Console.Write("Digite a cor: ");
                                cor = Console.ReadLine();

                                Triangulo triangulo = new Triangulo(lado, cor);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArithmeticException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }
                            break;
                        case 0:
                            Console.WriteLine("Você escolheu encerrar a aplicação. ");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Opção do menu", "Opção inválida. ");
                    }

                    Console.WriteLine();

                } while (opcao != 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

