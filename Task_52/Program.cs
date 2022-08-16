/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
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
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int j = 0; j < column; j++)
{
    int average = 0;

    for (int i = 0; i < row; i++)
    {
        average += arr[i, j];

    }
    Console.WriteLine($"Average of Column Elements {j + 1} = {(float)average / row}");

}

Console.WriteLine();


