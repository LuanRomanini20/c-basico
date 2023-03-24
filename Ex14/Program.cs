using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//14 - Crie um programa que solicite ao usuário um número e exiba na tela se esse número é par ou ímpar.

//Exercicio parecido com a 2

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int numero = 7;

            do
            {


                Console.WriteLine("Informe um valor inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O numero {numero}, é par!");
                }
                else
                {
                    Console.WriteLine($"O numero {numero}, é impar!");
                }


                Console.WriteLine("Gostaria de escolher outro numero? SIM (0)   NAO (-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (valor != -1);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
