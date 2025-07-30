using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio03
    {
        public static void Executar()
        {

            // Verificador de ano bissexto

            Console.WriteLine("Digite algum ano: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) 
            {
                Console.WriteLine($"O ano {year} é um ano bissexto");
            } else 
            {
                Console.WriteLine($"O ano {year} não é um ano bissexto");
            }

            // P.S.: O % usado no código serve para retornar o resto da divisão
        }
    }
}
