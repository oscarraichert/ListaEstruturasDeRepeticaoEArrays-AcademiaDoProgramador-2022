/*Exercício 5:
• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de 
valores do cálculo de A! e o seu resultado. 
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
• Pesquise sobre “fatorial*/

using System;
using System.Numerics;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um número para ver o valor de seu fatorial: ");
                BigInteger numero = Convert.ToInt32(Console.ReadLine());

                Console.Write($"{numero} ");
                for (BigInteger i = numero - 1; i > 0; i--)
                {
                    numero = i * numero;
                    Console.Write($"x {i} ");
                }
                Console.WriteLine($"= {numero}");
                Console.WriteLine();
            }
        }
    }
}