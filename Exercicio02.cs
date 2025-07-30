using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio02
    {
        public static void Executar()
        {

            // Calculadora simples usando (switch)

            Console.WriteLine("Escolha uma operação: 1 - Multiplicação; 2 - Adição; 3 - Subtração; 4 - Divisão;");
            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            double result;

            switch (operation)
            {
                case 1:
                    result = n1 * n2;
                    Console.WriteLine($"O resultado de {n1} * {n2} é: {result}");
                    break;
                case 2:
                    result = n1 + n2;
                    Console.WriteLine($"O resultado de {n1} + {n2} é: {result}");
                    break;
                case 3:
                    result = n1 - n2;
                    Console.WriteLine($"O resultado de {n1} - {n2} é: {result}");
                    break;
                case 4:
                    result = n1 / n2;
                    Console.WriteLine($"O resultado de {n1} ÷ {n2} é: {result}");
                    break;
                default:
                    Console.WriteLine("Operação inexistente");
                    break;
            }
        }

    }
}
