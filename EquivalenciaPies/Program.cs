// See https://aka.ms/new-console-template for more information

const int PIE_A_PULGADAS = 12;
const int YARDA_A_PIES = 3;
const double PULGADA_A_CM = 2.54;
const int METRO_A_CM = 100;

Console.Write("Ingrese la distancia en pies: ");
double pies = Convert.ToDouble(Console.ReadLine());

double pulgadas = pies * PIE_A_PULGADAS;

double yardas = pies / YARDA_A_PIES;

double centimetros = pulgadas * PULGADA_A_CM;

double metros = centimetros / METRO_A_CM;

Console.WriteLine("-------------------------------------------");
Console.WriteLine($"{pies} pies equivalen a:");
Console.WriteLine($"- {pulgadas} pulgadas");
Console.WriteLine($"- {yardas} yardas");
Console.WriteLine($"- {centimetros} centímetros");
Console.WriteLine($"- {metros} metros");
