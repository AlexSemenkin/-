// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"число {number}");
Console.WriteLine($"получилось число {(number % 100 - (number % 100) % 10)/10}");