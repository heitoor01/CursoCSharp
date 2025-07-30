using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio05
    {
        public static void Executar()
        {
            int option = 0;
            while (option != 3)
            {
                Console.WriteLine("Menu Interativo:");
                Console.WriteLine("1 - Dizer Olá");
                Console.WriteLine("2 - Mostrar Data e Hora");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                // Tenta converter a entrada do usuário para int
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Olá! Espero que esteja bem! :)\n");
                            break;
                        case 2:
                            Console.WriteLine($"Data e hora atual: {DateTime.Now}\n");
                            break;
                        case 3:
                            Console.WriteLine("Saindo... Até logo!\n");
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente!\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido!\n");
                }
            }
        }
    }
}
