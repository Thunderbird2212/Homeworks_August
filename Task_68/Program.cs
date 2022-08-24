/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9

Использование функции для малых значений m, n. 
При больших значениях m и n может возникнуть переполнение стека, так как 
функция Аккермана является дважды рекурсивной: один из аргументов функции есть та же рекурсивная функция.*/

Console.Clear();

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction = A(m, n);

Console.Write($"Ackermann Function = {AckermannFunction} ");

int A(int m, int n)

{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

Console.WriteLine();



