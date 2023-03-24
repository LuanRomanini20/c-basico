using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9 - Faça um programa que leia um número inteiro e informe se ele é um número perfeito. Um número perfeito é aquele cuja soma dos seus divisores
//(exceto ele mesmo) é igual ao próprio número.


namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 0;
            do
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int somaDivisor = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        somaDivisor += i;
                    }
                }

                if (somaDivisor == numero)
                {
                    Console.WriteLine($"O número {numero} é um número perfeito!");
                }
                else
                {
                    Console.WriteLine($"O número {numero} um número inperfeito!");
                }

                Console.WriteLine("Deseja inserir outro numero?: SIM(1) NAO(0) ");
                e = int.Parse(Console.ReadLine());

            }while(e != 0);

            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();
        }
    }
}
