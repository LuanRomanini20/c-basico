using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//25 - Crie um programa que solicite ao usuário uma palavra e exiba na tela se ela é um palíndromo ou não.

namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {

                bool palindromo = true;

                Console.Write("Digite uma palavra: ");
                string palavra = Console.ReadLine();

                for (int i = 0; i < palavra.Length / 2; i++)
                {
                    if (palavra[i] != palavra[palavra.Length - i - 1])
                    {
                        palindromo = false;
                        break;
                    }
                }

                if (palindromo)
                {
                    Console.WriteLine($"{palavra} é um palíndromo!");
                }
                else
                {
                    Console.WriteLine($"{palavra} não é um palíndromo.");
                }

                Console.WriteLine("Quer outra palavra?: SIM (0) NAO (-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();


            } while (valor != -1);

            Console.WriteLine("ENTER para encerrar!");
            Console.ReadLine();
        }
    }
}
