
int[] numeros = [20, 30, 78, 209, 46, 321,];
int total = numeros.Sum();
Console.WriteLine("Suma total de los numero: " +  total);

var mayorque = numeros.Where(x => x > 78);
Console.WriteLine("Numero mayores que: " + string.Join(",", mayorque));


int[] cantidad = (int[])numeros.Clone();
Console.WriteLine("Cantidad de numeros: " + string.Join(",", cantidad));

//Suma de dos arrays
int[] array1 = [10, 20, 30, 40];
int[] array2 = [1, 2, 3, 4];
int[] suma = new int[4];

for(int i=0; i<array1.Length; i++)
{
    suma[i] = array1[i] + array2[i];
}
Console.WriteLine("Total de la suma de los dos arrays: " + string.Join(",", suma));