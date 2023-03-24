using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//6 - Faça um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero.

namespace Ex6
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
                else if(numero < 0)
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
