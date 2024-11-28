using System;
using System.Globalization;

namespace uri_bee_1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] escolha = Console.ReadLine().Split(' ');
            int m = int.Parse(escolha[0]);
            int n = int.Parse(escolha[1]);
            int[,] matriz;
            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine();


            for (int i = 0; i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}
