// See https://aka.ms/new-console-template for more information
Console.WriteLine("sueldo_de_los_trabajadores");
Console.WriteLine();


Console.WriteLine("Ingresa el pago por horas: ");
double pagoporHoras = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresar las horas trabajadas: ");
double HorasTrabajadas = double.Parse(Console.ReadLine());


double sueldoBruto = pagoporHoras * HorasTrabajadas;
double AFP = sueldoBruto * 0.0287;
double SFS = sueldoBruto * 0.0304;
double TotalDescuento = AFP + SFS;
double sueldoNeto = sueldoBruto - TotalDescuento;

Console.WriteLine("Sueldo bruto: " + sueldoBruto);
Console.WriteLine("AFP: " + AFP);
Console.WriteLine("SFS: " + SFS);
Console.WriteLine("Sueldo neto: " + sueldoNeto);







