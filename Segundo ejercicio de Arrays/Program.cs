Console.WriteLine("Seleccione el ejercicio que desea ejecutar:");
Console.WriteLine("1 - Número menor del arrays");
Console.WriteLine("2 - Contador de números pares e impares");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:

        //Ejercicio 1 — Número menor del arrays

        int numeros;
        int[] NumeroMenor = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese el numero {i + 1}: ");
            numeros = Convert.ToInt32(Console.ReadLine());
            NumeroMenor[i] = numeros;
        }

        int NumMenor = NumeroMenor[0];

        for (int x = 0; x < NumeroMenor.Length; x++)
        {
            if (NumMenor > NumeroMenor[x])
            {
                NumMenor = NumeroMenor[x];
            }
        }

        Console.WriteLine($"El numero menor es:{NumMenor} ");

        break;

    case 2:

        //Ejercicio 2 — Contador de números pares e impares

        int IngresaNumero;
        int[] ListaNumeros = new int[5];
        int numeroPar = 0;
        int numeroInpar = 0;

        for (int z = 0; z < 5; z++)
        {
            Console.WriteLine($"Ingrese el numero {z + 1}: ");
            IngresaNumero = Convert.ToInt32(Console.ReadLine());
            ListaNumeros[z] = IngresaNumero;
        }

        for (int y = 0; y < ListaNumeros.Length; y++)
        {
            if (ListaNumeros[y] % 2 == 0)
            {
                numeroPar++;
            }
            else
            {
                numeroInpar++;
            }
        }

        Console.WriteLine($"La cantidad de números pares es: {numeroPar}");
        Console.WriteLine($"La cantidad de números impares es: {numeroInpar}");

        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}