/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] array ={
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};
Console.WriteLine();

int minSumElements = 0;
int sumElements = SumElementsRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumElements = SumElementsRow(array, i);
    if (sumElements > tempSumElements)
    {
        sumElements = tempSumElements;
        minSumElements = i;
    }
}
PrintArray(array);
Console.WriteLine($"\nThe row number with the minimal sum of elements: {minSumElements + 1}");
Console.WriteLine();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumElementsRow(int[,] array, int i)
{
    int sumElements = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumElements += array[i, j];
    }
    return sumElements;
}
