using System;

void find_point(double k1, double b1, double k2, double b2)
{
    if ( k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    double point_y = (b1 - b2) / (k2 - k1);
    double point_x = (point_y - b1) / k1;
    Console.WriteLine("Координаты точки пересечения: x = " + point_x + ", y = " + point_y);
    }

}

Console.WriteLine("Для уравнения y = k1 * x + b1 Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Для уравнения y = k1 * x + b1 Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Для уравнения y = k2 * x + b2 коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Для уравнения y = k2 * x + b2 Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

find_point(k1, b1, k2, b2);
