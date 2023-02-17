// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)

{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int findcount(int[] inArray)
{
    int count = 0;
    for (int i = 1; i < inArray.Length; i += 1)
    {
        if(inArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
int[] array = GetArray(10, -5, 5);
Console.WriteLine(String.Join(", ", array));
int count = findcount(array);
Console.WriteLine($"чисел больше 0: {count}");