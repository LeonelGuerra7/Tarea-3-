using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione su idioma de preferencia:");
        Console.WriteLine("1. Español");
        Console.WriteLine("2. Inglés");
        Console.WriteLine("3. Francés");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            string idioma = ObtenerIdioma(opcion);

            if (idioma != null)
                Mensaje(idioma);
            else
                Console.WriteLine("Opción no válida. Por favor, seleccione un idioma válido.");
        }
        else
        {
            Console.WriteLine("Error: La entrada no es un número válido.");
        }
    }

    static string ObtenerIdioma(int opcion)
    {
        switch (opcion)
        {
            case 1:
                return "español";
            case 2:
                return "inglés";
            case 3:
                return "francés";
            default:
                return null;
        }
    }

    static void Mensaje(string idioma)
    {
        switch (idioma.ToLower())
        {
            case "español":
                Console.WriteLine("¡Bienvenido a la programación!");
                break;
            case "inglés":
                Console.WriteLine("Welcome to programming!");
                break;
            case "francés":
                Console.WriteLine("Bienvenue à la programmation!");
                break;
            default:
                Console.WriteLine("Idioma no reconocido.");
                break;
        }
    }
}


