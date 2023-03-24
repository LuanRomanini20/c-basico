using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//26-Crie um programa que solicite ao usuário um número e exiba na tela a sua decomposição em números decimais.

namespace Ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {

                Console.Write("Digite um número: ");
                double numero = double.Parse(Console.ReadLine());

                string[] parte = numero.ToString("F").Split(',');

                Console.WriteLine($"Parte inteira: {parte[0]}");
                Console.WriteLine($"Parte decimal: {parte[1]}");


                Console.WriteLine("\nQuer outro numero?: SIM (0) NAO (-1)");
                valor = int.Parse(Console.ReadLine());

                Console.Clear();


            } while (valor != -1);

            Console.WriteLine("--Pressione ENTER para encerrar!--");
            Console.ReadLine();

        }
    }
}
