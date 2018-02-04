using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    abstract class Texto
    {
        private static string texto;

        public void setTexto(string txt)
        {
            texto = txt;
            Console.WriteLine("Texto armazenado.");
        }

        public string getTexto()
        {
            return texto;
        }

        protected abstract void manipularString(string texto, string argumento1, string argumento2);
    }
}
