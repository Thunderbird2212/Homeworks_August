﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-100, 101);
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

var odd = arr.Where((element, index) => index % 2 != 0);
Console.WriteLine("Sum of Elements with odd index: {0}", odd.Sum());

