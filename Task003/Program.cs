// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите число a ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b ");
int numB = Convert.ToInt32(Console.ReadLine());
int x1 = numA%numB;
if (x1==0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.WriteLine($"не кратно, остаток {x1}");
}