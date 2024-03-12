class Program
{
    static void Main()
    {
        AdivinarNumero();
    }

    static void AdivinarNumero()

    {
        Console.WriteLine("----------------------------------------------ADIVINADOR DE NÚMERO----------------------------------------");

        Console.WriteLine("Piensa en un número cualquiera.....");
        Console.WriteLine("Da ENTER una vez realices los pasos a continuación:");



        // número lo multiplique por 2.
        Console.WriteLine("******Mulltiplica el número que piensas por 2****************+");
        Console.ReadLine();

        // sumar 8 al resultado.
        Console.WriteLine("******************* Súmale 8 al resultado *******************");
        Console.ReadLine();

        // 4- multiplícado por 5.
        Console.WriteLine("******************** Al resultado multiplícalo por 5 *****************");
        Console.ReadLine();

        // 5- El adivinador pide a la persona que le brinde el resultado final.
        Console.WriteLine("BRINDAME TU RESULTADO FINAL");
        Console.WriteLine("¿Cuál es el resultado final?");
        int resultadoFinal = int.Parse(Console.ReadLine());

        // 6- Sin que nadie lo vea el adivinador anula la última cifra.
        int resultadoSinUltimaCifra = QuitarUltimaCifra(resultadoFinal);

        Console.WriteLine("Resultado " + resultadoSinUltimaCifra);

        // 7- Luego al resultado le restado 4.
        resultadoSinUltimaCifra -= 4;

        Console.WriteLine("Resultado final: " + resultadoSinUltimaCifra);

        // 8- Y el adivinador le dirá que el número que pensó la otra persona.
        Console.WriteLine("EL NÚMERO QUE PENSASTE ES: " + resultadoSinUltimaCifra);
        Console.WriteLine("Gracias por participar!!!!");
    }

    static int QuitarUltimaCifra(int num)
    {
        return num / 10;
    }
}
