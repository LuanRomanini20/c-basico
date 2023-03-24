using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//11 - Crie um programa que exiba na tela os números de 1 a 10.



namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Numeros de 1 a 10: ");


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }





            Console.WriteLine("==Pressione ENTER para encerrar==");
            Console.ReadLine();
        }
    }
}
