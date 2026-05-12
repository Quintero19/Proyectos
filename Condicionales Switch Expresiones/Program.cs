Console.WriteLine("Ingrese la nota....");
int nota =Convert.ToInt32(Console.ReadLine());
string resultado = nota switch
{
    >= 80 => "aprobaste la nota",
    >= 60 => "Repetir ejercicio",
    _ => "Perdiste"
};
Console.WriteLine(resultado);

Console.ReadKey();
