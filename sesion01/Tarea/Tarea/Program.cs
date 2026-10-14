using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================");
            Console.WriteLine("    PROGRAMA DE BIENVENIDA       ");
            Console.WriteLine("=================================");
            Console.ResetColor();

            // Pedir el nombre al usuario
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // Pedir la edad al usuario
            Console.Write("Ingresa tu edad: ");
            string edad = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n¡Bienvenido/a, {nombre}! Tienes {edad} años. Es un gran gusto tenerte en la clase de programación.");
            Console.ResetColor();

        }
    }
}
