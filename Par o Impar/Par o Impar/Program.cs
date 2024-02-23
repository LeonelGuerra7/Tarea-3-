using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese un número:");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? $"{num} es un número par." : $"{num} es un número impar.");
        }
       
        
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

