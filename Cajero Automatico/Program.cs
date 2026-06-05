using System.Globalization;

class CajeroAutomatico
{
    double saldo = 10000;

    void Menu()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine(@"==== SELECCIONE UNA OPCION ====
            1. CONSULTAR SALDO. 
            2. DEPOSITAR SALDO.
            3. RETIRAR SALDO.
            4. SALIR");

            Console.WriteLine("Seleccione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    ConsultarSaldo();
                    break;
                case 2:
                    DepositarSaldo();
                    break;
                case 3:
                    RetirarSaldo();
                    break;
                case 4:
                    Salir();
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDAD, PRESIONE ENTER PARA CONTINUAR...");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 4);

        void ConsultarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo actual: {saldo}");
            otraoperacion();
        }
        void DepositarSaldo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a depositar...");
            double Monto = Convert.ToDouble(Console.ReadLine());
            if (Monto <= 0)
            {
                Console.WriteLine("Monto no valido, no debe de ser 0. intente de nuevo");
                DepositarSaldo();
            }
            else
            {
                saldo += Monto;
                Console.WriteLine($"Depósito. Nuevo saldo: {saldo} ");
                otraoperacion();
            }
        }
        void RetirarSaldo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el saldo a retirar...");
            double retiro = Convert.ToDouble(Console.ReadLine());
            if (saldo <= 0)
            {
                Console.WriteLine("Retiro no valido, no puede ser 0. Intente de nuevo...");
                RetirarSaldo();
            }
            if (retiro > saldo)
            {
                Console.WriteLine("Retiro no valido, el monto a retirar no puede ser superior al saldo");
                RetirarSaldo();
            }
            else
            {
                saldo -= retiro;
                Console.WriteLine($"Retiro completo!" +
                    $"Nuevo saldo: {saldo}");
                otraoperacion();
            }
        }
        void Salir()
        {
            Console.WriteLine(@"================================
            GRACIAS POR UTILIZAR NUESTRO SERVICIOS
            ================================");
            Environment.Exit(0);
        }
        void otraoperacion()
        {
            Console.WriteLine("Desea realizar otra operacion: (1=SI / 2=NO)");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == 1)
            {
                Menu();
            }
            else
            {
                Salir();
            }
        }

    }


    static void Main(string[] args)
    {
        CajeroAutomatico cajero = new CajeroAutomatico();
        cajero.Menu();

    }
}
