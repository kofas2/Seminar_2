// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;
int x1 = num%a;
int x2 = num%b;
if (x1==0 && x2==0)
{
    Console.WriteLine("да, кратно обоим");
}
else 
{
    Console.WriteLine("не кратно обоим");
}