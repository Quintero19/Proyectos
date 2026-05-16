using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("\n========= MENÚ PRINCIPAL =========");
            Console.WriteLine("1. Cajero Automático");
            Console.WriteLine("2. Calculadora IMC");
            Console.WriteLine("3. Adivina el Número");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CajeroAutomatico();
                    break;

                case 2:
                    CalculadoraIMC();
                    break;

                case 3:
                    AdivinaNumero();
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

    static void CajeroAutomatico()
    {
        double saldoInicial = 100000;
        int opciones = 0;
        double saldoTotal = saldoInicial;

        Console.WriteLine("\n=== Cajero Automático ===");

        while (opciones != 4)
        {
            Console.WriteLine("\n1. Ver saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");

            opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Saldo disponible: " + saldoTotal);
                    break;

                case 2:
                    Console.WriteLine("Ingrese depósito:");

                    double deposito = Convert.ToDouble(Console.ReadLine());

                    saldoTotal += deposito;

                    Console.WriteLine("Nuevo saldo: " + saldoTotal);
                    break;

                case 3:
                    Console.WriteLine("Ingrese retiro:");

                    double retiro = Convert.ToDouble(Console.ReadLine());

                    if (retiro > saldoTotal)
                    {
                        Console.WriteLine("Fondos insuficientes");
                    }
                    else
                    {
                        saldoTotal -= retiro;

                        Console.WriteLine("Retiro exitoso");
                        Console.WriteLine("Saldo actual: " + saldoTotal);
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del cajero...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

   
    static void CalculadoraIMC()
    {
        Console.WriteLine("\n=== Calculadora IMC ===");

        Console.WriteLine("Ingrese su peso KG:");
        double peso = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        Console.WriteLine("Ingrese su altura M:");
        double altura = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        double imc = peso / Math.Pow(altura, 2);

        Console.WriteLine($"Su IMC es: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }
    }

    static void AdivinaNumero()
    {
        Console.WriteLine("\n=== Adivina el Número ===");

        Random random = new Random();

        int numeroAleatorio = random.Next(1, 101);

        int intentos = 0;

        bool gano = false;

        while (intentos < 7)
        {
            Console.WriteLine("Adivina el número del 1 al 100:");

            int numUsuario = Convert.ToInt32(Console.ReadLine());

            intentos++;

            if (numUsuario > numeroAleatorio)
            {
                Console.WriteLine("Muy alto");
            }
            else if (numUsuario < numeroAleatorio)
            {
                Console.WriteLine("Muy bajo");
            }
            else
            {
                Console.WriteLine("Correcto");
                Console.WriteLine($"Ganaste en {intentos} intentos");

                gano = true;

                break;
            }
        }

        if (!gano)
        {
            Console.WriteLine($"Perdiste. El número era: {numeroAleatorio}");
        }
    }
}