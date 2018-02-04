using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class ListaEncadeada
    {
        private LinkedList<string> listaEncadeada = new LinkedList<string>();

        public void addElementoInicio(string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                listaEncadeada.AddFirst(valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void addElementoFim(string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                listaEncadeada.AddLast(valorElemento);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void addElementoAposNo(string elementoReferencia, string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                if (listaEncadeada.Contains(elementoReferencia))
                {
                    LinkedListNode<string> no = listaEncadeada.Find(elementoReferencia);
                    listaEncadeada.AddAfter(no, valorElemento);
                    Console.WriteLine("Elemento adicionado.");
                }
                else
                {
                    Console.WriteLine("O parâmetro informado não existe na lista.");
                }
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void addElementoAntesNo(string elementoReferencia, string valorElemento)
        {
            if (valorElemento.Length != 0)
            {
                if (listaEncadeada.Contains(elementoReferencia))
                {
                    LinkedListNode<string> no = listaEncadeada.Find(elementoReferencia);
                    listaEncadeada.AddBefore(no, valorElemento);
                    Console.WriteLine("Elemento adicionado.");
                }
                else
                {
                    Console.WriteLine("O parâmetro informado não existe na lista.");
                }
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void verificarElemento(string valorElemento)
        {
            if (listaEncadeada.Contains(valorElemento))
            {
                Console.WriteLine("O Elemento "+valorElemento+" existe na linkedList.");
            }
            else { Console.WriteLine("O Elemento " + valorElemento + " não existe na linkedList."); }
        }

        public void removerElementoPeloValor(string valorElemento)
        {
            if (listaEncadeada.Contains(valorElemento))
            {
                listaEncadeada.Remove(valorElemento);
                Console.WriteLine("O Elemento removido.");
            }
            else { Console.WriteLine("O Elemento " + valorElemento + " não existe na linkedList."); }
        }

        public void removerElementoPelaPosicao(int posicaoElemento)
        {
            if (listaEncadeada.Count > posicaoElemento)
            {
                listaEncadeada.Remove(listaEncadeada.ElementAt(posicaoElemento));
                Console.WriteLine("O Elemento removido.");
            }
            else { Console.WriteLine("A posição informada é inválida."); }
        }

        public void removerPrimeiroElemento()
        {
            if (listaEncadeada.Count != 0)
            {
                listaEncadeada.RemoveFirst();
                Console.WriteLine("O primeiro elemento foi removido.");
            }
            else { Console.WriteLine("A lista está vazia."); }
        }

        public void removerUltimoElemento()
        {
            if (listaEncadeada.Count != 0)
            {
                listaEncadeada.RemoveLast();
                Console.WriteLine("O último elemento foi removido.");
            }
            else { Console.WriteLine("A lista está vazia."); }
        }

        public void removerTodosElementos()
        {
            if (listaEncadeada.Count != 0)
            {
                listaEncadeada.Clear();
                Console.WriteLine("Todos os elementos foram removidos");
            }
            else { Console.WriteLine("A lista está vazia."); }
        }

        public void imprimirInicioParaFim()
        {
            if (listaEncadeada.Count != 0)
            {
                foreach(string elemento in listaEncadeada)
                {
                    Console.Write(elemento+", ");
                }
            }
            else { Console.WriteLine("A lista está vazia."); }
        }

        public void imprimirFimParaInicio()
        {
            if (listaEncadeada.Count != 0)
            {
                for(LinkedListNode<string> no = listaEncadeada.Last; no != null; no = no.Previous)
                {
                    Console.Write(no.Value + ", ");
                }
            }
            else { Console.WriteLine("A lista está vazia."); }
        }
    }
}
