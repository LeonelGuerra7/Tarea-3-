using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número del 1 al 7 para conocer qué día de la semana es: ");

        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            string dia = ObtenerDiaSemana(numero);

            if (dia != null)
                Console.WriteLine($"El día de la semana es: {dia}");
            else
                Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 7.");
        }
        else
        {
            Console.WriteLine("Error: Número inválido. Por favor, ingrese un número del 1 al 7.");
        }
    }

    static string ObtenerDiaSemana(int numero)
    {
        switch (numero)
        {
            case 1: return "Lunes";
            case 2: return "Martes";
            case 3: return "Miércoles";
            case 4: return "Jueves";
            case 5: return "Viernes";
            case 6: return "Sábado";
            case 7: return "Domingo";
            default: return null;
        }
    }
}
