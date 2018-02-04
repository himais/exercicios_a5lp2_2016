/*
3 - Faça uma cópia do programa anterior e modifique as propriedades para a forma não
simplificada. Inclua verificações nos métodos set para que os atributos possam ser
modificados somente se cumprirem determinadas condições. Inclua um construtor e um
destrutor na classe Produto. No construtor, inicialize os atributos da classe. No destrutor,
apenas emita uma mensagem ao usuário.
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
            int codigo;
            string descricao;
            double preco;
            bool ativo;

            Produto produto = new Produto();

            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            produto.Codigo = codigo;

            Console.Write("Digite a descrição do produto: ");
            descricao = Console.ReadLine();
            produto.Descricao = descricao;

            Console.Write("Digite o preço do produto: ");
            preco = Double.Parse(Console.ReadLine());
            produto.Preco = preco;

            Console.Write("Informe se o produto está ativo ou não (true/false): ");
            ativo = Convert.ToBoolean(Console.ReadLine());
            produto.Ativo = ativo;


            Console.WriteLine("\nDados da classe produto: ");
            Console.WriteLine("  Código: " + produto.Codigo);
            Console.WriteLine("  Descrição: " + produto.Descricao);
            Console.WriteLine("  Preço: " + produto.Preco);
            Console.WriteLine("  Ativo: " + (produto.Ativo ? "Sim" : "Não"));

            Console.ReadKey();
        }
    }
}
