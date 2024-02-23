using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al club. ¡Disfruta, es hora de divertirse!");
            }
            else
            {
                Console.WriteLine("Lo siento, eres menor de 18 años. No puedes ingresar al club.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor válido para la edad.");
        }
    }
}

