public class Animal
{
    string nombre { get; set; }
    string especie { get; set; }
    int edad { get; set; }

    public Animal(string nombre, string especie, int edad)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.edad = edad;
    }
}