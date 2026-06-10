class Persona
{
    string nombre;
    int edad;
    public Persona(string nombre, int edad)
    {
        this.nombre=nombre;
        this.edad = edad;
    }

    void mostrar()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Edad: " + this.edad);

    }

    static void Main(string[] args)
    {
        Persona personal = new Persona("Yeison" , 20);
        personal.mostrar();
        Console.ReadKey();
    }
}