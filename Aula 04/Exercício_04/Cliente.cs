/*
Cliente – Classe que contém os atributos privados (vetorCodigo[10], vetorNome[10] e
vetorCpf[10]), além dos métodos públicos:
bool inserirCliente(int codigo, string nome, string cpf)
void setCodigo(int codigo)
void setNome(int codigo, string nome)
void setCpf(int codigo, string cpf)
int[] getVetorCodigo()
string[] getVetorNome()
string[] getVetorCpf() 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Cliente
    {
        private int[] vetorCodigo = new int[10];
        private string[] vetorNome = new string[10];
        private string[] vetorCpf = new string[10];

        public bool inserirCliente(int codigo, string nome, string cpf)
        {
            if(nome.Contains(" ") && cpf.Length == 11)
            {
                setCodigo(codigo);
                setNome(codigo, nome);
                setCpf(codigo, cpf);

                return true;
            }

            return false;
        }

        public void setCodigo(int codigo)
        {
            this.vetorCodigo[codigo - 1] = codigo; 

        }

        public void setNome(int codigo, string nome)
        {
            this.vetorNome[codigo - 1] = nome;
        }

        public void setCpf(int codigo, string cpf)
        {
            this.vetorCpf[codigo - 1] = cpf;
        }

        public int[] getVetorCodigo()
        {
            return this.vetorCodigo;
        }

        public string[] getVetorNome()
        {
            return this.vetorNome;
        }

        public string[] getVetorCpf()
        {
            return this.vetorCpf;
        }
    }
}
