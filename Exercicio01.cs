using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            // Verificar se o número é positivo, negativo ou zero

            Console.WriteLine("Digite um número: ");
            double number = double.Parse(Console.ReadLine());


            if (number > 0)
            {
                Console.WriteLine($"O número {number} é positivo");
            } else if ( number == 0)
            {
                Console.WriteLine($"O número {number} é igual a zero");
            } else
            {
                Console.WriteLine($" O número {number} é negativo");
            }

        }
    }
}
