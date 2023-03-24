using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//27-Crie um programa que solicite ao usuário uma frase e exiba na tela a mesma frase, mas invertida.


namespace Ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {

                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();
                string fraseInvertida = "";

                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    fraseInvertida += frase[i];
                }

                Console.WriteLine($"Frase invertida: {fraseInvertida}");


                Console.WriteLine("Quer outro numero?: SIM (0) NAO (-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();


            } while (valor != -1);

            Console.WriteLine("--Pressione ENTER para encerrar!--");
            Console.ReadLine();
        }
    }
}
