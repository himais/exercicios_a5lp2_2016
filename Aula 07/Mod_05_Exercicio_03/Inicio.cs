/*
3 - Faça um programa em C# que apresente ao usuário as opções a seguir, enquanto ele não
digitar a opção 0 (zero). De acordo com o número da opção informada, o programa deverá
efetuar a operação, solicitando as informações necessárias ao usuário.
1) Calcular raiz quadrada – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(double num) da classe Calculo.
2) Calcular potenciação – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(double base, double expoente) da classe Calculo.
3) Calcular fatorial – Deverá chamar o método sobrecarregado e estático
ExecutarCalculo(int num) da classe Calculo. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao, numero;
            double numerod, expoente;
            Calculo calculo = new Calculo();
            try
            {
                do
                {
                    Console.Write("Escolha uma opção: \n 1 - Calcular raiz quadrada \n 2 - Calcular potenciação \n 3 - Calcular fatorial \n 0 - Sair \nDigite: ");
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
                                Console.Write("Digite um número: ");
                                numerod = double.Parse(Console.ReadLine());
                                calculo.ExecutarCalculo(numerod);
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
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Write("Digite a base: ");
                                numerod = double.Parse(Console.ReadLine());
                                Console.Write("Digite o expoente: ");
                                expoente = double.Parse(Console.ReadLine());
                                calculo.ExecutarCalculo(numerod, expoente);
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
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.Write("Digite um número: ");
                                numero = int.Parse(Console.ReadLine());
                                calculo.ExecutarCalculo(numero);
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
                            finally
                            {
                                Console.WriteLine("Fim do cálculo. ");
                            }
                            break;
                        case 0:
                            Console.WriteLine("Você escolheu encerrar a aplicação.");
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
