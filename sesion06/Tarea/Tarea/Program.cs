using Tarea;

class Program
{
    static void Main(string[] args)
    {
        ProcesarPagos procesador = new ProcesarPagos();

        IMetodoPago efectivo = new PagoEfectivo();
        IMetodoPago tarjeta = new PagoTarjeta("1234567812345678"); // 16 dígitos válidos
        IMetodoPago billeteraExcedida = new PagoBilletera(); // Monto mayor a 2 millones fallará

        // 1. Probar Cobros
        procesador.Cobrar(efectivo, 150_000m);
        procesador.Cobrar(tarjeta, 800_000m);
        procesador.Cobrar(billeteraExcedida, 2_500_000m); // Debería fallar por superar el límite

        // 2. Probar Reembolsos (Develuciones)
        // La tarjeta sí permite reembolso
        procesador.Devolver(tarjeta, 800_000m);

        // El efectivo NO permite reembolso
        procesador.Devolver(efectivo, 150_000m);
    }
}
