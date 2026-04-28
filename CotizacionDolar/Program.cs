Console.Write("Ingrese el monto en dólares que desea comprar: ");
double montoDolar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor del dólar hoy: "); 
double valorDolar = Convert.ToDouble(Console.ReadLine());

double totalPesos = montoDolar * valorDolar;

Console.WriteLine("-------------------------------------------");
Console.WriteLine($"El monto total en pesos es: ${totalPesos}");