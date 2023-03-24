using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


//7-Faça um programa que calcule o fatorial de um número informado pelo usuário.


namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 0;
            do
            {
                Console.WriteLine("Informe um numero inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                int cal = numero;

                for (int i = 1; i < numero; i++)
                {
                    cal *= i;
                }

                Console.WriteLine($"Calculo fatorial: {cal}");


                Console.WriteLine("Gostaria de realizar em outro numero: SIM(1)  NAO(0): ");
                e = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (e != 0);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
