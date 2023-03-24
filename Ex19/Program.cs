using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//19 - Crie um programa que exiba na tela a sequência de números primos até 100.

namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos até 100:");

            for (int i = 2; i <= 100; i++)
            {
                bool primo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.Write($"{i},");
                }
            }

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();

        }
    }
}
