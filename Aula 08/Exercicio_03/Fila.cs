using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Fila
    {
        Queue<string> fila = new Queue<string>();

        public void enfileirar(string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                fila.Enqueue(valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void desenfileirar()
        {
            if (fila.Count != 0)
            {
                fila.Dequeue();
                Console.WriteLine("O elemento foi removido da fila. ");
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }
        }

        public void imprimirFila()
        {
            if (fila.Count != 0)
            {
                foreach (string elementos in fila)
                {
                    Console.Write(elementos + ", ");
                }
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }
        }
    }
}
