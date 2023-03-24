using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


//1-Faça um programa que receba dois números e retorne a soma, a subtração, a multiplicação e a divisão entre eles.

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int valor;
            do
            {

                double numero1, numero2;


                Console.WriteLine("Informe o primeiro numero: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                numero2 = double.Parse(Console.ReadLine());

                double soma = numero1 + numero2;
                double div = numero1 / numero2;
                double sub = numero1 - numero2;
                double mult = numero1 * numero2;

                Console.WriteLine($"Soma: {soma}");
                Console.WriteLine($"Divisão: {div}");
                Console.WriteLine($"Subtração: {sub}");
                Console.WriteLine($"Multiplicação: {mult}");

                Console.WriteLine("Deseja adicionar outros numeros ?: SIM (0)  NAO(-1)");
                valor = int.Parse( Console.ReadLine() );

            } while(valor != -1);


            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
