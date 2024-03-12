using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("BIENVENIDO!");
        Console.WriteLine("Ingresa una frase:");
        string frase = Console.ReadLine();


        int ContadorP = ContarPalabras(frase);
        Console.WriteLine("Cantidad de palabras que contenía la frase: {ContadorP}");


        int ContadorV = ContarVocales(frase);
        Console.WriteLine("Número de vocales que contenía en la frase: {ContadorP}");
    }

    static int ContarPalabras(string frase)
    {
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return palabras.Length;
    }

    static int ContarVocales(string frase)
    {

        return frase.Count(c => "aeiouAEIOU".Contains(c));
    }
}
