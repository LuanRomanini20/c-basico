using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8 - Faça um programa que leia uma string e informe quantas vezes uma determinada letra aparece na string.

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fim;
            do
            {
                string palavra;

                Console.Write("Digite uma palavra: ");
                palavra = Console.ReadLine();


                Console.Write("Qual letra você quer saber se repitiu ?: ");
                char letra = Console.ReadKey().KeyChar;

                int contador = 0;

                foreach (char c in palavra)
                {
                    if (c == letra)
                    {
                        contador++;
                    }
                }

                Console.WriteLine($"\nA letra{letra} da palavra {palavra} apareceu {contador} vezes!");
                Console.WriteLine("Quer outra palavra: SIM (1) NAO(0)");
                fim = int.Parse(Console.ReadLine());
            } while (fim != 0);

            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();
        }
    }
}
