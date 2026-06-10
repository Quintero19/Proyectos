class Mapas
{
    static void Main(string[] args)
    {
        Dictionary<int, string>Frutas = new Dictionary<int, string>();
        Frutas.Add(1, "Manzana");
        Frutas.Add(2, "Piña");
        Frutas.Add(3, "Durazno");
        Frutas.Add(4, "Melocoton");
        Frutas.Add(5, "Coco");

        foreach (var s in Frutas)
        {
            Console.WriteLine($"Clave: {s.Key} Valor: {s.Value}");
        }

        Console.WriteLine(Frutas.ContainsKey(2));
        Console.WriteLine(Frutas.ContainsValue("Coco"));
    }
}