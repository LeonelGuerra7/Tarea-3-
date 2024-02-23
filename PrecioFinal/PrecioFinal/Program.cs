using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el precio original del producto (Q):");

            decimal precioOriginal = Convert.ToDecimal(Console.ReadLine());

            decimal descuento = 0;

            if (precioOriginal > 100)
            {
                descuento = precioOriginal * 0.10m;
            }

            decimal precioFinal = precioOriginal - descuento;

            Console.WriteLine($"Precio original: Q{precioOriginal}");
            Console.WriteLine($"Descuento aplicado: Q{descuento}");
            Console.WriteLine($"Precio final con descuento: Q{precioFinal}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido para el precio.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El valor ingresado es demasiado grande para ser manejado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
