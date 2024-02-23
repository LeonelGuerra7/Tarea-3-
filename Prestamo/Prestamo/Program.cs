using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el monto del préstamo :");
            decimal monto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (monto < 5000 || edad > 60)
            {
                Console.WriteLine("¡Préstamo aprobado! ¡Felicidades!");
            }
            else
            {
                Console.WriteLine("Préstamo rechazado. Lo sentimos, no cumple con los criterios de aprobación.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido para el monto del préstamo o la edad.");
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
