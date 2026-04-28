// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el costo del producto: ");
double costoProducto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el porcentaje de utilidad: ");
double porcentajeUtilidad = Convert.ToDouble(Console.ReadLine());

double montoUtilidad = costoProducto * (porcentajeUtilidad / 100);
double precioVenta = costoProducto + montoUtilidad;

double montoIva = costoProducto * 0.21;

double precioFinal = costoProducto + montoUtilidad + montoIva;

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("El monto de utilidad es: " +  montoUtilidad);
Console.WriteLine("El monto de IVA es: " + montoIva);
Console.WriteLine("El precio final es: " + precioFinal);

