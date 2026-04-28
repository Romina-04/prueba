// See https://aka.ms/new-console-template for more information


Console.Write("Ingrese el primer número (dividendo): ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo número (divisor): ");
int num2 = Convert.ToInt32(Console.ReadLine());

int cociente = num1 / num2;

int resto = num1 % num2;

double divisionReal = (double)num1 / num2;

Console.WriteLine("-------------------------------------------");
Console.WriteLine($"Resultados de dividir {num1} entre {num2}:");
Console.WriteLine($"- Cociente (entero): {cociente}");
Console.WriteLine($"- Resto: {resto}");
Console.WriteLine($"- División Real: {divisionReal}");