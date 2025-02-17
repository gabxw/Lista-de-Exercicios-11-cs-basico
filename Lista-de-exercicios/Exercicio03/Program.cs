using System;

namespace Exercicio03
{
    class Program
    {

        public static int Metodo(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Main()
        {
            int soma = Metodo(5, 5);
            Console.WriteLine($"A soma é: {soma}");
            Console.ReadKey();
        }
    }
}