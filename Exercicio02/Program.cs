/*Exercício 2:
• Escrever um algoritmo que gera e escreve os números ímpares entre 100
e 200.*/

using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}