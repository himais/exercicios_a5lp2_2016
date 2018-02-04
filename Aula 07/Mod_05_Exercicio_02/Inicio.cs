using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_02
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Venda v1 = new Venda();
            Console.WriteLine("Informe os valores das vendas: ");
            try
            {
                for(int i = 1; i <= 6; i++)
                {
                    Console.Write("Mês "+i+": ");
                    v1.setValor(int.Parse(Console.ReadLine()));
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Fim da inserção dos valores das vendas. ");
            }

            Venda v2 = new Venda();

            Console.WriteLine("Valor total: " + v2.getValor());

            Console.ReadKey();

        }
    }
}
