using System.Diagnostics.Contracts;
using System.Formats.Tar;
using System.Text;

MostrarTitulo("mis metodos");

Console.WriteLine(Sumar(5, 8)); 

Console.WriteLine(MensajeConNumeros(10, "Hola"));

Console.WriteLine(EsPar(7));

//ESTO ES UN PROCEDIMIENTO, NO RETORNA NINGUN VALOR

static void MostrarTitulo(string mensaje)
{
    Console.WriteLine(mensaje.ToUpper());
}

//ESTA ES UNA FUNCION Y RETORNA UN VALOR

static int Sumar(int a, int b)
{
    return a + b;
}

static string MensajeConNumeros(int x, string dato)
{
    return $"{dato}, y su numero es {x}";
}

static Boolean EsPar(int numero) => numero % 2 == 0;


//SOBRECARGAS Y OPCIONALES

static double Area(double lado) => lado * lado;

static double Areal(double ancho, double alto) => ancho * alto;

Area(4);
Areal(4, 3);

static void saludar(string nombre, string saludo = "hola")
{
    Console.WriteLine($"{saludo} {nombre}!!!");
}

saludar("edison", "bienvenido");

saludar("edison"); //saludo por defecto

static int multiplicar(int a = 6, int b = 2)
{
    return a * b; 
}

Console.WriteLine(multiplicar(4, 5)); //retorna 20

Console.WriteLine(multiplicar(3));

Console.WriteLine(multiplicar());

//METODOS REUTILIZABLES O COMODIN

//funcion que lee un entero 

static int LeerEntero(string mensaje)
{
    Console.WriteLine(mensaje);
    int valor;
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor no valido, intenta de nuevo \n Digita un numero: ");
    }
    return valor;
}

Console.WriteLine(LeerEntero("Digita un numero: "));        

//funcion que lee un decimal

static decimal leerDecimal( string mensaje)
{
    Console.Write(mensaje);
    decimal valor;
    while (!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor no valido, intenta de nuevo \n Digita un numero decimal : ");
    }
    return valor;
}

Console.WriteLine(leerDecimal("Digita un numero decimal: "));


//ARREGLOS Y CADENAS***

decimal[] notas = new decimal[5];

for (int i = 0; i < notas.Length; i++)
{
    notas[i] = leerDecimal($"Nota: {i + 1}");

}

Console.WriteLine(string.Join(" | ", notas));

//*****CONTAR VOCALES EN UNA CADENA*****

static int ContarVocales(string texto)
{
    int totalvocales = 0;
    foreach (char c in texto.ToLower())
    {
        if ("aeiouáéíóú".Contains(c))
            totalvocales++;
    }
    return totalvocales;
}

Console.WriteLine(ContarVocales("Hola profé Querido"));

Console.WriteLine(char.IsDigit('7'));
Console.WriteLine(char.IsDigit('e'));

Console.WriteLine(char.IsUpper('A'));
Console.WriteLine(char.IsUpper('a'));

Console.WriteLine(char.IsLower('A'));
Console.WriteLine(char.IsLower('a'));

Console.WriteLine(char.IsWhiteSpace(' '));
Console.WriteLine(char.IsUpper('x'));

// contar tipos de caracteres en un texto

string texto = "@ Hola, Soy Goku 2026_04 ";
int digitos = 0, mayusculas = 0, minusculas = 0, espacios = 0, especiales = 0;

Console.WriteLine(texto);
foreach (char c in texto)
{
    if (char.IsDigit(c))
        digitos++;
    else if (char.IsUpper(c))
        mayusculas++;
    else if (char.IsLower(c))
        minusculas++;
    else if (char.IsWhiteSpace(c))
        espacios++;
    else if (char.IsSymbol(c))
        especiales++;
}

Console.WriteLine($"Dígitos: {digitos}");
Console.WriteLine($"Mayúsculas: {mayusculas}");
Console.WriteLine($"Minúsculas: {minusculas}");
Console.WriteLine($"Espacio en Blanco: {espacios}");
Console.WriteLine($"Caracteres especiales: {especiales}");


// primera línea del archivo

static string Invertir(string texto)
{
    var sb = new StringBuilder();
    for (int i = texto.Length - 1; i >= 0; i--) sb.Append(texto[i]);
    return sb.ToString();
}

Console.WriteLine(Invertir("Hola Mundo"));

