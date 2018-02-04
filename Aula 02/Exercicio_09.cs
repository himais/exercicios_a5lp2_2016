/*
9 - Escreva um programa console em C# que leia os nomes de 10 pessoas e armazene-os em
um vetor. Em seguida, crie uma consulta onde o usuário informa um nome e o programa
busca a primeira ocorrência deste nome imprimindo a posição dele no vetor. Utilize os
comandos WHILE, IF e BREAK.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    class Exercicio_09
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            string nomePesquisa;
            int contador = 0; 

            //pega valores
            for (int i = 0; i < 10; i++) {
                Console.Write("Nome ["+i+"]: ");
                nomes[i] = Console.ReadLine();
            }

            //pega termo da consulta
            Console.Write("Digite o nome que deseja pesquisar: ");
            nomePesquisa = Console.ReadLine();

            //pesquisa no vetor
            while(contador < 10)
            {
                if(nomes[contador] == nomePesquisa)
                {
                    Console.WriteLine("A primeira ocorrência do nome "+nomePesquisa+" no vetor é na posição "+contador);
                    break;
                }

                contador++;
            }

            Console.ReadKey(); 
        }
    }
}
