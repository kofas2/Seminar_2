// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число a ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB==numA*numA || numA==numB*numB)
{
    Console.WriteLine("да, является");
}
else
{
    Console.WriteLine("нет не является");
}