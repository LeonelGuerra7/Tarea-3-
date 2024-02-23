using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese tres números separados por espacios:");

            string[] entrada = Console.ReadLine().Split(' ');

           
            int n1, n2, n3;

            if (int.TryParse(entrada[0], out n1) && int.TryParse(entrada[1], out n2) && int.TryParse(entrada[2], out n3))
            {
                int mayor = Math.Max(Math.Max(n1, n2), n3);
                Console.WriteLine($"El número mayor es: {mayor}");
            }
            else
            {
                Console.WriteLine("Error: Ingrese valores numéricos válidos.");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Ingrese al menos tres valores separados por espacios.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


