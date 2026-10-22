using System.Threading.Channels;

List<string> compras = ["Leche", "Pan", "Huevos", "Frutas", "Verduras"];

Console.WriteLine($"tienes antes de agragar {compras.Count} elementos");

compras.Add("cafe");
compras.Remove("Leche");
compras.Sort();

Console.WriteLine(string.Join(", ", compras));


Console.WriteLine("*********DICCCIONARIO*********");

Dictionary<string, string> agenda = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

agenda["Ana"] = "28929293";
agenda["angel"] = "33930293";

if (agenda.TryGetValue("ana", out string? telefono))
{
    Console.WriteLine($"Ana: {telefono}");

}

foreach (var (nombre, tell) in agenda)

{

    Console.WriteLine($"{nombre}: {tell}");

}

Console.WriteLine("===========================");

//diccionario con listas adentro

Dictionary<string, List<double>> notas = new Dictionary<string, List<double>>(StringComparer.OrdinalIgnoreCase);

notas["Miguel"] = [];
notas["Miguel"].Add(4.5);
notas["Miguel"].Add(5.0);
notas["Miguel"].Add(3.2);

foreach (var (nombre, listaNotas) in notas)
{
    Console.WriteLine($"{nombre}: {string.Join(", ", listaNotas)}");
}

Console.WriteLine("===========================");

List<int> numeros = [13, 27, 35, 54, 35, 14, 11, 12, 4, 2, 90, 100, 82];

var sumar = numeros.Sum();
var promedio = numeros.Average();
Console.WriteLine(sumar);
Console.WriteLine(promedio);

Console.WriteLine($"hay algun numero mayor  a 80: {numeros.Any(n => n > 80)}");
Console.WriteLine($"Numeros mayores a 80: {string.Join(",", numeros.Where(n => n > 80))}");





