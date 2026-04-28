// See https://aka.ms/new-console-template for more information

Console.Write("Ingrese el ancho del terreno: ");
double ancho = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la longitud en metros: ");
double longitud = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el precio por metro cuadrado: ");
double precioPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

double superficie = ancho * longitud;
double precioTotal = superficie * precioPorMetroCuadrado;

Console.WriteLine("-------------------------------------------");
Console.WriteLine("El precio total del terreno es: $" + precioTotal);
