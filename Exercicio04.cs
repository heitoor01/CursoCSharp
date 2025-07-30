using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            int biggest = int.MinValue; // Começa com o menor valor possível de int
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                if (num > biggest)
                {
                    biggest = num; // Atualiza se o número for maior
                }
            }
            Console.WriteLine($"O maior número digitado é o {biggest}");
        }
    }
}
