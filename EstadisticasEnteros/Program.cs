// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número entero: ");
int primerNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un segundo número: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un tercer número: ");
int tercerNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese un cuarto número: ");
int cuartoNumero = Convert.ToInt32(Console.ReadLine());

int suma = primerNumero + segundoNumero + tercerNumero + cuartoNumero;
decimal promedio = (decimal)suma / 4;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("La suma de los números es : " + suma);
Console.WriteLine(" El promedio de los números es: " + promedio);