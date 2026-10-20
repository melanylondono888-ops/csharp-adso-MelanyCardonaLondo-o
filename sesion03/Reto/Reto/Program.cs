using System;
using System.Text;

namespace Sesion03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Permite mostrar correctamente los caracteres especiales como ✔ y ✗
            Console.OutputEncoding = Encoding.UTF8;

            bool esFuerte = false;

            do
            {
                Console.Write("\nContraseña: ");
                string contraseña = Console.ReadLine() ?? "";


                esFuerte = EvaluarContraseña(contraseña);

            } while (!esFuerte); // Si no es fuerte, se vuelve a pedir

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n¡Felicidades! Has ingresado una contraseña fuerte.");
            Console.ResetColor();
        }

      
        static bool EvaluarContraseña(string clave)
        {
            // 1. Reglas básicas
            bool tieneMinimo8 = clave.Length >= 8;
            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;
            bool sinEspacios = !clave.Contains(" ");
            bool noContieneProhibidos = !clave.ToLower().Contains("1234") && !clave.ToLower().Contains("clave");

            foreach (char c in clave)
            {
                if (char.IsUpper(c)) tieneMayuscula = true;
                else if (char.IsLower(c)) tieneMinuscula = true;
                else if (char.IsDigit(c)) tieneNumero = true;
                else if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)) tieneEspecial = true;
            }

            
            bool[] resultados = {
                tieneMinimo8,
                tieneMayuscula,
                tieneMinuscula,
                tieneNumero,
                tieneEspecial,
                sinEspacios,
                noContieneProhibidos // Nivel extra
            };

            string[] nombresReglas = {
                "Mínimo 8 caracteres",
                "Una mayúscula",
                "Una minúscula",
                "Un número",
                "Un carácter especial",
                "Sin espacios",
                "No contiene '1234' ni 'clave'" // Nivel extra
            };

            int reglasCumplidas = 0;

            // Mostramos los resultados regla por regla
            for (int i = 0; i < resultados.Length; i++)
            {
                if (resultados[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"✔ {nombresReglas[i]}");
                    reglasCumplidas++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"✗ {nombresReglas[i]}");
                }
            }
            Console.ResetColor();

            string nivel = "";
            if (reglasCumplidas >= 6)
            {
                nivel = "Fuerte";
            }
            else if (reglasCumplidas >= 4)
            {
                nivel = "Media";
            }
            else
            {
                nivel = "Débil";
            }

            string claveOculta = new string('*', clave.Length);

            Console.WriteLine($"\nContraseña procesada: {claveOculta}");
            Console.WriteLine($"Nivel: {nivel} ({reglasCumplidas}/6)");

            // Retorna true solo si cumple al menos 6 reglas (Fuerte)
            return nivel == "Fuerte";
        }
    }
}