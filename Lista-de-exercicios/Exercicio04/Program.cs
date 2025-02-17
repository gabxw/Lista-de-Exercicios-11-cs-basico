using System;

namespace Exercicio04
{
    class Program
    {
        public static int Metodo(int[] num)
        {
            int maior = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > maior)
                {
                    maior = num[i];
                }
            }

            return maior; 
        }

        public static void Main()
        {
            int[] numeros = { 10, 4, 6, 7, 8, 9, 4, 8, 2, 1 };
            Console.WriteLine($"O maior número da lista é: {Metodo(numeros)}");
            Console.ReadKey();
        }
    }
}
