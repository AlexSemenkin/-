// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
string Recursiv(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return N.ToString()+", " + Recursiv(N - 1);
    }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(N));