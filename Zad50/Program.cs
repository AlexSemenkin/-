// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void FindValue(int[,] arr, int a, int b)
{
 if(a < arr.GetLength(0) && b < arr.GetLength(1))
 {
    Console.WriteLine($"позиция ({a},{b}) существует, элемент {arr[a, b]}");
 }
 else
 {
    Console.WriteLine($"позиция ({a},{b}) не существует");
 }
}

int[,] Array = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 }
};

Console.Clear();
Console.Write("Введите число строк: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число столбцов: ");
int b = Convert.ToInt32(Console.ReadLine()); 

FindValue(Array, a, b);