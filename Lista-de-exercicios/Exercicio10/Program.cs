using System;

namespace Exercicio10
{
    class Program
    {
        public static int Metodo(int[] num)
        {
            int menor = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < menor)
                {
                    menor = num[i];
                }
            }

            return menor;
        }

        public static void Main()
        {
            int[] numeros = { 10, 4, 6, 7, 8, 9, 4, 8, 2, 1 };
            Console.WriteLine($"O menor número da lista é: {Metodo(numeros)}");
            Console.ReadKey();
        }
    }
}
