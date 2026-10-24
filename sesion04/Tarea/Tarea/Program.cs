

public class Venta
{
    public int id { get; set; }
    public String Producto { get; set; } = String.Empty;
    public String Ciudad { get; set; } = String.Empty;
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal TotalVenta => Cantidad * PrecioUnitario;
}

internal class Program
{
    static void Main(string[] args) {

        List<Venta> listaVentas = new List<Venta>
        {
            new Venta {id = 1, Producto = "Laptop", Ciudad = "Medellín", Cantidad = 2, PrecioUnitario = 3500000},
            new Venta {id = 1, Producto = "Monitor", Ciudad = "Bogotá", Cantidad = 10, PrecioUnitario = 80000},
            new Venta {id = 1, Producto = "Mause", Ciudad = "Cali", Cantidad = 5, PrecioUnitario = 200000},
            new Venta {id = 1, Producto = "celular", Ciudad = "Medellín", Cantidad = 4, PrecioUnitario = 1200000},
            new Venta {id = 1, Producto = "teclado", Ciudad = "Quibdo", Cantidad = 2, PrecioUnitario = 3500000},
            new Venta {id = 1, Producto = "Audifonos", Ciudad = "Medellín", Cantidad = 15, PrecioUnitario = 80000}
        };

        Console.WriteLine("**************************************************");
        Console.WriteLine("= = = = = = REPORTE DE VENTAS CON LINQ = = = = = =");
        Console.WriteLine("**************************************************");

        decimal totalVendido = listaVentas.Sum(v => v.TotalVenta);
        Console.WriteLine($"1. total vendido: {totalVendido:N0}");

        decimal promedioVenta = listaVentas.Average(v => v.TotalVenta);
        Console.WriteLine($"2. Promedio por venta: {promedioVenta:N0}\n");

        Console.WriteLine("3. Ventas por cuidad (de mayor a menor):");
        var ventasPorCiudad = listaVentas
            .GroupBy(v => v.Ciudad)
            .Select(g => new
            {
                Ciudad = g.Key,
                Total = g.Sum(v => v.TotalVenta)
            })
            .OrderByDescending(x => x.Total)
            .Take(3);


        foreach ( var item in ventasPorCiudad)
        {
            Console.WriteLine($" - {item.Ciudad}: ${item.Total:N0}");
        }

        Console.WriteLine("\n4. Top 3 de productos por ingresos:");
        var top3Productos = listaVentas
            .GroupBy(v => v.Producto)
            .Select(g => new
            {
                Producto = g.Key,
                Ingresos = g.Sum(v => v.TotalVenta)
            })
            .OrderByDescending(x => x.Ingresos)
            .Take(3);

        foreach (var prod in top3Productos)
        {
            Console.WriteLine($"   - {prod.Producto}: ${prod.Ingresos:N0}");
        }

        var masVendidoUnidades = listaVentas
            .GroupBy(v => v.Producto)
            .Select(g => new
            {
                Producto = g.Key,
                Unidades = g.Sum(v => v.Cantidad)
            })
            .OrderByDescending(x => x.Unidades)
            .FirstOrDefault();

        Console.WriteLine($"\n5. Producto mas vendido en unidades: ");

        if (masVendidoUnidades != null)
        {
            Console.WriteLine($"- {masVendidoUnidades.Producto} ({masVendidoUnidades.Unidades} unidades)");
        }

        Console.WriteLine("\n= = = = = = = = = = = = = = = = = = = = = = = = = = =");

    }
}