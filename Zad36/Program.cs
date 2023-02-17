//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)

{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int findSum(int[] inArray)
{
    int sum = 0;
    for (int i = 1; i < inArray.Length; i += 2)
    {
        sum += inArray[i];
    }
    return sum;
}

Console.Clear();
int[] array = GetArray(6, -5, 5);
Console.WriteLine(String.Join(", ", array));
int sum = findSum(array);
Console.WriteLine($"сумма элементов нечетных позиций равна {sum}");