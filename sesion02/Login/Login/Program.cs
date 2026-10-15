using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string usuario = (Console.ReadLine() ?? "").ToLower().Trim();
            Console.Write("Ingrese su contraseña: ");
            string clave = (Console.ReadLine() ?? "").Trim();

            if (usuario == "admin" && clave == "12345")
            {
                Console.WriteLine("Bienvenido al sistema");
                Console.WriteLine("Calculadora con SWITCH");

                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Número no válido.");
                    return;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Número no válido.");
                    return;
                }

                Console.WriteLine("Digite la opción deseada:\n 1. Sumar\n 2. Restar\n 3. Multiplicar\n 4. Dividir\n 5. Calificar nota");

                if (!int.TryParse(Console.ReadLine(), out int opc))
                {
                    Console.WriteLine("Opción no válida.");
                    return;
                }

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"El resultado de la suma es: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"El resultado de la resta es: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"El resultado de la multiplicación es: {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                            Console.WriteLine("No se puede dividir entre 0");
                        else
                            Console.WriteLine($"El resultado de la división es: {a / b}");
                        break;
                    case 5:
                        Console.Write("Ingrese la nota (0 a 5): ");
                        if (!double.TryParse(Console.ReadLine(), out double nota))
                        {
                            Console.WriteLine("Nota no válida.");
                        }
                        else if (nota < 0 || nota > 5)
                        {
                            Console.WriteLine("La nota debe estar entre 0 y 5");
                        }
                        else if (nota <= 3.0)
                        {
                            Console.WriteLine("Nota: deficiente");
                        }
                        else if (nota < 4.0)
                        {
                            Console.WriteLine("Nota: aceptable");
                        }
                        else if (nota < 4.6)
                        {
                            Console.WriteLine("Nota: sobresaliente");
                        }
                        else
                        {
                            Console.WriteLine("Nota: excelente");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error en el usuario o contraseña");
            }
        }
    }
}