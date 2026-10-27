using System;
using System.Collections.Generic;
using System.Linq; // Necesario para FirstOrDefault, Any, Sum

namespace Reto
{
    public record LineaVenta(string Codigo, string Nombre, int Cantidad, decimal Subtotal);

    // Record para el nivel extra (Factura/Recibo)
    public record Factura(int Numero, DateTime Fecha, List<LineaVenta> Lineas, decimal Total);
    internal class Program
    {
        // Base de datos en memoria (Inventario y Carrito)
        static List<Producto> inventario = new List<Producto>
        {
            new Producto("P01", "Teclado Mecánico", 150000m, 10),
            new Producto("P02", "Mouse Gamer", 80000m, 15),
            new Producto("P03", "Monitor 24 pulgadas", 600000m, 5)
        };

        static List<LineaVenta> carrito = new List<LineaVenta>();
        static int contadorFactura = 1;

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE INVENTARIO Y VENTAS ===");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Agregar stock");
                Console.WriteLine("3. Vender (Agregar al carrito)");
                Console.WriteLine("4. Ver carrito y Total (LINQ)");
                Console.WriteLine("5. Ver inventario");
                Console.WriteLine("6. Confirmar compra (Generar Factura)");
                Console.WriteLine("7. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": RegistrarProducto(); break;
                    case "2": AumentarStock(); break;
                    case "3": RealizarVenta(); break;
                    case "4": MostrarCarrito(); break;
                    case "5": MostrarInventario(); break;
                    case "6": ConfirmarCompra(); break;
                    case "7": salir = true; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void RegistrarProducto()
        {
            Console.WriteLine("\n--- REGISTRAR NUEVO PRODUCTO ---");
            try
            {
                Console.Write("Código: ");
                string codigo = Console.ReadLine().Trim();

                // Pista: Validar que el código no exista previamente
                if (inventario.Any(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine(" Error: Ya existe un producto con ese código.");
                    return;
                }

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Stock inicial: ");
                int stock = int.Parse(Console.ReadLine());

                // Al instanciar se ejecutan las validaciones del constructor y propiedades
                Producto nuevo = new Producto(codigo, nombre, precio, stock);
                inventario.Add(nuevo);
                Console.WriteLine(" Producto registrado con éxito.");
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error sin cerrar el programa
                Console.WriteLine($" Error al registrar: {ex.Message}");
            }
        }

        static void AumentarStock()
        {
            Console.WriteLine("\n--- AGREGAR STOCK ---");
            Console.Write("Ingresa el código del producto: ");
            string codigo = Console.ReadLine().Trim();

            // Pista: Buscar con FirstOrDefault
            var producto = inventario.FirstOrDefault(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));

            if (producto == null)
            {
                Console.WriteLine(" Producto no encontrado.");
                return;
            }

            try
            {
                Console.Write($"Cantidad a agregar a '{producto.Nombre}': ");
                int cantidad = int.Parse(Console.ReadLine());

                producto.AgregarStock(cantidad);
                Console.WriteLine($" Stock actualizado. Nuevo stock: {producto.Stock}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }

        static void RealizarVenta()
        {
            Console.WriteLine("\n--- VENDER (AGREGAR AL CARRITO) ---");
            Console.Write("Ingresa el código del producto: ");
            string codigo = Console.ReadLine().Trim();

            var producto = inventario.FirstOrDefault(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));

            if (producto == null)
            {
                Console.WriteLine(" Producto no encontrado.");
                return;
            }

            Console.Write($"Cantidad a vender (Disponible: {producto.Stock}): ");
            if (int.TryParse(Console.ReadLine(), out int cantidad))
            {
                if (producto.Vender(cantidad))
                {
                    decimal subtotal = producto.Precio * cantidad;
                    carrito.Add(new LineaVenta(producto.Codigo, producto.Nombre, cantidad, subtotal));
                    Console.WriteLine(" Agregado al carrito exitosamente.");
                }
                else
                {
                    Console.WriteLine(" No hay suficiente stock o la cantidad es inválida.");
                }
            }
            else
            {
                Console.WriteLine(" Cantidad no válida.");
            }
        }

        static void MostrarCarrito()
        {
            Console.WriteLine("\n--- CARRITO DE COMPRAS ---");
            if (!carrito.Any())
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            foreach (var item in carrito)
            {
                Console.WriteLine($"[{item.Codigo}] {item.Nombre} x{item.Cantidad} - Subtotal: ${item.Subtotal:N2}");
            }

            // Pista: Calcular total con LINQ Sum
            decimal total = carrito.Sum(l => l.Subtotal);
            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"TOTAL A PAGAR: ${total:N2}");
        }

        static void MostrarInventario()
        {
            Console.WriteLine("\n--- INVENTARIO ACTUAL ---");
            foreach (var prod in inventario)
            {
                Console.WriteLine(prod);
            }
        }

        static void ConfirmarCompra()
        {
            if (!carrito.Any())
            {
                Console.WriteLine("No hay productos en el carrito para facturar.");
                return;
            }

            decimal total = carrito.Sum(l => l.Subtotal);
            Factura factura = new Factura(contadorFactura++, DateTime.Now, new List<LineaVenta>(carrito), total);

            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine($"           RECIBO DE COMPRA #{factura.Numero:D4}");
            Console.WriteLine($"Fecha: {factura.Fecha:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine("========================================");
            foreach (var l in factura.Lineas)
            {
                Console.WriteLine($"{l.Nombre,-20} x{l.Cantidad,-3} ${l.Subtotal,10:N2}");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"TOTAL: ${factura.Total,29:N2}");
            Console.WriteLine("========================================");

            // Vaciamos el carrito tras confirmar la compra
            carrito.Clear();
        }
    }
}
