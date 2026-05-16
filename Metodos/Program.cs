class Prueba
{
    void Saludar()// Metodo set, no retorna ningun valor
    {
        Console.WriteLine("Hola a todos! ");
    }
    public int sumar() // Metodo  Get, retorna datos, valores, etc
    {
        int valor1 = 20, valor2 = 21, total;
        total = valor1 + valor2;
        return total;
    }
    public string Despedida()
    {
        string Nota = "Adios a todos! ";
        return Nota;
    }

   public static void Main()
    {
        Prueba Mensaje = new Prueba();
        Prueba mens = new Prueba();
        Mensaje.Saludar();
        int resultado = Mensaje.sumar();
        Console.WriteLine("El total de la operacion: " + resultado);
        Console.WriteLine(mens.Despedida());
    }
}