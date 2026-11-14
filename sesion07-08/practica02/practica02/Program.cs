using System.Text.Json;

List<Contacto> contactos = [
    new("Ana", "3001234567"),
    new("Luis", "3109876543"),
    new("andrea", "192019292")
];

var opciones = new JsonSerializerOptions { WriteIndented = true };

File.WriteAllText("contactos.json", JsonSerializer.Serialize(contactos, opciones));

List<Contacto> recuperados = [];

try
{
    string json = File.ReadAllText("contactos.json");
    recuperados = JsonSerializer.Deserialize<List<Contacto>>(json) ?? [];
}
catch (JsonException)
{
    Console.WriteLine("El archivo está dañado. Empiezo vacío.");
}
foreach (var c in recuperados)
{
    Console.WriteLine($"{c.Nombre}: {c.Telefono}");
}

Console.WriteLine($"Guardado en: {Path.GetFullPath("contactos.json")}");


record Contacto(string Nombre, string Telefono);
