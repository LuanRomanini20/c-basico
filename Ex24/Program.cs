using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//24 - Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número palíndromo ou não.


namespace Ex24
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

                int reverso = 0;
                int normal = numero;

                while (numero != 0)
                {
                    int digito = numero % 10;
                    reverso = reverso * 10 + digito;
                    numero /= 10;
                }

                if (normal == reverso)
                {
                    Console.WriteLine($"{normal} é um número palíndromo!");
                }
                else
                {
                    Console.WriteLine($"{normal} não é um número palíndromo.");
                }

                Console.WriteLine("Quer outro numero?: SIM (0) NAO (-1)");
                valor = int.Parse(Console.ReadLine());

            } while (valor != -1);

            Console.WriteLine("ENTER para encerrar!");
            Console.ReadLine();
        }
    }
}
