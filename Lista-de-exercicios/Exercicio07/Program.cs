using System;

namespace Exercicio07
{
    class Program
    {
        public static string Metodo(string palavra)
        {
            string impar = "";

            for (int i = 1; i < palavra.Length; i += 2)
            {
                impar += palavra[i];
            }

            return impar;
        }

        public static void Main()
        {
            string resultado = Metodo("gabriel");
            Console.WriteLine($"Apenas as posições ímpares da string: {resultado}");
            Console.ReadKey();
        }
    }
}
