/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Clear();
Console.WriteLine("Введите цифру,обозначающую день недели");
int a = int.Parse(Console.ReadLine());

    if(a == 1)
{
    System.Console.WriteLine("первый день недели - понедельник, не является выходным");
}
   if(a == 2)
{
    System.Console.WriteLine("второй день недели - вторник, не является выходным");
}
   if(a == 3)
{
    System.Console.WriteLine("третий день недели - среда, не является выходным");
}
   if(a == 4)
{
    System.Console.WriteLine("чертверый день недели - чертверг, не является выходным");
}
   if(a == 5)
{
    System.Console.WriteLine("пятый день недели - пятница, не является выходным");
}
   if(a == 6)
{
    System.Console.WriteLine("шестой день недели - суббота, является выходным");
}   if(a == 7)
{
    System.Console.WriteLine("восьмой день недели - воскресенье, является выходным");
}

/*если не привязываться к наименованию дней недели
Console.Clear();
Console.WriteLine("Введите цифру,обозначающую день недели");
int a = int.Parse(Console.ReadLine());

     if(a <= 5)
{
    System.Console.WriteLine("не является выходным");
}
if(a == 6 || a == 7)
{
    System.Console.WriteLine("выходной");
}
*/