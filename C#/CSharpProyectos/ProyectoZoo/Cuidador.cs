public class Cuidador
{
    public Cuidador(string nombre, int horas, List<Animal> animales)
    {
        this.nombre = nombre;
        this.horas = horas;
        this.animales = animales;
    }

    string nombre {get; set;}
    int horas {get; set;}
    List<Animal> animales {get; set;}
}