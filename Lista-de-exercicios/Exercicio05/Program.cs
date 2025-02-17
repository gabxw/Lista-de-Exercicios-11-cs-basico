using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        public static string Metodo(string[] palavra)
        {
            string resultado = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                resultado += palavra[i] + " ";

            }

            return resultado;
        }

        public static void Main()
        {
            string[] palavras = { "gabriel", "arthur", "matheus", "joão" };
            Console.WriteLine($"Nomes concatenados: {Metodo(palavras)}");
            Console.ReadKey();
        }
    }
}
