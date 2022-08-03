//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.WriteLine("Enter A number ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter B number ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("A in the B power = " + Math.Pow(a, b));

Console.Write("Enter A number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B number: ");
int b = Convert.ToInt32(Console.ReadLine());

int Power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int power = Power(a, b);
Console.WriteLine("A in the B power = " + power);