using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3-Faça um programa que leia três números e informe qual deles é o maior.

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Maior Numero--");

            int valor;

            do
            {
                Console.Write("Digite o numero 1: ");
                double numero1 = long.Parse(Console.ReadLine());

                Console.Write("Digite o numero 2: ");
                double numero2 = long.Parse(Console.ReadLine());

                Console.Write("Digite o numero 3: ");
                double numero3 = long.Parse(Console.ReadLine());

                if (numero1 > numero2 && numero3 < numero1)
                {
                    Console.WriteLine($"O maior numero é {numero1}!");
                }
                else if (numero1 < numero2 && numero2 > numero3)
                {
                    Console.WriteLine($"O maior numero é {numero2}!");
                }
                else
                {
                    Console.WriteLine($"O maior numero é {numero3}!");
                }

                Console.WriteLine("Deseja adicionar novos valores ?   SIM (0)    NAO(-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (valor != -1);

            Console.WriteLine("--PRESSIONA ENTER PARA ENCERRAR--");
            Console.ReadLine();
        }
                
            
    }
}

