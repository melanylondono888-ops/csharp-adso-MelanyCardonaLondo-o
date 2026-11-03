using Reto;

class Program
{
    static void Main(string[] args)
    {
        // 1. Lista de empleados solicitada en el reto
        List<Empleado> nomina = new List<Empleado>
        {
            new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
            new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
            new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
            new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
            new Contratista("Sofía León", "1005", 4_000_000m)
        };

        Console.WriteLine("=== DETALLE DE NÓMINA ===");
        foreach (var empleado in nomina)
        {
            // Usamos .ToString() y el cálculo polimórfico de CalcularSalario()
            Console.WriteLine($"{empleado} [{empleado.GetType().Name}] -> Pago: {empleado.CalcularSalario():C0}");
        }

        // 2. Total de la nómina (Debe dar $15.070.000)
        decimal totalNomina = nomina.Sum(e => e.CalcularSalario());
        Console.WriteLine($"\nTotal Nómina: {totalNomina:C0}");

        // 3. El mayor pago (LINQ)
        var mayorPago = nomina.MaxBy(e => e.CalcularSalario());
        Console.WriteLine($"Mayor Pago: {mayorPago?.Nombre} con {mayorPago?.CalcularSalario():C0}");

        // 4. Total por tipo de empleado (LINQ GroupBy)
        Console.WriteLine("\n--- Total por Tipo de Empleado ---");
        var totalPorTipo = nomina.GroupBy(e => e.GetType().Name);
        foreach (var grupo in totalPorTipo)
        {
            decimal sumaTipo = grupo.Sum(e => e.CalcularSalario());
            Console.WriteLine($"- {grupo.Key}: {sumaTipo:C0}");
        }
    }
}
