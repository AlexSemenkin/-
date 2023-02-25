// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"[{inArray[i, j]}\t]");
        }
        Console.WriteLine();
    }
}

void FindArifm(double[,] arr)
{  
   
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double arifm = 0;
        double sum =0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {   
            sum += arr[i, j];
            arifm = Math.Round(sum / arr.GetLength(1), 2);
        }
        Console.Write($"[{arifm}]\t");
    }
   
 }  


Console.Clear();
Console.WriteLine("введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк");
int col = Convert.ToInt32(Console.ReadLine()); 
double[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
Console.WriteLine();

FindArifm(array2D);