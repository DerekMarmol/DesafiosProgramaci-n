using System;

namespace Desafio2
{
    public class Calculadora
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Dividir (int num1, int num2)
       {
            return num1 / num2;
       }

    }

    class program
    { 
        static void Main(string[] args)
        {
            Calculadora miCalculadora = new Calculadora();

            // Ejemplos de uso de los métodos
            int resultadoSuma = miCalculadora.Sumar(10, 5);
            int resultadoResta = miCalculadora.Restar(10, 5);
            int resultadoMultiplicacion = miCalculadora.Multiplicar(10, 5);
            int resultadoDivision = miCalculadora.Dividir(10, 5);

            Console.WriteLine("Suma: " + resultadoSuma);
            Console.WriteLine("Resta: " + resultadoResta);
            Console.WriteLine("Multiplicación: " + resultadoMultiplicacion);
            Console.WriteLine("División: " + resultadoDivision);
            Console.Read();
        }
    }
}

