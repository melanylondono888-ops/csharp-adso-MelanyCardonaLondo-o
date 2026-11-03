using Practica1;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> Animales = new List<Animal>
        {
            new Perro("posillo"),
            new Gato("karen")
        };

        foreach (Animal animal in Animales)
        {
            animal.HacerSonido();
        }
    }
}
