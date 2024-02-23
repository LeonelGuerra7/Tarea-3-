using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de servicio:");
        Console.WriteLine("1. Lavado de auto");
        Console.WriteLine("2. Cambio de aceite");
        Console.WriteLine("3. Revisión mecánica");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            string tipoServicio = tipoServi(opcion);

            double importe = CalcularImporte(tipoServicio);

            if (importe != -1)
                Console.WriteLine($"El importe a pagar por {tipoServicio} es: Q{importe}");
            else
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
        }
        else
        {
            Console.WriteLine("Error: La entrada no es un número válido.");
        }
    }

    static string tipoServi(int opcion)
    {
        switch (opcion)
        {
            case 1:
                return "Lavado de auto";
            case 2:
                return "Cambio de aceite";
            case 3:
                return "Revisión mecánica";
            default:
                return null;
        }
    }

    static double CalcularImporte(string tServicio)
    {
        switch (tServicio.ToLower())
        {
            case "lavado de auto":
                return 35.0;
            case "cambio de aceite":
                return 60.0;
            case "revisión mecánica":
                return 150.0;
            default:
                return -1;
        }
    }
}




