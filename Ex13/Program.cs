using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//13 - Crie um programa que solicite ao usuário um número e exiba na tela a tabuada desse número, de 1 a 10.

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                double resultado = numero * i;

                Console.WriteLine("Valores multiplicados: ");
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();

        }
    }
}
