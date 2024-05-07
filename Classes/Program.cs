using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

System.Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
Console.Write("Maior área: ");

if(areaX > areaY){
    System.Console.WriteLine("X");
} else if (areaX < areaY) {
    System.Console.WriteLine("Y");
} else {
    System.Console.WriteLine("Áreas iguais");
}