int numero;
do
{
    Console.WriteLine("Introduzca el #0 para salir");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Numero colocado: " + numero);
} while (numero != 0);
    Console.WriteLine($"Numero valido: { numero }" );
Console.WriteLine("Fin del programa");
