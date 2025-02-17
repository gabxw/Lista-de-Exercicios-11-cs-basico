using System;

namespace Exercicio01
{
    class Program
    {
        public static int Metodo(int x)
        {
            return x * x;
        }

        public static void Main()
        {
            int resultado = Metodo(4);
            Console.WriteLine($"O quadrado de 4 é: {resultado}");
            Console.ReadKey();
        }
    }
}