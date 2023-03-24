using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16 - Crie um programa que solicite ao usuário um número e exiba na tela a sequência de Fibonacci até esse número.

namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int primeiroNumero = 0;
            int segundoNumero = 1;
            int proximoNumero = 0;

            Console.Write($"Sequência de Fibonacci até o número {numero}: {primeiroNumero}, {proximoNumero}");

            proximoNumero = primeiroNumero + segundoNumero;

            while (proximoNumero <= numero)
            {
                Console.Write($", {proximoNumero}");
                primeiroNumero = segundoNumero;
                segundoNumero = proximoNumero;
                proximoNumero = primeiroNumero + segundoNumero;
            }

            
            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();

        }
    }
}
