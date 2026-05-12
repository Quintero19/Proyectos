// New Funtion MATH

//int numero1 = 4;
//double numero2 = 45.09;

//Console.WriteLine("Potenciación de un numero: " + Math.Pow(numero1, 2));
//Console.WriteLine("raiz cuadrada: " + Math.Sqrt(numero1));
//Console.WriteLine("Valor absoluto: " + Math.Abs(numero1)); 
//Console.WriteLine("redondeo hacia arriba: " + Math.Ceiling(numero2));
//Console.WriteLine("redondeo hacia abajo: " + Math.Floor(numero2));
//Console.WriteLine("redondeo normal: " + Math.Round(numero2));
//Console.WriteLine("maximo valor: " + Math.Max(numero1, numero2));
//Console.WriteLine("minimo valor: " + Math.Min(numero1, numero2));
//Console.WriteLine("Valor de PI: " + Math.PI);

//Ejercicio calcular el radio de un circulo 

//Console.WriteLine("Ingrese el area del circulo: ");
//double radio = Convert.ToDouble(Console.ReadLine());

//double area = Math.PI * Math.Pow(radio, 2);

//Console.WriteLine("El area del circulo es: " + Math.Round(area));


// Calculadora de potencia y raíz
//int numUsuario;
//Console.WriteLine("ingrese un número: ");
//numUsuario = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Su número potenciado es: " + Math.Pow(numUsuario,2));
//Console.WriteLine("Cubo: " + Math.Pow(numUsuario, 3));
//Console.WriteLine("La raíz cuadrada de su numero es: " + Math.Sqrt(numUsuario));

//Sistema de redondeo
//Console.WriteLine("Ingrese un numero con decimales: ");
//double numero4;
//numero4 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Round: " + Math.Round(numero4));
//Console.WriteLine("Celiling: " + Math.Ceiling(numero4));
//Console.WriteLine("Floor: " + Math.Floor(numero4));

//Ejercicio 3 — Distancia entre dos puntos
int x1;
int y1;
int x2;
int y2;

Console.WriteLine("ingresa los dos numeros para punto 1: ");
Console.WriteLine("Ingrese un numero para x1: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero para y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingresa los dos numeros para punto 2: ");
Console.WriteLine("Ingrese un numero para x2: ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero para y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

int resta = x1 - x2;
double resul1 = Math.Pow(resta, 2);
int resta2 = y1 - y2;
double resul2 = Math.Pow(resta2, 2);

double sum = resul1 + resul2;

Console.WriteLine("Su resultado es: " + Math.Sqrt(sum));

////double distancia = Math.Pow(x1, x2) + Math.Pow(y1, y2);
////double resultado = Math.Sqrt(distancia);
//Console.WriteLine("Su resultado es: " + resultado);
