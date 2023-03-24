using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//20 - Crie um programa que solicite ao usuário um número e exiba na tela a sua tabuada de multiplicação e de divisão, de 1 a 10.



namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine());

            for (double i = 1; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i} \t {numero} / {i} = {numero / (double)i}");
            }

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
