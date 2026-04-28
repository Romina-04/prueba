// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un tiempo en segundos:");
double tiempo = Convert.ToDouble(Console.ReadLine());
double velocidadDeLaLuz = 299792458;
double distancia = velocidadDeLaLuz * tiempo;
Console.WriteLine($"La distancia que la luz recorre en un tiempo en segundo es {distancia} metros. ");
