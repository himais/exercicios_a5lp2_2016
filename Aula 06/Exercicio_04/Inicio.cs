using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao;
            DateTime dataInicial, dataFinal; 

            do
            {
                Console.Write("Escolha uma opção: \n 1 - Calcular dias \n 2 - Calcular horas\n 0 - Sair\nDigite: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Calcular dias: ");
                        Console.WriteLine("Digite a data e hora inicial (dd/mm/yy hh:mm) ");
                        dataInicial = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a data e hora final (dd/mm/yy hh:mm) ");
                        dataFinal = DateTime.Parse(Console.ReadLine());

                        Dia dia = new Dia(dataInicial, dataFinal); 
                        break;
                    case 2:
                        Console.WriteLine("Calcular horas: ");
                        Console.WriteLine("Digite a data e hora inicial (dd/mm/yy hh:mm) ");
                        dataInicial = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a data e hora final (dd/mm/yy hh:mm) ");
                        dataFinal = DateTime.Parse(Console.ReadLine());

                        Hora hora = new Hora(dataInicial, dataFinal);
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
