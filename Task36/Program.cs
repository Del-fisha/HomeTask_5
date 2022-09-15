// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Введите желаемую длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum=0;

void Array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void Sum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        if (i % 2 == 0)
            sum += arr[i];
    }
    Console.Write($"Сумма чисел на чётных позициях массива: {sum}");
}


Array(arr);
PrintArray(arr);
Sum(arr);

