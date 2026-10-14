using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sugerencia de propina inicial
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- SUGERENCIA DE PROPINAS ---");
            Console.WriteLine("Puedes elegir entre: 10 %, 15 % o 20 %");
            Console.WriteLine("------------------------------\n");
            Console.ResetColor();

            // Entradas de texto
            Console.Write("Total de la cuenta: ");
            string entradaTotal = Console.ReadLine();

            Console.Write("Porcentaje de propina: ");
            string entradaPropina = Console.ReadLine();

            Console.Write("Número de personas: ");
            string entradaPersonas = Console.ReadLine();

            // Guardar cada TryParse en su respectivo booleano
            bool okTotal = decimal.TryParse(entradaTotal, out decimal total);
            bool okPct = decimal.TryParse(entradaPropina, out decimal porcentaje);
            bool okPersonas = int.TryParse(entradaPersonas, out int personas);

            // Comprobar todos juntos con && en un solo if (y asegurar que el total sea mayor a 0)
            if (okTotal && okPct && okPersonas && total > 0 && porcentaje >= 0 && personas > 0)
            {
                // Cálculos usando decimal y dividiendo entre 100m
                decimal propina = total * (porcentaje / 100m);
                decimal totalPagar = total + propina;
                decimal porPersona = totalPagar / personas;

                // Salidas con formato de dinero (usando N0 para los separadores de miles)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine($"Propina: $ {propina:N0}");
                Console.WriteLine($"Total: $ {totalPagar:N0}");
                Console.WriteLine($"Cada persona paga: $ {porPersona:N0}");
                Console.ResetColor();
            }
            else
            {
                // Si las personas son 0 o menos, mostramos el aviso específico en rojo
                if (okPersonas && personas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n¡Error! El número de personas debe ser mayor a 0.");
                    Console.ResetColor();
                }
                else
                {
                    // Mensaje general de error amable para otros datos inválidos
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n¡Ups! Por favor ingresa números válidos en los campos.");
                    Console.ResetColor();
                }
            }
        }
    }
}
