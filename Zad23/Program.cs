// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Clear();
System.Console.WriteLine("enter number");
int N = int.Parse(Console.ReadLine());

int count = 1;

while(count <= N)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}