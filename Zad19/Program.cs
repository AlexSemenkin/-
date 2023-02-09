//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("enter 5-digit number");
int N = int.Parse(Console.ReadLine()!);

if(N > 100000 || N < 10000)
{
    Console.WriteLine($"{N} not 5-digit number");
}
else if 
(N / 10000 == N % 10 && N /1000 % 10 == N % 100 / 10)
{
    Console.WriteLine($"{N} palindrome");
}
else
{
    Console.WriteLine($"{N} not palindrome");
}