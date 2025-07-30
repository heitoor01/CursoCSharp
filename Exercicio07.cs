using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio07
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());

            switch (number) {
                case 1:
                    Console.WriteLine("Hoje é domingo");
                break;
                case 2:
                    Console.WriteLine("Hoje é segunda");
                break;
                case 3:
                    Console.WriteLine("Hoje é terça");
                break;
                case 4:
                    Console.WriteLine("Hoje é quarta");
                    break;
                case 5:
                    Console.WriteLine("Hoje é quinta");
                break;
                case 6:
                    Console.WriteLine("Hoje é sábado");
                break;
                default:
                    Console.WriteLine("Número inválido");
                break;

            }
                
        }
    }
}
