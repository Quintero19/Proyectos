//Bucle while

//int numero = 1;

//while (numero <= 10)
//{
//    Console.WriteLine("Numero" + numero);
//    numero++;
//}
;

//Ejercicio utilizando el bucle while

//Console.WriteLine("Bienvenido al juego adivina el número, en un rango del 1 - 10");
//Console.WriteLine("-------------");

//int numeroSecreto = 4;
//int intento = 0;

//while (intento != numeroSecreto)
//{
//    Console.WriteLine("ingrese el numero");
//    intento = int.Parse(Console.ReadLine());
//    if (intento != numeroSecreto)
//    {
//        Console.WriteLine("Perdiste, Intenta nuevamente");
//    }
//    else
//    {
//        Console.WriteLine("Ganaste");
//    }

//}
//;

int numero;
int suma = 0;

Console.Write("Ingrese un número (0 para terminar): ");
numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    suma = suma + numero;

    Console.Write("Ingrese otro número (0 para terminar): ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("La suma total es: " + suma);