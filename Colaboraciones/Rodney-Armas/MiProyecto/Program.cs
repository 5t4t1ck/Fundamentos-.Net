using Humanizer;

Console.WriteLine("Por favor ingrese un nombre");
var apellido = Console.ReadLine();
Console.WriteLine("Por favor ingrese su signo");
var signo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su dia de nacimiento:");
var diaN = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, Mi nombre es {apellido}, soy {signo} y cumplo el {diaN.ToWords(new System.Globalization.CultureInfo("es"))} mayo.");
