//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Enter A number ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B number ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("A in the B power = " + Math.Pow(a, b));
