using System;

namespace Exercicio06
{
    class Program
    {
        
        public static bool Metodo(int numero)
        {
            return numero % 2 == 0;
        }

        public static void Main()
        {
           
            bool resultado = Metodo(4);
            Console.WriteLine($"O número 4 é par? {resultado}");
            Console.ReadKey(); 
        }
    }
}