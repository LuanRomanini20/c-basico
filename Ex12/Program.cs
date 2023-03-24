using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//12 - Crie um programa que exiba na tela os números pares de 0 a 20.

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Numeros de 0 a 20 apenas pares: ");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();

        }
    }
}
