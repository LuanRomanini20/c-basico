using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5-Faça um programa que calcule a média de um conjunto de números informados pelo usuário. O usuário deve informar quantos números deseja informar.


namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sair = 0;
            do
            {
                Console.WriteLine("Quantos numeros você deseja informar?:");
                int vezes = int.Parse(Console.ReadLine());

                int soma = 0;

                for (int i = 0; i < vezes; i++)
                {
                    Console.WriteLine($"Informe o numero{i}: ");
                    int numero = int.Parse(Console.ReadLine());

                    soma += numero;
                }

                double media = (double)soma / vezes;

                Console.WriteLine($"Resultado da media é: {media}");


                Console.WriteLine("Voce deseja informar novos numeros?   SIM (1)   NAO(0)");
                sair = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (sair != 0);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
