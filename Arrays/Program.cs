
using System.Runtime.InteropServices;

int[] enteros = new int[5];

enteros[0] = 5;
enteros[1] = 51;
enteros[2] = 500;
enteros[3] = 599;
enteros[4] = 5676;

Console.WriteLine("Su numero de array es: " + enteros[2]);

int[] numeros = [20, 39, 89, 56, 43, 24, 56,];

string[] nombre = { "Ana", "Elizabeth", "Antonio", "samuel", "juan" };
//for(int i=0; i<numeros.Length; i++)
//{
//    Console.Write(numeros[i]);
//    Console.Write(", ");
//}
Array.Sort(numeros);
Console.WriteLine($"Numeros organizados de manera ascendente {string.Join(",", numeros)}");
Array.Sort(nombre);
Console.WriteLine($"nombres organizados de manera ascendente {string.Join(",", nombre)}");
Array.Reverse(nombre);
Console.WriteLine($"array al reves: {string.Join(",", nombre)}");
Array.Reverse(numeros);
Console.WriteLine($"array al reves: {string.Join(",", numeros)}");
int posicion = Array.IndexOf(nombre, "ANA");
Console.WriteLine(posicion);
Array.Clear(nombre);
Console.WriteLine($"array limpio: {string.Join(",", nombre)}");
Array.Fill(numeros, 99);
Console.WriteLine($"array llenado con 99: {string.Join(",", numeros)}");

