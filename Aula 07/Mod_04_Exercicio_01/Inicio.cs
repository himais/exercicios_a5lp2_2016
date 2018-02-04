/*
1 - Faça um programa console em C# que utilize os seguintes conceitos de programação
orientada a objetos: classes, objetos, atributos e métodos. A aplicação deve possuir as
seguintes classes:
 Produto – Classe que contém os atributos privados (codigo, descricao, preco e ativo),
além dos métodos públicos get e set. Os métodos get devem retornar os respectivos
valores dos atributos da classe Produto. Os métodos set devem atribuir os valores
recebidos como argumento aos respectivos atributos da classe.
 Inicio – Classe que contém o método Main. Deve ser criado um objeto Produto que
chamará os métodos get e set da classe Produto. Use os métodos set para atribuir os
valores informados pelo usuário aos atributos da classe Produto, e os métodos get para
apresentar seus novos valores ao usuário.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_04_Exercicio_01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int codigo;
            string descricao;
            double preco;
            bool ativo, erro = false;

            Produto produto = new Produto();

            try
            {
                Console.Write("Digite o código do produto: ");
                codigo = int.Parse(Console.ReadLine());
                produto.setCodigo(codigo);

                Console.Write("Digite a descrição do produto: ");
                descricao = Console.ReadLine();
                produto.setDescricao(descricao);

                Console.Write("Digite o preço do produto: ");
                preco = Double.Parse(Console.ReadLine());
                produto.setPreco(preco);

                Console.Write("Informe se o produto está ativo ou não (true/false): ");
                ativo = Convert.ToBoolean(Console.ReadLine());
                produto.setAtivo(ativo);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                erro = true; 
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                erro = true;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                erro = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                erro = true;
            }
            finally
            {
                Console.WriteLine("Fim da inserção de produto. ");
            }

            if (!erro)
            {
                Console.WriteLine("\nDados da classe produto: ");
                Console.WriteLine("  Código: " + produto.getCodigo());
                Console.WriteLine("  Descrição: " + produto.getDescricao());
                Console.WriteLine("  Preço: " + produto.getPreco());
                Console.WriteLine("  Ativo: " + (produto.getAtivo() ? "Sim" : "Não"));
            }            

            Console.ReadKey();
        }
    }
}
