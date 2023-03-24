using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            do
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write($"{numero} = ");

                for (int i = 2; i <= numero; i++)
                {
                    while (numero % i == 0)
                    {
                        Console.Write(i);
                        numero /= i;

                        if (numero != 1)
                        {
                            Console.Write(" x ");
                        }
                    }
                }

                Console.WriteLine("\nDigite - 1 para finalizar o programa");
                valor =  int.Parse(Console.ReadLine());


            } while (valor != -1);

            Console.WriteLine("ENTER para encerrar!");
            Console.ReadLine();
        }
    }
}
