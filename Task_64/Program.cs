/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.Clear();

Console.Write("Enter number M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={m}; N={n}");
if (m <= n)
    for (int i = m; i <= n; i++)
    {
        Console.Write($"{i}, ");
    }

Console.WriteLine();