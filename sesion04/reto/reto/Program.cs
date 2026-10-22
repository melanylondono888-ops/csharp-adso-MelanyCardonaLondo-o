using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> aprendices = new Dictionary<string, List<double>>();
        int opcion = 0;

        do
        {
            Console.WriteLine("\n--- GESTOR DE NOTAS ---");
            Console.WriteLine("1. Registrar aprendiz");
            Console.WriteLine("2. Agregar nota");
            Console.WriteLine("3. Listar todos");
            Console.WriteLine("4. Ranking");
            Console.WriteLine("5. Mejor aprendiz y aprobados");
            Console.WriteLine("6. Eliminar aprendiz");
            Console.WriteLine("7. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

            switch (opcion)
            {
                case 1:
                    
                    Console.Write("Nombre del aprendiz: ");
                    string nombre = Console.ReadLine();

                    if (!aprendices.ContainsKey(nombre))
                    {
                        aprendices.Add(nombre, new List<double>());
                        Console.WriteLine("¡Aprendiz registrado con éxito!");
                    }
                    else
                    {
                        Console.WriteLine("El aprendiz ya existe.");
                    }
                    break;

                case 2:
                    Console.Write("Nombre del aprendiz: ");
                    string nomNota = Console.ReadLine();

                    if (aprendices.ContainsKey(nomNota))
                    {
                        Console.Write("Ingresa la nota (0 a 5): ");
                        double nota = Convert.ToDouble(Console.ReadLine());

                        if (nota >= 0 && nota <= 5)
                        {
                            aprendices[nomNota].Add(nota);
                            Console.WriteLine("¡Nota agregada!");
                        }
                        else
                        {
                            Console.WriteLine("Nota inválida (debe ser entre 0 y 5).");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El aprendiz no existe.");
                    }
                    break;

                case 3:
                    foreach (var item in aprendices)
                    {
                        string nombreAp = item.Key;
                        List<double> notas = item.Value;
                        int cantidad = notas.Count;
                        double suma = 0;

                        foreach (double n in notas)
                        {
                            suma += n;
                        }

                        double promedio = cantidad > 0 ? suma / cantidad : 0;
                        string juicio = promedio >= 3.0 ? "A" : "D";

                        Console.WriteLine($"{nombreAp,-15} {cantidad} notas · Promedio {promedio:F1} · Juicio {juicio}");
                    }
                    break;

                case 4:
                    // 4. Ranking de mayor a menor promedio (versión sencilla con Listas y Ordenamiento)
                    Console.WriteLine("\n--- RANKING DE APRENDICES ---");

                    // Creamos una lista temporal para guardar los datos procesados
                    var listaRanking = new List<Tuple<string, double>>();

                    foreach (var item in aprendices)
                    {
                        if (item.Value.Count > 0) // Solo los que tienen notas
                        {
                            double suma = 0;
                            foreach (double n in item.Value) { suma += n; }
                            double prom = suma / item.Value.Count;
                            listaRanking.Add(new Tuple<string, double>(item.Key, prom));
                        }
                    }

                    // Ordenamos de mayor a menor promedio manualmente con LINQ básico (OrderByDescending)
                    var rankingOrdenado = listaRanking.OrderByDescending(x => x.Item2);

                    int puesto = 1;
                    foreach (var r in rankingOrdenado)
                    {
                        Console.WriteLine($"{puesto}. {r.Item1,-12} - Promedio: {r.Item2:F1}");
                        puesto++;
                    }
                    break;

                case 5:
                    // 5. Mejor aprendiz y cuántos aprobaron
                    string mejorNombre = "Ninguno";
                    double mejorPromedio = -1;
                    int aprobados = 0;

                    foreach (var item in aprendices)
                    {
                        if (item.Value.Count > 0)
                        {
                            double suma = 0;
                            foreach (double n in item.Value) { suma += n; }
                            double prom = suma / item.Value.Count;

                            // Contar si aprobó (>= 3.0)
                            if (prom >= 3.0)
                            {
                                aprobados++;
                            }

                            // Buscar el mejor
                            if (prom > mejorPromedio)
                            {
                                mejorPromedio = prom;
                                mejorNombre = item.Key;
                            }
                        }
                    }

                    Console.WriteLine($"\n--- ESTADÍSTICAS ---");
                    if (mejorPromedio != -1)
                    {
                        Console.WriteLine($"Mejor aprendiz: {mejorNombre} (Promedio: {mejorPromedio:F1})");
                    }
                    else
                    {
                        Console.WriteLine("No hay aprendices con notas registradas aún.");
                    }
                    Console.WriteLine($"Total de aprobados: {aprobados}");
                    break;

                case 6:
                    // 6. Eliminar aprendiz
                    Console.Write("Nombre del aprendiz a eliminar: ");
                    string eliminar = Console.ReadLine();

                    if (aprendices.Remove(eliminar))
                    {
                        Console.WriteLine("¡Aprendiz eliminado correctamente!");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un aprendiz con ese nombre.");
                    }
                    break;

            }

        } while (opcion != 7);
    }
}