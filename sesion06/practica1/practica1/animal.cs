using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    internal class Animal
    {
        public string Nombre { get; }
        public Animal(string nombre) => Nombre = nombre;
        public virtual void HacerSonido() => Console.WriteLine($"{Nombre} hace un sonido.");
    }
}
