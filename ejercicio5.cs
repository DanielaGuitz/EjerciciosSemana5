using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        bool Palindromo = VerificarPalindromo(palabra);

        Console.WriteLine(Palindromo ? $"{palabra} es un palíndromo." : $"{palabra} no es un palíndromo.");
    }

    static bool VerificarPalindromo(string palabra)
    {
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
