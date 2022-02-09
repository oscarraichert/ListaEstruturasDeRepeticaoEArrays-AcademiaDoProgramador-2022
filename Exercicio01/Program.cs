/*Exercício 1:
• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
programa deverá calcular e mostrar:
a. A menor altura do grupo;
b. A maior altura do grupo;*/

using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];
            double maiorAltura = 0;
            double menorAltura = 90000;

            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write($"Altura da pessoa {i + 1}: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());

                if (maiorAltura < altura[i])
                {
                    maiorAltura = altura[i];
                }
                if (menorAltura > altura[i])
                {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine($"\nA maior altura é {maiorAltura}");
            Console.WriteLine($"A menor altura é {menorAltura}");
        }

    }
}

