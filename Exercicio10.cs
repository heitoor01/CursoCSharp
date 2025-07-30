using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio10
    {
        public static void Executar()
        {
            int a, b, c;
            bool validTriangle = false;

            do
            {
                Console.Write("Digite o valor do lado A: ");
                int.TryParse(Console.ReadLine(), out a);

                Console.Write("Digite o valor do lado B: ");
                int.TryParse(Console.ReadLine(), out b);

                Console.Write("Digite o valor do lado C: ");
                int.TryParse(Console.ReadLine(), out c);

                // Verificação do triângulo: cada lado deve ser menor que a soma dos outros dois
                if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b)
                {
                    validTriangle = true;
                }
                else
                {
                    Console.WriteLine("\nOs valores digitados NÃO formam um triângulo válido. Tente novamente!\n");
                }

            } while (!validTriangle);

            // Identificando o tipo de triângulo

            if (a == b && b == c)
            {
                Console.WriteLine("\nTriângulo Equilátero: todos os lados são iguais.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("\nTriângulo Isósceles: dois lados são iguais.");
            }
            else
            {
                Console.WriteLine("\nTriângulo Escaleno: todos os lados são diferentes.");
            }

        }
    }
}
