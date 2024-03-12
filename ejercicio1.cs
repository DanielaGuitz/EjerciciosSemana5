using System;

class Program
{
    static void Main()
    {
        int numero;
        int maxi = int.MinValue;
        int min = int.MaxValue;

        do
        {
            Console.Write("INGRESA LOS DATOS QUE TE PIDEN A CONTINIACIÓN....");
            Console.WriteLine("Ingresa un número POSITIVO:");
            Console.WriteLine("Para finalizar ingresa 0");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > maxi)
                {
                    maxi = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número positivo.");
            }
        } while (numero != 0);

        if (maxi != int.MinValue && min != int.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado fue: " + maxi);
            Console.WriteLine("El número menor ingresado fue: " + min);
        }
        else
        {
            Console.WriteLine("OOPS parece que no ingresaste los datos válidos");
        }
    }
}
