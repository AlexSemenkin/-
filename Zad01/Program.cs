//Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("enter number");
int N = int.Parse(Console.ReadLine()!);

int sum = 0;
int number = 0;


while(N != 0)
{
    number = N % 10;
    sum = sum + number;
    N /= 10;
}
Console.WriteLine(sum);