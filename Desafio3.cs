using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int resultado = SumarNumeros();
            Console.WriteLine("La suma es: " + resultado);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operación completada.");
        }

        Console.ReadLine();
    }

    public static int SumarNumeros()
    {
        Console.WriteLine("Ingrese el primer número:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo número:");
        string input2 = Console.ReadLine();

        int num1 = Convert.ToInt32(input1);
        int num2 = Convert.ToInt32(input2);

        int suma = num1 + num2;
        return suma;
    }
}
