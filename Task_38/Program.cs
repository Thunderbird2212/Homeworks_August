/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 11);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

Console.Write("Enter array size: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(elementsCount);
PrintArray(arr);

int max = arr[0];
int min = arr[0];
int n = arr.Length;
int i = elementsCount;
int diff = 0;
for (i = 0; i < n; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
    diff = max - min;
}

Console.WriteLine("Maximum Element: " + max);
Console.WriteLine("Minimum Element: " + min);
Console.WriteLine("Difference = " + diff);
