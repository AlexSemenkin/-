// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] GetArray(int size, double minValue, double maxValue)

{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return result;
}

double findDif(double[] inArray)
{
    double dif = 0;
    double min = inArray[0];
    double max = inArray[0];
    
     for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] > max)
        max = inArray[i];
        if(inArray[i] < min)
        min = inArray[i];
        dif = Math.Round(max - min, 2);
    }
    return dif;

}

Console.Clear();
double[] array = GetArray(4, 0, 10);
Console.WriteLine(String.Join(", ", array));
double dif = findDif(array);
Console.WriteLine($"difference between max and min {dif}");