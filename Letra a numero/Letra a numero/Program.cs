using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 5 en letra: ");
        string entrada = Console.ReadLine();

        int numero = ConvertirNumero(entrada);

        if (numero != -1)
            Console.WriteLine($"El número en dígito es: {numero}");
        else
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
    }

    static int ConvertirNumero(string texto)
    {
        switch (texto.ToLower())
        {
            case "uno": return 1;
            case "dos": return 2;
            case "tres": return 3;
            case "cuatro": return 4;
            case "cinco": return 5;
            default: return -1;
        }
    }
}

