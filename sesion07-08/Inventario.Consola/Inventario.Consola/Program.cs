using Inventario.Datos;
using Inventario.Dominio;
using Inventario.Servicios;

string ruta = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    "Sesion08Inventario",
    "inventario.json");


IRepositorioProductos repositorio = new RepositorioJson(ruta);
// IRepositorioProductos repositorio = new RepositorioMemoria();
// --------------------------------------------------------

var servicio = new ServicioInventario(repositorio);

Console.WriteLine($"Inventario cargado ({servicio.Listar().Count} producto(s)).");

bool salir = false;
while (!salir)
{
    MostrarMenu();
    string? opcion = Console.ReadLine()?.Trim();
    Console.WriteLine();

    switch (opcion)
    {
        case "1": Registrar(); break;
        case "2": AgregarStock(); break;
        case "3": Vender(); break;
        case "4": VerInventario(); break;
        case "5": VerStockBajo(); break;
        case "6": salir = true; break;
        default: Console.WriteLine("Opción no válida. Elige un número del 1 al 6."); break;
    }
}

Console.WriteLine("Hasta luego.");

// ======================= Opciones del menú =======================

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== INVENTARIO =====");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Ver stock bajo (menos de 5)");
    Console.WriteLine("6. Salir");
    Console.Write("Opción: ");
}

void Registrar()
{
    string codigo = LeerTexto("Código: ");
    string nombre = LeerTexto("Nombre: ");
    decimal precio = LeerDecimal("Precio: ");
    int cantidad = LeerEntero("Cantidad inicial: ", minimo: 0);

    var producto = new Producto(codigo, nombre, precio, cantidad);

    if (servicio.Agregar(producto))
        Console.WriteLine("Producto registrado.");
    else
        Console.WriteLine($"Ya existe un producto con el código '{codigo}'.");
}

void AgregarStock()
{
    string codigo = LeerTexto("Código del producto: ");
    int unidades = LeerEntero("Unidades a agregar: ", minimo: 1);

    if (servicio.AgregarStock(codigo, unidades))
        Console.WriteLine("Stock actualizado.");
    else
        Console.WriteLine($"No existe un producto con el código '{codigo}'.");
}

void Vender()
{
    string codigo = LeerTexto("Código del producto: ");
    int unidades = LeerEntero("Unidades a vender: ", minimo: 1);

    try
    {
        if (servicio.Vender(codigo, unidades))
            Console.WriteLine("Venta registrada.");
        else
            Console.WriteLine($"No existe un producto con el código '{codigo}'.");
    }
    catch (StockInsuficienteException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void VerInventario()
{
    var productos = servicio.Listar();
    if (productos.Count == 0)
    {
        Console.WriteLine("El inventario está vacío.");
        return;
    }
    Imprimir(productos);
}

void VerStockBajo()
{
    var bajos = servicio.StockBajo();
    if (bajos.Count == 0)
    {
        Console.WriteLine("No hay productos con stock bajo.");
        return;
    }
    Imprimir(bajos);
}

void Imprimir(IEnumerable<Producto> productos)
{
    Console.WriteLine($"{"Código",-10} {"Nombre",-20} {"Precio",12} {"Cant.",6}");
    foreach (var p in productos)
        Console.WriteLine($"{p.Codigo,-10} {p.Nombre,-20} {p.Precio,12:N2} {p.Cantidad,6}");
}

string LeerTexto(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string? texto = Console.ReadLine()?.Trim();
        if (!string.IsNullOrWhiteSpace(texto))
            return texto;
        Console.WriteLine("Este dato no puede estar vacío.");
    }
}

int LeerEntero(string mensaje, int minimo)
{
    while (true)
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out int valor) && valor >= minimo)
            return valor;
        Console.WriteLine($"Escribe un número entero mayor o igual a {minimo}.");
    }
}

decimal LeerDecimal(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= 0)
            return valor;
        Console.WriteLine("Escribe un número válido (0 o mayor).");
    }
}
