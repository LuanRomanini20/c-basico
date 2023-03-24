using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15 - Crie um programa que solicite ao usuário um número e exiba na tela se esse número é positivo, negativo ou zero.

//Parecida com a 6

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                Console.WriteLine("Digite um numero inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine($"O numero {numero} é POSITIVO!");
                }
                else if (numero < 0)
                {
                    Console.WriteLine($"O numero {numero} é NEGATIVO!");
                }
                else
                {
                    Console.WriteLine($"O numero {numero} é ZERO!");
                }

                Console.WriteLine("Deseja ver outro numero: SIM(1)  NAO(0)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (valor != 0);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
