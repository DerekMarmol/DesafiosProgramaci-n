using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!Bienvenido¡, ingrese su nombre de usuario");
            string nombre = Console.ReadLine();

            Console.WriteLine("A continuación debe ingresar sus ingresos totales de los ultimos 3 mese, empezando por el primer mes");
            int ingreso1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite su segundo ingreso");
            int ingreso2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite su tercer ingreso");
            int ingreso3 = Convert.ToInt32(Console.ReadLine());

            int suma = ingreso1 + ingreso2 + ingreso3;
            int promedio = suma / 3;

            Console.WriteLine("Hola {0}, en total ganaste {1:C} y promediaste {2:C}.", nombre, suma, promedio);
            Console.Read();
        }

    }
}
