using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    internal class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }
        public override void HacerSonido() => Console.WriteLine($"{Nombre} dice: ¡Guau!");
    }
}
