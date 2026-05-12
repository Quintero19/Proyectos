Console.WriteLine("Clase string, ingresar texto largos en una variable... ");

string lineaTexto = @"Line de texto numero uno
linea de texto numero dos
linea de texto numero tres";
Console.WriteLine(lineaTexto);


Console.WriteLine("==============================");
Console.WriteLine("Propiedades de la clase string");

string texto = "Hola a todo el MUNDO!";
Console.WriteLine("Texto: " + texto);

Console.WriteLine($"Cantidad de caracteres:{texto.Length}");
Console.WriteLine($"Texto en mayuscula: {texto.ToUpper()}");
Console.WriteLine($"Texto en minuscula: {texto.ToLower()}");
Console.WriteLine($"Inicia con: {texto.StartsWith("Hola")}");
Console.WriteLine($"Finaliza con: {texto.EndsWith("Hola")}");
Console.WriteLine($"Reemplazar una palabra (\"a todo el MUNDO\",\"mundo\"): {texto.Replace("a todo el MUNDO", "mundo")}");