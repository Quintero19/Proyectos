DayOfWeek dia = DateTime.Now.DayOfWeek;
int numDia = (int)dia; 

switch (numDia)
{
    case 1:
        Console.WriteLine("Es lunes");
        break;
    case 2:
        Console.WriteLine("Es martes");
        break;
    case 3:
        Console.WriteLine("Es miercoles");
        break;
    case 4:
        Console.WriteLine("Es jueves");
        break;
    case 5:
        Console.WriteLine("Es viernes");
        break;
    case 6:
        Console.WriteLine("Es sabado");
        break;
    case 0:
        Console.WriteLine("Es domingo");

        break;
}
