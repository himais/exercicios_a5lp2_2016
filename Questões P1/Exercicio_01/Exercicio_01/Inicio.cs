using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Inicio
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[5]; 
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome da pessoa "+(i+1)+": ");
                nomes[i] = Console.ReadLine(); 
            }

            Lista lista = new Lista(nomes);
            Console.WriteLine("Fim lista");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome da pessoa " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
            }

            Conjunto conj = new Conjunto(nomes);
            Console.WriteLine("Fim Conjunto");

            Console.ReadKey();
        }
    }
}
