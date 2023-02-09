//Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("enter nnumber");
double N = int.Parse(Console.ReadLine()!);


if(N % 2 == 0 || N % 2 == 2  ||N % 2 == 4 || N % 2 == 6 || N % 2 == 8)
{
    Console.WriteLine(Math.Pow(N, 3));
}
else
{
     Console.WriteLine("нечетное число");
}