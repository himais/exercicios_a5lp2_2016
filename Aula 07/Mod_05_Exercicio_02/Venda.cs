/*Faça um programa em C# que leia os valores das vendas de uma loja nos últimos seis
meses e acumule o valor total em um atributo estático por meio de um método dinâmico,
o qual será chamado por um objeto v1 do tipo Venda. Ao final, apresente o valor total das
vendas ao usuário por meio de outro método dinâmico, o qual será chamado por um
objeto v2, também do tipo Venda. Transforme o atributo estático em dinâmico, execute
novamente o programa e veja se o resultado foi alterado.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_05_Exercicio_02
{
    class Venda
    {
        private static double valor = 0;
        //private double valor = 0;

        public void setValor(double num)
        {
            if (num < 0)
                throw new ArgumentException("É necessário informar um valor válido. ");
            valor += num;
        }

        public double getValor()
        {
            return valor;
        }
    }
}
