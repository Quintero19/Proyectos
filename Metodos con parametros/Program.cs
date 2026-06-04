using System.Runtime.CompilerServices;

class Prueba
{
    void Saludar(string nombre, int edad)
    {
        Console.WriteLine($"Nombre: {nombre} Edad: {edad} ");
    }
    int Suma(int a, int b)
    {
        return (a + b);
    }

    public static void Main() {
        Prueba saludo = new Prueba();
        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        saludo.Saludar(nombre,edad);

        Console.WriteLine("Ingrese el valor de la variable 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la variable 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = saludo.Suma(num1 ,num2);
        Console.WriteLine("Resultado: " + resultado);
    }
}