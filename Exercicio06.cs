using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio06
    {
        public static void Executar()
        { 
            Console.WriteLine("Digite um número:");
            double number = double.Parse(Console.ReadLine());

            if (number >= 50 && number <= 100){
                Console.WriteLine($"O número {number} está entre os números 50 e 100!");
            } else {
                Console.WriteLine($"O número {number} nâo está entre os números 50 e 100 :(");
            }

            

        }
    }
}
