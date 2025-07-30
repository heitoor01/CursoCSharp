using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio09
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número ");
            int number;

            // Garante que o usuário digitou um número válido
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                long fatorial = 1; // Usa Long para suportar números grandes

                for (int i = number; i >= 1; i--)
                {
                    fatorial *= i; // Multiplica o fatorial pelo valor de i
                }
                Console.WriteLine($"O fatorial de {number} é {fatorial}.");
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor inteiro e não negativo!");
            }
        }
    }
}
