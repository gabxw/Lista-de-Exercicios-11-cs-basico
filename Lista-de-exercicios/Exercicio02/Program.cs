using System;

namespace Exercicio02
{
    class Program
    {
       
        public static int Metodo(string palavra)
        {
            return palavra.Length;
        }

        public static void Main()
        {
           
            int numeroCaracteres = Metodo("gabriel");
            Console.WriteLine($"A palavra tem {numeroCaracteres} caracteres.");
            Console.ReadKey();
        }
    }
}