/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Enter number M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt16(Console.ReadLine());
int temp = m;

if (m > n) // countdown from "N" to "M"
{
    m = n;
    n = temp;
}

ElementsSum(m, n, temp = 0);

void ElementsSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Sum of Natural Elements between M and N = {sum} ");
        return;
    }
    ElementsSum(m, n - 1, sum);
}

Console.WriteLine();