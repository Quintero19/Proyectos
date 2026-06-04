using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENÚ DE EJERCICIOS =====");
        Console.WriteLine("1. Persona");
        Console.WriteLine("2. Producto");
        Console.WriteLine("3. Estudiante");
        Console.Write("Seleccione una opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                EjercicioPersona();
                break;

            case 2:
                EjercicioProducto();
                break;

            case 3:
                EjercicioEstudiante();
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
    static void EjercicioPersona()
    {
        string nombre;
        int edad;
        string ciudad;

        Console.WriteLine("Ingrese el nombre del usuario:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la ciudad:");
        ciudad = Console.ReadLine();

        Console.WriteLine("===== RESULTADOS =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Ciudad: {ciudad}");
    }
    static void EjercicioProducto()
    {
        string nombreProducto;
        double precio;
        int cantidad;
        double total;

        Console.WriteLine("Ingrese nombre del producto:");
        nombreProducto = Console.ReadLine();

        Console.WriteLine("Ingrese el precio:");
        precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        total = precio * cantidad;

        Console.WriteLine("===== RESULTADOS =====");
        Console.WriteLine($"Producto: {nombreProducto}");
        Console.WriteLine($"Precio: ${precio}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Total: ${total}");
    }
    static void EjercicioEstudiante()
    {
        string nombre;
        double nota;

        Console.WriteLine("Ingrese el nombre del estudiante:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la nota:");
        nota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("===== RESULTADO =====");

        if (nota >= 60)
        {
            Console.WriteLine($"{nombre} aprobó");
        }
        else
        {
            Console.WriteLine($"{nombre} reprobó");
        }
    }
}

using System;

class Persona
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Ciudad { get; set; }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear objeto
//        Persona persona1 = new Persona();

//        // Pedir datos al usuario
//        Console.Write("Ingrese el nombre: ");
//        persona1.Nombre = Console.ReadLine();

//        Console.Write("Ingrese la edad: ");
//        persona1.Edad = int.Parse(Console.ReadLine());

//        Console.Write("Ingrese la ciudad: ");
//        persona1.Ciudad = Console.ReadLine();

//        // Mostrar información
//        Console.WriteLine("\n--- Información de la Persona ---");
//        Console.WriteLine("Nombre: " + persona1.Nombre);
//        Console.WriteLine("Edad: " + persona1.Edad);
//        Console.WriteLine("Ciudad: " + persona1.Ciudad);
//    }
//}