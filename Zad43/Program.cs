// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// имеет единственное решение, то прямые пересекаются;
// имеет бесконечное множество решений, то прямые совпадают;
// не имеет решений, то прямые не пересекаются (прямые параллельны между собой)

void chekingTheValues(double k1, double k2, double b1, double b2)
{
    if(k1 == k2 && b1 != b2)
    {
        Console.WriteLine("две прямые параллельны");
    }
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("две прямые совпадают");
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    if(k1 != k2)
    {
        Console.WriteLine($"две прямые пересекаются в точке ({x}, {y})");
    }
}
    Console.Clear();
Console.WriteLine("enter b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter k2");
double k2 = Convert.ToDouble(Console.ReadLine());

chekingTheValues(k1, k2, b1, b2);