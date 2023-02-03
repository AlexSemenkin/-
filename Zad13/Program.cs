//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("введите чило");
int number = int.Parse(Console.ReadLine());

if(number < 100 || number == 0)
    {
        System.Console.WriteLine("третьей цифры нет или значене равно 0");
    }
while(number > 1000)
{
    number /= 10;
}
if(number > 100)
    {
     number = number % 10;
     System.Console.WriteLine($"третья цифра {number}");
    }
    