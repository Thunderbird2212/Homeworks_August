//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Enter your number: ");
int a = int.Parse(Console.ReadLine());

int DigitalSum(int a)
{
    int counter = Convert.ToString(a).Length;
    int digit = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        digit = a - a % 10;
        result = result + (a - digit);
        a = a / 10;
    }
    return result;
}

int digitalsum = DigitalSum(a);
Console.WriteLine("Sum of digits = " + digitalsum);