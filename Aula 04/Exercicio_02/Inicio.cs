/*
2 - Faça uma cópia do programa anterior e modifique-o para que passe a usar propriedades ao
invés dos métodos get e set. As propriedades devem ser usadas na forma simplificada, por
exemplo: public int codigo {get; set; }.
*/
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
            int codigo;
            string descricao;
            double preco;
            bool ativo;

            Produto produto = new Produto();

            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            produto.codigo = codigo;

            Console.Write("Digite a descrição do produto: ");
            descricao = Console.ReadLine();
            produto.descricao = descricao;

            Console.Write("Digite o preço do produto: ");
            preco = Double.Parse(Console.ReadLine());
            produto.preco = preco;

            Console.Write("Informe se o produto está ativo ou não (true/false): ");
            ativo = Convert.ToBoolean(Console.ReadLine());
            produto.ativo = ativo;


            Console.WriteLine("\nDados da classe produto: ");
            Console.WriteLine("  Código: " + produto.codigo);
            Console.WriteLine("  Descrição: " + produto.descricao);
            Console.WriteLine("  Preço: " + produto.preco);
            Console.WriteLine("  Ativo: " + (produto.ativo ? "Sim" : "Não"));

            Console.ReadKey();
        }
    }
}
