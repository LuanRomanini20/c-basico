using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10 - Faça um programa que leia uma lista de números e informe qual é o segundo maior número da lista

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fim = 0;
            do
            {
                Console.Write("Digite numeros, com espaços: ");
                string adc = Console.ReadLine();

                string[] valor = adc.Split(' ');


                int maior = int.MinValue;
                int segundonMaior = int.MinValue;

                foreach (string numeroStr in valor)
                {
                    int numero = int.Parse(numeroStr);
                    if (numero > maior)
                    {
                        segundonMaior = maior;
                        maior = numero;
                    }
                    else if (numero > segundonMaior)
                    {
                        segundonMaior = numero;
                    }
                }

                Console.WriteLine($"O segundo maior número da lista é {segundonMaior}.");

                Console.WriteLine("Dejesa inserir novos numeros ?: SIM (1)  NAO (0)");
                fim = int.Parse(Console.ReadLine());

            } while (fim != 0);

            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();
        }
    }
}
