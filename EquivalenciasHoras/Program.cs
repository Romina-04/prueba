// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un equivalente en horas:");
double horas = Convert.ToDouble(Console.ReadLine());
double minutos = horas * 60;
double segundos = horas * 3600;
Console.WriteLine($"{horas} horas equivalen a {minutos} minutos y {segundos} segundos. ");

