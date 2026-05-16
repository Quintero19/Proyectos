class Persona
{
    string nombre = "Homero sipmson";
    int edad = 37;
    string direccion = "Calle siempre viva n°. 742";
    int salario = 243;
    bool estado = true;



    static void Main()
    {
        Persona personal1 = new Persona();
        Console.WriteLine($"Nombre:{personal1.nombre}\n" +
            $"Edad:{personal1.edad}\n" +
            $"Direccion:{personal1.direccion}\n" +
            $"Salario:{personal1.salario}\n" +
            $"Estado: {personal1.estado} ");
    }

}