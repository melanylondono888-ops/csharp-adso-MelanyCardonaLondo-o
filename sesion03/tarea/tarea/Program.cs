using System.Globalization;
using System.Text;
using System;
using System.Text;
using System.Globalization;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n===== SESION 03 - TAREA =====");
                Console.WriteLine("1. Generador de usuarios");
                Console.WriteLine("2. Analizador de frases");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opcion valida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        GenerarUsuario();
                        break;

                    case 2:
                        AnalizarFrase();
                        break;

                    case 3:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

            } while (opcion != 3);
        }

        // Metodo 1: Generador de usuarios
        static void GenerarUsuario()
        {
            Console.Write("Ingrese el nombre completo: ");
            string nombreCompleto = Console.ReadLine() ?? "";

            Console.Write("Ingrese el documento: ");
            string documento = Console.ReadLine() ?? "";

            string[] partes = nombreCompleto.Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length < 2 || documento.Length < 2)
            {
                Console.WriteLine("Ingrese el nombre completo y un documento valido.");
                return;
            }

            string primerNombre = partes[0];
            string primerApellido = partes[2 < partes.Length ? 2 : 1];

            // Quitar las tildes
            string nombreSinTildes = QuitarTildes(primerNombre);
            string apellidoSinTildes = QuitarTildes(primerApellido);

            // Obtener la primera letra del nombre
            string inicial = nombreSinTildes.Substring(0, 1);

            // Obtener los dos ultimos digitos
            string ultimosDigitos = documento.Substring(documento.Length - 2);

            string usuario = (inicial + apellidoSinTildes + ultimosDigitos)
                .ToLowerInvariant();

            Console.WriteLine("Usuario generado: " + usuario);
        }

        // Metodo auxiliar para quitar tildes
        static string QuitarTildes(string texto)
        {
            string normalizado = texto.Normalize(NormalizationForm.FormD);
            StringBuilder resultado = new StringBuilder();

            foreach (char caracter in normalizado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(caracter)
                    != UnicodeCategory.NonSpacingMark)
                {
                    resultado.Append(caracter);
                }
            }

            return resultado.ToString().Normalize(NormalizationForm.FormC);
        }

        // Metodo 2: Analizador de frases
        static void AnalizarFrase()
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine() ?? "";

            string[] palabras = frase.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine("Cantidad de palabras: " + palabras.Length);

            StringBuilder fraseInvertida = new StringBuilder(frase);
            fraseInvertida = new StringBuilder(
                fraseInvertida.ToString().Trim()
            );

            // Invertir la frase utilizando StringBuilder
            for (int i = 0, j = fraseInvertida.Length - 1;
                 i < j; i++, j--)
            {
                char temporal = fraseInvertida[i];
                fraseInvertida[i] = fraseInvertida[j];
                fraseInvertida[j] = temporal;
            }

            Console.WriteLine("Frase en orden inverso: " + fraseInvertida);
        }
    }
}
