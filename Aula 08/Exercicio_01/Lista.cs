using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    class Lista
    {
        List<string> lista = new List<string>();

        public void addElemento(string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                lista.Add(valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
       }

        public void addElementoEmPosicao(int posicao, string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                lista.Insert(posicao, valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
        }

        public void removerElementoPorValor(string valorElemento)
        {
            lista.Remove(valorElemento);
            if (lista.Count != 0)
            {
                lista.Remove(valorElemento);
                Console.WriteLine("Elemento removido.");
            }
            else
            {
                Console.WriteLine("A lista está vazia. ");
            }
        }

        public void removerElementoPorPosicao(int posicao)
        {
            if (lista.Count != 0)
            {
                lista.RemoveAt(posicao);
                Console.WriteLine("Elemento removido.");
            }
            else
            {
                Console.WriteLine("A lista está vazia. ");
            }
        }

        public void ordenarLista()
        {
            if (lista.Count != 0)
            {
                lista.Sort();
                Console.WriteLine("A lista foi ordenada. ");
            }
            else
            {
                Console.WriteLine("A lista está vazia. ");
            }
        }

        public void imprimirLista()
        {
            if (lista.Count != 0)
            {
                foreach (string elementos in lista)
                {
                    Console.Write(elementos + ", ");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia. ");
            }
        }
    }
}
