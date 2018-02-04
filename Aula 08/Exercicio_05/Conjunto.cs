using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Conjunto
    {
        HashSet<string> conjunto1 = new HashSet<string>();
        HashSet<string> conjunto2 = new HashSet<string>();

        public void addElementoConjunto1(string valorElemento1)
        {
            if (valorElemento1.Length != 0) {
                conjunto1.Add(valorElemento1);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void addElementoConjunto2(string valorElemento2)
        {
            if (valorElemento2.Length != 0) {
                conjunto2.Add(valorElemento2);
                Console.WriteLine("Elemento adicionado.");
            }
            else { Console.WriteLine("A string digitada é inválida."); }
        }

        public void removerElementoConjunto1(string valorElemento)
        {
            if (conjunto1.Count != 0 && valorElemento.Length != 0)
            {
                if (conjunto1.Contains(valorElemento))
                {
                    conjunto1.Remove(valorElemento);
                    Console.WriteLine("Elemento removido.");
                }else
                    Console.WriteLine("O elemento digitado não existe no conjunto.");
            }
            else { Console.WriteLine("O conjunto está vazio ou o elemento passado é inválido."); }
        }

        public void removerElementoConjunto2(string valorElemento)
        {
            if (conjunto2.Count != 0 && valorElemento.Length != 0) {
                if (conjunto2.Contains(valorElemento))
                {
                    conjunto2.Remove(valorElemento);
                    Console.WriteLine("Elemento removido.");
                }else
                    Console.WriteLine("O elemento digitado não existe no conjunto.");
            }
            else { Console.WriteLine("O conjunto está vazio ou o elemento passado é inválido."); }
        }

        public void elementosEmComum()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0) {
                HashSet<string> conjuntoAux = new HashSet<string>();
                conjuntoAux = conjunto1;
                conjunto1.IntersectWith(conjunto2);

                //exibe elementos em comum
                Console.WriteLine("Elementos em comum:");
                foreach (string elementos in conjunto1)
                {
                    Console.Write(elementos + ", ");
                }

                conjunto1 = conjuntoAux;
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void juntarElementos()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0)
            {
                conjunto1.UnionWith(conjunto2);
                Console.WriteLine("Os elementos dos dois conjuntos agora estão contidos no conjunto 1.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void subtrairElementosConjunto1()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0)
            {
                conjunto1.ExceptWith(conjunto2);
                Console.WriteLine("Os elementos foram subtraídos do conjunto.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void subtrairElementosConjunto2()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0)
            {
                conjunto2.ExceptWith(conjunto1);
                Console.WriteLine("Os elementos foram subtraídos do conjunto.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void verificarConjunto1Contido()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0)
            {
                Console.WriteLine((conjunto1.IsSubsetOf(conjunto2)) ? "O conjunto 1 está contido no conjunto 2." : "O conjunto 1 não está contido no conjunto 2.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void verificarConjunto2Contido()
        {
            if (conjunto1.Count != 0 && conjunto2.Count != 0)
            {
                Console.WriteLine((conjunto2.IsSubsetOf(conjunto1)) ? "O conjunto 2 está contido no conjunto 1." : "O conjunto 2 não está contido no conjunto 1.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void verificarSeConjunto1Contem()
        {
            if (conjunto1.Count != 0)
            {
                Console.WriteLine((conjunto1.IsSupersetOf(conjunto2)) ? "O conjunto 1 contém o conjunto 2." : "O conjunto 1 não contém o conjunto 2.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void verificarSeConjunto2Contem()
        {
            if (conjunto2.Count != 0)
            {
                Console.WriteLine((conjunto2.IsSupersetOf(conjunto1)) ? "O conjunto 2 contém o conjunto 1." : "O conjunto 2 não contém o conjunto 1.");
            }
            else { Console.WriteLine("Um ou mais conjunto(s) está(estão) vazio(s)."); }
        }

        public void imprimirConjuntos()
        {
            Console.WriteLine("Conjunto 1: ");
            if (conjunto1.Count != 0)
            {
                foreach (string elementos in conjunto1)
                {
                    Console.Write(elementos + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O conjunto 1 está vazio.");
            }

            Console.WriteLine("Conjunto 2: ");
            if (conjunto2.Count != 0)
            {
                foreach (string elementos in conjunto2)
                {
                    Console.Write(elementos + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O conjunto 2 está vazio.");
            }
        }
    }
}
