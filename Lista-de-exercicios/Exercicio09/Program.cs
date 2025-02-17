using System;

public class Program
{
    public static void Main()
    {
        int numero = 29; // Exemplo de número
        bool resultado = VerificarPrimo(numero);
        Console.WriteLine($"O número {numero} é primo? {resultado}");
    }

    public static bool VerificarPrimo(int numero)
    {
        // Números menores que 2 não são primos
        if (numero <= 1)
            return false;

        // Verifica se o número é divisível por algum número entre 2 e a raiz quadrada do número
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false; // Se encontrar um divisor, não é primo
        }

        return true; // Se não encontrar divisores, é primo
    }
}
