using System;

namespace Exercicio08
{
    class Program
    {
        public static double Metodo(int[] num)
        {
            if (num.Length == 0)
                return 0;

            int soma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }

            double media = (double)soma / num.Length;
            return media;
        }

        public static void Main()
        {
            int[] numeros = { 4, 6, 8, 9 }; 
            double resultado = Metodo(numeros);

            Console.WriteLine($"A média da lista é: {resultado:F2}");
            Console.ReadKey();
        }
    }
}
