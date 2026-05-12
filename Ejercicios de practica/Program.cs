int numero1;
int numero2;
int operacion;
int resultado;
Console.WriteLine("Ingrese el valor del primer numero: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor del segundo numero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("suma(1), resta(2), multiplicacion(3), division(4) ");
operacion = Convert.ToInt32(Console.ReadLine());

switch (operacion)
{
    case 1:
        resultado = numero1 + numero2;
        Console.WriteLine("su resultado es: " + resultado);
        break;
    case 2:
        resultado = numero1 - numero2;
        Console.WriteLine("Su resultado es: " + resultado);
        break;
    case 3:
        resultado = numero1 * numero2;
        Console.WriteLine("su resultado es: " + resultado);
        break;
    case 4:
        resultado = numero1 / numero2;
        Console.WriteLine("su resultado es: " + resultado);
        break;
}
;

Console.WriteLine("============================ Ejercicio sistema de notas ===================");
int nota;
Console.WriteLine("Ingrese la nota sacada por el estudiante: ");
nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 90)
{
    Console.WriteLine("!Felicitaciones");
}
else if (nota >= 70)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 50)
{
    Console.WriteLine("Recuperacion");
}
else
{
    Console.WriteLine("Perdiste");

}
;

Console.WriteLine("====================== Ejercicio tabla de multiplicar ================");
int numeroTabla = 0;
int cantidad = 0;
Console.WriteLine("Ingrese la tabla que desea ver: ");
numeroTabla = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Seleccione hasta que numero quiere multiplicar: ");
cantidad = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
}


Console.WriteLine("================ Ejercicio menu interactivo =============");
int opciones = 0;
DateTime fecha = DateTime.Now;
Random ramdom = new Random();
int numeroaleatorio = ramdom.Next(1, 100);
do
{
    Console.WriteLine("Tenemos el siguiete menu interactivo:\r\n1. Saludar\r\n2. Mostrar fecha\r\n3. Mostrar un número aleatorio\r\n4. Salir" +
        "\r\n seleccione la opcion de preferencia");
    opciones = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("La opcion seleccionada fue: " + opciones);
    switch (opciones)
    {
        case 1:
            Console.WriteLine("!HOLA, Como te encuentras? ");
            break;
        case 2:
            Console.WriteLine("La fecha es: " + fecha);
            break;
        case 3:
            Console.WriteLine("Su numero es: " + numeroaleatorio);
            break;
    }
    ;
    Console.WriteLine("=============================");
    Console.WriteLine("Fin del programa!");

} while (opciones != 4);


Console.WriteLine("================= Juego de adivinar el número ================");
int NumUsuario = 0;
Random Ramdom = new Random();
int numRamdom = Ramdom.Next(1, 101);
int NumIntentos = 0;
while (numRamdom != NumUsuario)
{
    Console.WriteLine("Ingrese un numero del 1-100");
    NumUsuario = int.Parse(Console.ReadLine());
    if (NumUsuario > numRamdom)
    {
        Console.WriteLine("Muy alto ");
    }
    else if (NumUsuario < numRamdom)
    {
        Console.WriteLine("Muy bajo ");
    }
    else
    {
        Console.WriteLine("Ganaste!");
    }
    NumIntentos++;
    Console.WriteLine("Numero de intentos: " + NumIntentos);
}
