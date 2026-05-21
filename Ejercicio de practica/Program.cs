using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== MENU DE EJERCICIOS =====");
        Console.WriteLine("1. Guardar y mostrar nombres");
        Console.WriteLine("2. Buscar un número en un array");
        Console.WriteLine("3. Encontrar el número mayor");
        Console.Write("Seleccione una opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1();
                break;

            case 2:
                Ejercicio2();
                break;

            case 3:
                Ejercicio3();
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
    static void Ejercicio1()
    {
        string nombre;
        string[] agenda = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese el nombre {i + 1}: ");
            nombre = Console.ReadLine();
            agenda[i] = nombre;
        }

        Console.WriteLine("========== Lista de contactos ==========");

        for (int i = 0; i < agenda.Length; i++)
        {
            Console.WriteLine($"Contacto {i + 1}: {agenda[i]}");
        }
    }


    static void Ejercicio2()
    {
        int numero;
        int[] guardarNumeros = new int[5];

        for (int t = 0; t < 5; t++)
        {
            Console.WriteLine($"Ingrese el número {t + 1}: ");
            numero = Convert.ToInt32(Console.ReadLine());
            guardarNumeros[t] = numero;
        }

        Console.Write("¿Qué número desea buscar?: ");
        int buscarNumero = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;

        for (int y = 0; y < guardarNumeros.Length; y++)
        {
            if (buscarNumero == guardarNumeros[y])
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("Número encontrado");
        }
        else
        {
            Console.WriteLine("Número no encontrado");
        }
    }

    static void Ejercicio3()
    {
        int[] numMayor = new int[5];

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine($"Ingrese el número {x + 1}: ");
            numMayor[x] = Convert.ToInt32(Console.ReadLine());
        }

        int numeroMayor = numMayor[0];

        for (int a = 0; a < numMayor.Length; a++)
        {
            if (numeroMayor < numMayor[a])
            {
                numeroMayor = numMayor[a];
            }
        }

        Console.WriteLine($"Número mayor: {numeroMayor}");
    }
}