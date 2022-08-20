/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

int[,] matrix1 = new int[,] {
  { 1, 4, 7, 2 },
  { 5, 9, 2, 3 },
  { 8, 4, 2, 4 },
  { 5, 2, 6, 7 } };
Console.WriteLine("\nFirst Matrix:\n");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", matrix1[i, j]);
    }
    Console.WriteLine(" ");
}

int[,] matrix2 = new int[,] {
  { 1, 5, 8, 5 },
  { 4, 9, 4, 2 },
  { 7, 2, 2, 6 },
  { 2, 3, 4, 7 } };
Console.WriteLine("\nSecond Matrix:\n");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", matrix2[i, j]);
    }
    Console.WriteLine(" ");
}

int[,] matrix3 = Multiplication(matrix1, matrix2);
Console.WriteLine("\nMultiply of two Matrix:\n");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", matrix3[i, j]);

    }
    Console.WriteLine(" ");
}

int[,] Multiplication(int[,] a, int[,] b)

{
    int[,] r = new int[a.Length, b.Length];
    for (int i = 0; i < b.GetLength(1); i++)
    {
        for (int j = 0; j < b.GetLength(0); j++)
        {
            r[i, j] = 0;
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}
Console.WriteLine();
