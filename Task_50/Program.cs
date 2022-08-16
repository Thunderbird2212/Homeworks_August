/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[row, column];
Random r = new Random();
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        arr[i, j] = r.Next(100);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Enter Element row position: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Element column position: ");
int c2 = Convert.ToInt32(Console.ReadLine());

if (c1 > row || c2 > column)
{
    Console.Write("No element in array");
}
else
{
    Console.WriteLine("Element Positoins [" + c1 + ", " + c2 + "] Value = " + arr[c1, c2]);
}

Console.WriteLine();



