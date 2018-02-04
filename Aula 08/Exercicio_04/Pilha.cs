using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Pilha
    {
        Stack<string> pilha = new Stack<string>();

        public void empilhar(string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                pilha.Push(valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void desempilhar()
        {
            if (pilha.Count != 0)
            {
                pilha.Pop();
                Console.WriteLine("O elemento foi removido da pilha. ");
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }
        }

        public void imprimirPilha()
        {
            if (pilha.Count != 0)
            {
                foreach (string elementos in pilha)
                {
                    Console.Write(elementos + ", "); 
                }
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }
        }
    }
}
