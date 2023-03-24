using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//21 - Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número triangular ou não.

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int n = 1;
            while (numero > 0)
            {
                numero -= n;
                n++;
            }

            if (numero == 0)
            {
                Console.WriteLine("O número é triangular!");
            }
            else
            {
                Console.WriteLine("O número não é triangular!");
            }

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
