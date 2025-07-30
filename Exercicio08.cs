using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio08
    {
        public static void Executar()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // Gera um número entre 1 e 10
            int guesses = 3;
            int currentGuess = 1;
            bool right = false;

            Console.WriteLine("Digite um número de 1 a 10. Você tem três tentativas. ");

            while (currentGuess <= guesses && !right)
            {
                Console.Write($"Tenativa {currentGuess}: Dê o seu palpite:");
                int palpite;

                // Faz a leitura e garante que o usuário digitou um número
                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    if (palpite == secretNumber)
                    {
                        Console.WriteLine("Parabéns! Você acertou!");
                        right = true;
                    }
                    else
                    {
                        Console.WriteLine("Errou!");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido!");
                }
                currentGuess++;
            }
            if (!right)
            {
                Console.WriteLine($"Suas tentativas acabaram. O número secreto era {secretNumber}.");
            }
        }
    }
}
