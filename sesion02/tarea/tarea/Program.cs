using System;

namespace tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxIntentos = 7;
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 101);
            int intentos = 0;
            bool acertado = false;

            Console.WriteLine($"Adivina el número entre 1 y 100, tienes {maxIntentos} intentos");

            while (intentos < maxIntentos && !acertado)
            {
                Console.Write($"Intento {intentos + 1} de {maxIntentos}: ");

                if (!int.TryParse(Console.ReadLine(), out int respuesta))
                {
                    Console.WriteLine("Ingresa un número válido.");
                    continue; // no cuenta como intento
                }

                intentos++;

                if (respuesta == numeroSecreto)
                {
                    acertado = true;
                }
                else if (respuesta < numeroSecreto)
                {
                    Console.WriteLine("El número es mayor, intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("El número es menor, intenta de nuevo.");
                }
            }

            if (acertado)
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intento(s).");
            }
            else
            {
                Console.WriteLine($"Lo siento, no adivinaste el número. El número correcto era {numeroSecreto}.");
            }
        }
    }
}
