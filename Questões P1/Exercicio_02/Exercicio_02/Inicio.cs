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
            int opcao = 0;
            double valor;

            do
            {
                Console.WriteLine("Digite 1 para calcular raiz quadradada, 2 para calcular potência e 0 para sair.");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    opcao = -1;
                    Console.WriteLine("Digite apenas números");
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor: ");
                        try
                        {
                            valor = double.Parse(Console.ReadLine());
                            Raiz raiz = new Raiz();
                            Console.WriteLine("Resultado do cálculo de raiz quadrada: " + raiz.Calcular(valor));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Digite apenas números");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("O argumento inserido não é válido");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 2:
                        Console.Write("Digite o valor: ");
                        try
                        {
                            valor = double.Parse(Console.ReadLine());
                            Potencia pot = new Potencia();
                            Console.WriteLine("Resultado da potência: " + pot.Calcular(valor));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Digite apenas números");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("O argumento inserido não é válido");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 0:
                        Console.WriteLine("você escolheu sair.");
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
