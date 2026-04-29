//Casting implicitos
int valor = 200;
double total = valor;
Console.WriteLine(total);

//Casting Explicitos
double precio = 25.50;
int descuento = (int)precio;
Console.WriteLine("Explicito" + descuento);

char letra = 'A';
int letraAscii = letra;
Console.WriteLine(letraAscii);

string palabra = "123345345";
int numero = Convert.ToInt32(palabra);
Console.WriteLine(numero);

string textodecimal = "25.50";
int decimalNumber = (int)Convert.ToDouble(textodecimal);
Console.WriteLine(decimalNumber);