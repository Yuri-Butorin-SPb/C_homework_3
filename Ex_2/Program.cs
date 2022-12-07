// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
double ax = double.Parse (Console.ReadLine());
Console.Write("Y: ");
double ay = double.Parse(Console.ReadLine());
Console.Write("Z: ");
double az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
double bx = double.Parse(Console.ReadLine());
Console.Write("Y: ");
double by = double.Parse(Console.ReadLine());
Console.Write("Z: ");
double bz = double.Parse(Console.ReadLine());

double Distance(double coordinate1, double coordinate2, double coordinate3, double coordinate4, double coordinate5, double coordinate6)
{
    double result = ((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
    result =  Math .Sqrt (result);
    return (result);
}

double distance = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine(distance);