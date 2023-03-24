using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//18 - Crie um programa que solicite ao usuário uma frase e exiba na tela quantas vezes cada letra aparece na frase.

//ex 8
namespace Ex18
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
