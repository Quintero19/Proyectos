Console.WriteLine("Hola a todos, Nuevo tema: condicionales");
Console.WriteLine("Ingrese nombre del alumno: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la nota del estudiante: ");
int nota = Convert.ToInt32(Console.ReadLine());
if (nota >= 70)
{
    Console.WriteLine("!Felicidades! Aprobaste el examen");
}
else if (nota >= 50 && nota <= 70)
{
    Console.WriteLine("Estuviste cerca, pero no lo lograste ");
}
else
{
    Console.WriteLine("Ha estudiar para el proximo examen");
}