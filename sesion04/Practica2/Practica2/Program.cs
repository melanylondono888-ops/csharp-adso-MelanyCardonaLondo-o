//RECORD

List<Producto> productos =
[
    new ("Cuaderno", "Papelería", 6500m, 40),
    new ("Mouse", "Tecnología", 45000m, 3),
    new ("USB 64 Gb", "Tecnología", 3800m, 15)

];

var baratos = productos.Where(p => p.Precio < 10000m);
var masCaro = productos.MaxBy(p => p.Precio);
var masCaro1 = productos.Max(p => p.Precio);
decimal valorInventario = productos.Sum(p => p.Precio * p.Stock);


Console.WriteLine($"Menores a 10000 \n{string.Join("\n", baratos)}");
Console.WriteLine($"Mas caro {masCaro}");
Console.WriteLine($"Mas caro {masCaro1}");
Console.WriteLine($"Valor Inventario {valorInventario}");

var porCategoria = productos
    .GroupBy(p => p.Categoria)
    .Select(g => new { Categoria = g.Key, Unidades = g.Sum(p => p.Stock) });

foreach (var c in porCategoria)
{
    Console.WriteLine($"{c.Categoria,-12} {c.Unidades} unidades");
}
