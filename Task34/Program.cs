// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Введите желаемую длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;

void NewArrayOver100(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArrayOver100(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine();
}

NewArrayOver100(array);

PrintArrayOver100(array);

for (int i = 0; i<array.Length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");


