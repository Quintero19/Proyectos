int Ejercicio;

Console.WriteLine("Seleccione el ejercicio que desea ejecutar");
Console.WriteLine("1. Analizador de texto");
Console.WriteLine("2. Sistema de notas");
Console.WriteLine("3. Agenda de contactos");

Ejercicio = Convert.ToInt32(Console.ReadLine());

switch (Ejercicio)
{
    case 1:


        string frase;

        Console.WriteLine("Ingrese una frase: ");
        frase = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Resultados: ");
        Console.WriteLine("Cantidad de caracteres: " + frase.Length);
        Console.WriteLine($"Texto en mayuscula: {frase.ToUpper()}");
        Console.WriteLine($"Texto en minuscula: {frase.ToLower()}");

        break;

    case 2:


        int Notas = 0;
        int Promedio;
        int[] TotalNotas = new int[5];
        int suma = 0;

        int notaMayor = 0;
        int notaMenor = 100;
        int aprobadas = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese la nota {i + 1} del estudiante: ");

            Notas = Convert.ToInt32(Console.ReadLine());

            TotalNotas[i] = Notas;

            suma += Notas;

            if (Notas > notaMayor)
            {
                notaMayor = Notas;
            }

            if (Notas < notaMenor)
            {
                notaMenor = Notas;
            }

            if (Notas > 60)
            {
                aprobadas++;
            }
        }

        Promedio = suma / TotalNotas.Length;

        Console.WriteLine("El promedio es: " + Promedio);
        Console.WriteLine("La nota más alta es: " + notaMayor);
        Console.WriteLine("La nota más baja es: " + notaMenor);
        Console.WriteLine("Materias aprobadas: " + aprobadas);

        Console.WriteLine("\nNotas ingresadas:");

        for (int i = 0; i < TotalNotas.Length; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {TotalNotas[i]}");
        }

        break;

    case 3:


        string Contacto;
        string[] Agenda = new string[5];
        int Opciones = 0;
        int Posicion = 0;

        do
        {
            Console.WriteLine("Agenda de contactos");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Ver contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");

            Opciones = int.Parse(Console.ReadLine());

            if (Opciones == 1)
            {
                if (Posicion < 5)
                {
                    Console.WriteLine("Ingrese el nombre del contacto: ");
                    Contacto = Console.ReadLine();

                    Agenda[Posicion] = Contacto;

                    Posicion++;

                    Console.WriteLine("Contacto guardado");
                }
                else
                {
                    Console.WriteLine("La agenda está llena");
                }
            }
            else if (Opciones == 2)
            {
                Console.WriteLine("Contactos: ");

                for (int i = 0; i < Agenda.Length; i++)
                {
                    if (Agenda[i] != null)
                    {
                        Console.WriteLine(Agenda[i]);
                    }
                }
            }
            else if (Opciones == 3)
            {
                Console.WriteLine("Ingrese el nombre de contacto que desea buscar");
                Contacto = Console.ReadLine();

                bool Encontrado = false;

                for (int i = 0; i < Agenda.Length; i++)
                {
                    if (Agenda[i] != null &&
                        Agenda[i].ToLower() == Contacto.ToLower())
                    {
                        Encontrado = true;
                    }
                }

                if (Encontrado)
                {
                    Console.WriteLine("Contacto encontrado");
                }
                else
                {
                    Console.WriteLine("No existe");
                }
            }

        } while (Opciones != 4);

        Console.WriteLine("Fin del programa");

        break;

    default:

        Console.WriteLine("Opción no válida");

        break;
}