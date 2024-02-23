using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la calificación del examen: ");

        if (double.TryParse(Console.ReadLine(), out double calificacionDouble))
        {
            int calificacion = (int)Math.Round(calificacionDouble);
            Desempeno(calificacion);
        }
        else
        {
            Console.WriteLine("Error: La entrada no es un número válido.");
        }
    }

    static void Desempeno(int Nota)
    {
        switch (Nota)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Excelente, sigue así.");
                break;
            case int n when (n >= 80 && n <= 89):
                Console.WriteLine("Bien, buena nota.");
                break;
            case int n when (n >= 70 && n <= 79):
                Console.WriteLine("Esta bien, pero se puede mejorar.");
                break;
            case int n when (n >= 60 && n <= 69):
                Console.WriteLine("Raspadita... pero pasaste :D");
                break;
            case int n when (n >= 0 && n <= 59):
                Console.WriteLine("Haz perdido :(, te espero en recuperación.");
                break;

            default:
                Console.WriteLine("Calificación no válida. Por favor, ingrese una calificación dentro del rango permitido.");
                break;
        }
    }
}


