class Zoologico
{
    public Zoologico(List<Animal> animals, List<Cuidador> cuidadors, string nombre)
    {
        this.animals = animals;
        this.cuidadors = cuidadors;
        this.nombre = nombre;
    }

    List<Animal> animals { get; set; }
    List<Cuidador> cuidadors { get; set; }
    string nombre { get; set; }

}