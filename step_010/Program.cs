// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine()!, out int x);

if (x > 999 || x < 100)
{
Console.WriteLine("Количество знаков не соответсвует трем!");
return;
}
int GetSecond(int x)
{
while (x >= 100) x /= 10;
int a = x % 10;
return a;
}
{
Console.WriteLine(GetSecond(x));
}
