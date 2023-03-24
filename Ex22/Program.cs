using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22 - Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número de Armstrong ou não.


namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int soma = 0;
            int tem = numero;

            while (tem > 0)
            {
                int digito = tem % 10;
                soma += (int)Math.Pow(digito, 3);
                tem /= 10;
            }

            if (numero == soma)
            {
                Console.WriteLine("O número é um número de Armstrong!");
            }
            else
            {
                Console.WriteLine("O número não é um número de Armstrong!");
            }

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
