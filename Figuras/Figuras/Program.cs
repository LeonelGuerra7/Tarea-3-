using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
        string tFigura = Console.ReadLine().ToLower();

        double area = 0;

        try
        {
            if (tFigura == "triángulo")
            {
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTri = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del triángulo:");
                double alturaTri = Convert.ToDouble(Console.ReadLine());

                area = 0.5 * baseTri * alturaTri;
            }
            else if (tFigura == "cuadrado")
            {
                Console.WriteLine("Ingrese el lado del cuadrado:");
                double ladoCuad = Convert.ToDouble(Console.ReadLine());

                area = ladoCuad * ladoCuad;
            }
            else if (tFigura == "círculo")
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radioC = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * radioC * radioC;
            }
            else
            {
                throw new ArgumentException("La figura ingresada no está disponible.");
            }

            Console.WriteLine($"El área de la figura {tFigura} es: {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor válido para las dimensiones.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

