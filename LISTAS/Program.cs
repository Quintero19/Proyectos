using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

class Listas
{
    void Datos()
    {
        List<string> Clubes = new List<string>();
        Clubes.Add("Barcelona");
        Clubes.Add("Milan");
        Clubes.Add("Inter");
        Clubes.Add("Arsenal");

        foreach (string i in Clubes)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("======================");
        Clubes.Insert(0, "Real Madrid");
        foreach (string i in Clubes)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("======================");
        bool existe = Clubes.Contains("Barcelona");
        Console.WriteLine(existe);

        Console.WriteLine("======================");
        int indice = Clubes.IndexOf("Milan");
        Console.WriteLine(indice);
        Console.WriteLine("======================");
        List<int>Valores = new List<int>();
        Valores.Add(123);
        Valores.Add(2665);
        Valores.Add(30097);
        Valores.Add(4455);

        foreach (int s in Valores)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("==========================");
        Console.WriteLine("Remover un valor por posicion");
        Valores.RemoveAt(2);
        foreach (int s in Valores)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("==========================");
        Console.WriteLine("Ordenar por menor valor");
        Valores.Sort();
        foreach (int s in Valores)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("==========================");
        Console.WriteLine("Lista al reves");
        Valores.Reverse();
        foreach (int s in Valores)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("==========================");
        Console.WriteLine("lista limpia");
        Valores.Clear();
        foreach (int s in Valores)
        {
            Console.WriteLine(s);
        }

    }

    static void Main(string[] args)
    {
        Listas Equipos = new Listas();
        Equipos.Datos();
    }
}