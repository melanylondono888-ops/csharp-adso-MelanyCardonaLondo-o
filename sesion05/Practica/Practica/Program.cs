using Practica;

// Creamos un libro usando tu clase exacta de libro.cs
libro elLibro = new libro("Cien años de soledad", "Gabriel García Márquez", 1967);

Console.WriteLine(elLibro);

elLibro.Prestar();
Console.WriteLine(elLibro);

elLibro.Devolver();
Console.WriteLine(elLibro);
