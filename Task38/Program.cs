//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите желаемый размер массива");
int n = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[n];

void NewArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100);
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
        Console.WriteLine();
}

double PosMax(double[] num)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
    }
    return max;
}

double PosMin(double[] num)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
    }
    return min;
}

NewArray(arr);
PrintArray(arr);
double diff = PosMax(arr) - PosMin(arr);
Console.WriteLine($"Максимальное число: {PosMax(arr)}, минимальное число: {PosMin(arr)}");
Console.WriteLine($"Разница между ними: {diff}");