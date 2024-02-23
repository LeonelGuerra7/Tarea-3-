using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese su nombre de usuario:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            string contrasena = Console.ReadLine();

            Console.WriteLine((usuario == "Leonel10" && contrasena == "Leo2405nel") ? "Inicio de sesión exitoso. ¡Bienvenido!" : "Credenciales incorrectas. Inténtalo de nuevo.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Los datos son incorrectos. Intentelo de nuevo.");
        }
    }
}

