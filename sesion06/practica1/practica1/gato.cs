using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    internal class Gato: Animal
    {

        public Gato(String nombre) : base(nombre) { }
        public override void HacerSonido() => Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }
}
