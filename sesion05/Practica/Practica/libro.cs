using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    // 1. TU CLASE ORIGINAL (Sigue intacta aquí dentro)
    internal class libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Anio { get; private set; }
        public bool Disponible { get; private set; } = true;

        public libro(string titulo, string autor, int anio)
        {
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
        }

        public bool Prestar()
        {
            if (!Disponible) return false;
            Disponible = false;
            return true;
        }

        public void Devolver() => Disponible = true;

        public override string ToString() =>
            $"{Titulo} · {Autor} ({Anio}) · {(Disponible ? "Disponible" : "Prestado")}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            libro elLibro = new libro("Cien años de soledad", "Gabriel García Márquez", 1967);

            Console.WriteLine(elLibro);

            elLibro.Prestar();
            Console.WriteLine(elLibro);

            elLibro.Devolver();
            Console.WriteLine(elLibro);
        }
    }
}