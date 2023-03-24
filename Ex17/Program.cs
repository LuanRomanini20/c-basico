using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17 - Crie um programa que solicite ao usuário um número e exiba na tela se esse número é primo ou não.

// EX 4


namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {

                Console.WriteLine("Digite um número:  ");
                double num = double.Parse(Console.ReadLine());


                bool nprimo = true;


                if (num <= 1)
                {
                    nprimo = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            nprimo = false;
                            break;
                        }
                    }
                }

                if (nprimo)
                {
                    Console.WriteLine(num + " é um número primo.");
                }
                else
                {
                    Console.WriteLine(num + " não é um número primo.");
                }

                Console.WriteLine($"Gostaria de ver outro numero? SIM (0)   NAO(-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();


            } while (valor != -1);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
