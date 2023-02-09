//Написать программу вычисления произведения чисел от 1 до N


Console.Clear();
Console.WriteLine("enter number");
int N = int.Parse(Console.ReadLine()!);

int a = 1;
int number = 0;


while(N != 0)
{
    number = N % 10;
    a = a * number;
    N /= 10;
}
Console.WriteLine(a);