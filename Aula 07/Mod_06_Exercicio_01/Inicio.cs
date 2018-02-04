using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_06_Exercicio_01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao;
            DateTime dataInicial, dataFinal;

            try
            {
                do
                {
                    Console.Write("Escolha uma opção: \n 1 - Calcular dias \n 2 - Calcular horas\n 0 - Sair\nDigite: ");
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
                                Console.WriteLine("Calcular dias: ");
                                Console.WriteLine("Digite a data e hora inicial (dd/mm/yy hh:mm) ");
                                dataInicial = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a data e hora final (dd/mm/yy hh:mm) ");
                                dataFinal = DateTime.Parse(Console.ReadLine());

                                Dia dia = new Dia(dataInicial, dataFinal);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e)
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
                                Console.WriteLine("Calcular horas: ");
                                Console.WriteLine("Digite a data e hora inicial (dd/mm/yy hh:mm) ");
                                dataInicial = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a data e hora final (dd/mm/yy hh:mm) ");
                                dataFinal = DateTime.Parse(Console.ReadLine());

                                Hora hora = new Hora(dataInicial, dataFinal);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (ArgumentException e)
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
