/*
3 - Faça um programa em C# que leia uma data e uma hora e, em seguida, apresente ao
usuário as opções a seguir, enquanto ele não digitar a opção 0 (zero). De acordo com o
número da opção informado, o programa deverá efetuar a operação, solicitando as
informações necessárias ao usuário. Ao final de cada operação, a aplicação deve
apresentar a nova data/hora ao usuário.
1) Adicionar dias – Solicitar ao usuário quantos dias devem ser adicionados.
2) Adicionar meses – Solicitar ao usuário quantos meses devem ser adicionados.
3) Adicionar anos – Solicitar ao usuário quantos anos devem ser adicionados.
4) Adicionar horas – Solicitar ao usuário quantas horas devem ser adicionadas.
5) Adicionar minutos – Solicitar ao usuário quantos minutos devem ser adicionados.
6) Subtrair dias – Solicitar ao usuário quantos dias devem ser subtraídos.
7) Subtrair meses – Solicitar ao usuário quantos meses devem ser subtraídos.
8) Subtrair anos – Solicitar ao usuário quantos anos devem ser subtraídos.
9) Subtrair horas – Solicitar ao usuário quantas horas devem ser subtraídas.
10) Subtrair minutos – Solicitar ao usuário quantos minutos devem ser subtraídos.
11)Obter dia da semana 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 0;
            int dia, mes, ano, hora, minuto;
            int manipulacaoUsuario;

            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            mes = int.Parse(Console.ReadLine()); 

            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());

            DateTime data = new DateTime(ano, mes, dia);

            Console.Write("Hora: ");
            hora = int.Parse(Console.ReadLine());
            data = data.AddHours(hora);

            Console.Write("Minuto: ");
            minuto = int.Parse(Console.ReadLine());
            data = data.AddMinutes(minuto);

            Console.WriteLine("\nData inserida: " + data.ToString("dd/MM/yyyy hh:mm"));

            do
            {
                manipulacaoUsuario = 0; 

                Console.WriteLine("\nSelecione a operação que deseja realizar: ");
                Console.WriteLine(" 1 - Adicionar dias \n 2 - Adicionar meses \n 3 - Adicionar anos \n 4 - Adicionar horas \n 5 - Adicionar minutos \n 6 - Subtrair dias \n 7 - Subtrair meses \n 8 - Subtrair anos \n 9 - Subtrair horas \n 10 - Subtrair minutos \n 11 - Obter dia da semana\n 0 - Encerrar");
                Console.Write("Digite a opção: ");
                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("\nAdicionar dias: ");

                        Console.Write("Digite o número de dias que deseja adicionar:  ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddDays(manipulacaoUsuario);

                        break;
                    case 2:
                        Console.WriteLine("\nAdicionar meses: ");

                        Console.Write("Digite o número de meses que deseja adicionar:  ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddMonths(manipulacaoUsuario);
                        break;
                    case 3:
                        Console.WriteLine("\nAdicionar anos: ");

                        Console.Write("Digite o número de anos que deseja adicionar: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddYears(manipulacaoUsuario);
                        break;
                    case 4:
                        Console.WriteLine("\nAdicionar horas: ");

                        Console.Write("Digite o número de horas que deseja adicionar: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddHours(manipulacaoUsuario);
                        break;
                    case 5:
                        Console.WriteLine("\nAdicionar minutos: ");

                        Console.Write("Digite o número de minutos que deseja adicionar: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddMinutes(manipulacaoUsuario);
                        break;
                    case 6:
                        Console.WriteLine("\nSubtrair dias: ");

                        Console.Write("Digite o número de dias que deseja subtrair: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddDays(manipulacaoUsuario * -1);
                        break;
                    case 7:
                        Console.WriteLine("\nSubtrair meses: ");

                        Console.Write("Digite o número de meses que deseja subtrair: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddMonths(manipulacaoUsuario * -1);
                        break;
                    case 8:
                        Console.WriteLine("\nSubtrair anos: ");

                        Console.Write("Digite o número de anos que deseja subtrair: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddYears(manipulacaoUsuario * -1);
                        break;
                    case 9:
                        Console.WriteLine("\nSubtrair horas: ");

                        Console.Write("Digite o número de horas que deseja subtrair: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddHours(manipulacaoUsuario * -1);
                        break;
                    case 10:
                        Console.WriteLine("\nSubtrair minutos: ");

                        Console.Write("Digite o número de minutos que deseja subtrair: ");
                        manipulacaoUsuario = int.Parse(Console.ReadLine());

                        data = data.AddMinutes(manipulacaoUsuario * -1);
                        break;
                    case 11:
                        Console.WriteLine("\nObter dia da semana: ");
                        Console.WriteLine("\nData atual: " + data.ToString("dddd, dd/MM/yyyy"));

                        break;
                    case 0:
                        Console.WriteLine("Você escolheu sair.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }


                if (opcaoMenu < 11 && opcaoMenu != 0) Console.WriteLine("\nNova data : " + data.ToString("dd/MM/yyyy hh:mm"));

            } while (opcaoMenu != 0);

            Console.ReadKey();
        }
    }
}
