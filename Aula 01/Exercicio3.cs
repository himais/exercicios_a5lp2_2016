using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double distancia = 0;
            double preco = 0;
            double consumo = 0;
            double gasto = 0;

            //Propósito da aplicação 
            Console.WriteLine("Cálculo do gasto de combustível");

            //Capturando a distância percorrida
            Console.WriteLine("Entre com a distancia percorrida:");
            distancia = double.Parse(Console.ReadLine());

            //Capturando o preço do combustível 
            Console.WriteLine("Entre com o preço do combustível:");
            preco = double.Parse(Console.ReadLine());

            //Capturando o consumo do veículo 
            Console.WriteLine("Entre com o consumo de combustível do veículo:");
            consumo = double.Parse(Console.ReadLine());

            //Calculando o gasto 
            gasto = (distancia / consumo) * preco;

            //Exibição dos resultados
            Console.WriteLine("Total gasto com a viagem: " + gasto);
            Console.ReadKey(); //Segura console
        }
    }
}
